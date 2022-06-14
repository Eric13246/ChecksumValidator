using ChecksumValidator.Checksums;
using ChecksumValidator.Utilities;

namespace ChecksumValidator
{
    public sealed partial class MainForm : Form
    {
        private string _error;
        private readonly ColorPulser _greenPulser;
        private long _nextTitleUpdateTicks; // earliest time when titlebar can be updated again (DateTime ticks); for discussion on reason behind this see http://stackoverflow.com/questions/380380/how-to-force-a-redraw-of-my-applications-entry-in-the-taskbar
        private readonly ColorPulser _redPulser;

        /// <summary>
        /// Create new instance of main form, initializing
        /// controls (designer), fonts, icon and color pulsers
        /// (pulsers are used to temporarily highlight input
        /// controls when something interesting happens).
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
            if (Font != null)
            {
                var boldFont = new Font(Font, FontStyle.Bold);
                _methodLabel.Font = _fileLabel.Font = _checksumLabel.Font = _resultLabel.Font = boldFont;
            }

            Icon = Resources.Resources.App;
            Text = Resources.Resources.Title;

            var ongoingPulses = new List<object>();
            _greenPulser = new ColorPulser(
                _timer,
                ongoingPulses,
                SystemColors.Window,
                Color.PaleGreen, //SystemColors.Info,
                TimeSpan.FromMilliseconds(250));
            _redPulser = new ColorPulser(
                _timer,
                ongoingPulses,
                SystemColors.Window,
                Color.MistyRose,
                TimeSpan.FromMilliseconds(250));
            _result.MouseClick += OnErrorDetails;
            HelpRequested += OnErrorDetails;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _file.Focus();
        }

        private void CheckComputationAvailability(object sender, EventArgs e)
        {
            _resultCompute.Enabled = !string.IsNullOrEmpty(_file.Text);
        }

        private void OnBrowse(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog
            {
                CheckFileExists = false,
                CheckPathExists = false,
                DereferenceLinks = true,
                Multiselect = false,
                Title = "Select file to compute checksum for",
                Filter = "Executable files (*.exe;*.msi;*.msu;*.iso)|*.exe;*.msi;*.msu;*.iso|All files (*.*)|*.*",
            })
            {
                if (!string.IsNullOrEmpty(_file.Text))
                {
                    try
                    {
                        dlg.InitialDirectory = Path.GetDirectoryName(_file.Text);
                    }
                    catch (ArgumentException) { }
                }
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _file.Text = dlg.FileName;
                    _greenPulser.Pulse(_file);
                    CheckComputationAvailability(null, null);
                    _checksum.Focus();
                }
            }
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void OnChecksumPaste(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                _checksum.Text = Clipboard.GetText();
                _checksum.Select(_checksum.Text.Length, 0);
                _greenPulser.Pulse(_checksum);
                if (_resultCompute.Enabled)
                {
                    _resultCompute.Focus();
                }
            }
        }

        private async void OnCompute(object sender, EventArgs e)
        {
            if (_resultCompute.Tag != null)
            {
                Checksum.Cancel = true;
                _resultCompute.Text = "Cancelling";
            }
            else
            {
                _result.Enabled = true;

                FileInfo fileInfo = null;
                try { fileInfo = new FileInfo(_file.Text); } catch (ArgumentException) { }
                if (fileInfo == null || !fileInfo.Exists)
                {
                    _file.Focus();
                    _result.ForeColor = Color.Red;
                    _result.Text = "Specified file does not exist or is not readable";
                    _result.Select(_result.Text.Length, 0);

                    _redPulser.Pulse(_file);
                    _redPulser.Pulse(_result);
                    return;
                }

                _methodsContainer.Enabled = false;
                _checksumLabel.Enabled = false;
                _checksum.Enabled = false;
                _checksumPaste.Enabled = false;
                _fileLabel.Enabled = false;
                _file.Enabled = false;
                _filePaste.Enabled = false;
                _fileBrowse.Enabled = false;
                _resultLabel.Enabled = true;
                _result.ForeColor = SystemColors.ControlText;
                OnComputeProgress(0m);
                //_greenPulser.Pulse(_result);
                _resultCompute.Text = "Cancel";
                _resultCompute.Image = Resources.Resources.Stop;
                _resultCompute.Tag = string.Empty; // make Tag non-null
                _resultCompute.Focus();

                Checksum.Cancel = false;
                _error = null;

                ChecksumMethod method;
                if (_methodMd5.Checked)
                    method = ChecksumMethod.MD5;
                else if (_methodSha1.Checked)
                    method = ChecksumMethod.SHA1;
                else
                    method = ChecksumMethod.CRC32;

                string checksum = null;
                string error = null;

                try
                {
                    Task<string> computeChecksumTask = Checksum.ComputeChecksumAsync(fileInfo.FullName, method, OnComputeProgress);
                    checksum = await computeChecksumTask;
                }
                catch (Exception ex)
                {
                    error = (ex is ThreadInterruptedException
                        ? string.Empty
                        : TraceUtilities.BuildExceptionReport(
                            "Checksum computation failed",
                            string.Empty, null, ex, null).ToString());
                    if (error.Length > 0)
                    {
                        TraceUtilities.TraceMultilineText(error, "Checksum Error");
                    }
                }
                finally
                {
                    OnComputeReportResults(checksum, error); // marshall to the UI thread
                }
            }
        }

        private void OnComputeProgress(decimal percentage)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<decimal>(OnComputeProgress), percentage); // marshall to the UI thread
            }
            else
            {
                var percentageStr = percentage.ToString("0.0%");
                var currentTicks = DateTime.Now.Ticks;
                if (currentTicks > _nextTitleUpdateTicks)
                {
                    const long delay = 150 * TimeSpan.TicksPerMillisecond;
                    _nextTitleUpdateTicks = currentTicks + delay;
                    Text = string.Concat(percentageStr, " - ", Resources.Resources.Title);
                }
                _result.Text = string.Concat("Please wait... (", percentageStr, " complete)");
            }
        }

        private void OnComputeReportResults(string checksum, string error)
        {
            Text = Resources.Resources.Title;
            _methodsContainer.Enabled = true;
            _checksumLabel.Enabled = true;
            _checksum.Enabled = true;
            _checksumPaste.Enabled = true;
            _fileLabel.Enabled = true;
            _file.Enabled = true;
            _filePaste.Enabled = true;
            _fileBrowse.Enabled = true;
            _resultCompute.Text = "Compute";
            _resultCompute.Image = Resources.Resources.Run;
            _resultCompute.Tag = null;

            if (error != null)
            {
                if (error.Length == 0)
                {
                    _result.Text = "Cancelled";
                }
                else
                {
                    _error = error;
                    _result.Text = "Failed (click here or press F1 for error details)";
                }
                _redPulser.Pulse(_result);
                _result.ForeColor = Color.Red;
            }
            else
            {
                var identical = StringComparer.OrdinalIgnoreCase.Equals(checksum, _checksum.Text.Trim());
                _result.Text = string.Concat(
                    checksum ?? "(no results)",
                    " - ",
                    identical ? "OK" : "INVALID");
                _result.ForeColor = identical ? Color.Green : Color.Red;
                if (identical)
                {
                    _greenPulser.Pulse(_checksum);
                    _greenPulser.Pulse(_result);
                }
                else
                {
                    _checksum.Focus();
                    _redPulser.Pulse(_checksum);
                    _redPulser.Pulse(_result);
                }
            }

            _result.Select(_result.Text.Length, 0);
        }

        private void OnErrorDetails(object sender, EventArgs e)
        {
            if (_error != null)
            {
                MessageBox.Show(
                    this,
                    _error,
                    "SHA1 Computation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void OnFilePaste(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                _file.Text = Clipboard.GetText();
                _file.Select(_file.Text.Length, 0);
                _greenPulser.Pulse(_file);
                CheckComputationAvailability(null, null);
                _checksum.Focus();
            }
        }
    }
}