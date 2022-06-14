namespace ChecksumValidator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel layout;
            System.Windows.Forms.Button cancel;
            System.Windows.Forms.ToolTip tooltop;
            this._methodsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._methodLabel = new System.Windows.Forms.Label();
            this._fileLabel = new System.Windows.Forms.Label();
            this._file = new System.Windows.Forms.TextBox();
            this._filePaste = new System.Windows.Forms.Button();
            this._fileBrowse = new System.Windows.Forms.Button();
            this._checksumLabel = new System.Windows.Forms.Label();
            this._checksum = new System.Windows.Forms.TextBox();
            this._checksumPaste = new System.Windows.Forms.Button();
            this._resultLabel = new System.Windows.Forms.Label();
            this._result = new System.Windows.Forms.TextBox();
            this._resultCompute = new System.Windows.Forms.Button();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._cmbMethods = new System.Windows.Forms.ComboBox();
            layout = new System.Windows.Forms.TableLayoutPanel();
            cancel = new System.Windows.Forms.Button();
            tooltop = new System.Windows.Forms.ToolTip(this.components);
            layout.SuspendLayout();
            this._methodsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            layout.AutoSize = true;
            layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            layout.ColumnCount = 3;
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            layout.Controls.Add(this._methodsContainer, 0, 0);
            layout.Controls.Add(this._fileLabel, 0, 1);
            layout.Controls.Add(this._file, 0, 2);
            layout.Controls.Add(this._filePaste, 1, 2);
            layout.Controls.Add(this._fileBrowse, 2, 2);
            layout.Controls.Add(this._checksumLabel, 0, 3);
            layout.Controls.Add(this._checksum, 0, 4);
            layout.Controls.Add(this._checksumPaste, 1, 4);
            layout.Controls.Add(this._resultLabel, 0, 5);
            layout.Controls.Add(this._result, 0, 6);
            layout.Controls.Add(this._resultCompute, 1, 6);
            layout.Location = new System.Drawing.Point(0, 0);
            layout.Margin = new System.Windows.Forms.Padding(0);
            layout.Name = "layout";
            layout.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            layout.RowCount = 7;
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            layout.Size = new System.Drawing.Size(559, 227);
            layout.TabIndex = 0;
            // 
            // _methodsContainer
            // 
            this._methodsContainer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._methodsContainer.AutoSize = true;
            this._methodsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            layout.SetColumnSpan(this._methodsContainer, 2);
            this._methodsContainer.Controls.Add(this._methodLabel);
            this._methodsContainer.Controls.Add(this._cmbMethods);
            this._methodsContainer.Location = new System.Drawing.Point(7, 10);
            this._methodsContainer.Margin = new System.Windows.Forms.Padding(0);
            this._methodsContainer.Name = "_methodsContainer";
            this._methodsContainer.Size = new System.Drawing.Size(241, 29);
            this._methodsContainer.TabIndex = 0;
            // 
            // _methodLabel
            // 
            this._methodLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._methodLabel.AutoSize = true;
            this._methodLabel.Location = new System.Drawing.Point(0, 7);
            this._methodLabel.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._methodLabel.Name = "_methodLabel";
            this._methodLabel.Size = new System.Drawing.Size(111, 15);
            this._methodLabel.TabIndex = 0;
            this._methodLabel.Text = "Checksum method:";
            // 
            // _fileLabel
            // 
            this._fileLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._fileLabel.AutoSize = true;
            this._fileLabel.Location = new System.Drawing.Point(7, 49);
            this._fileLabel.Margin = new System.Windows.Forms.Padding(0, 10, 4, 0);
            this._fileLabel.Name = "_fileLabel";
            this._fileLabel.Size = new System.Drawing.Size(74, 15);
            this._fileLabel.TabIndex = 0;
            this._fileLabel.Text = "File to verify:";
            // 
            // _file
            // 
            this._file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._file.Location = new System.Drawing.Point(11, 69);
            this._file.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._file.Name = "_file";
            this._file.Size = new System.Drawing.Size(396, 23);
            this._file.TabIndex = 0;
            this._file.TextChanged += new System.EventHandler(this.CheckComputationAvailability);
            // 
            // _filePaste
            // 
            this._filePaste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filePaste.AutoSize = true;
            this._filePaste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._filePaste.Image = global::ChecksumValidator.Resources.Resources.Paste;
            this._filePaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._filePaste.Location = new System.Drawing.Point(415, 67);
            this._filePaste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._filePaste.Name = "_filePaste";
            this._filePaste.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this._filePaste.Size = new System.Drawing.Size(30, 27);
            this._filePaste.TabIndex = 0;
            tooltop.SetToolTip(this._filePaste, "Paste clipboard as \"File to verify\"");
            this._filePaste.UseVisualStyleBackColor = true;
            this._filePaste.Click += new System.EventHandler(this.OnFilePaste);
            // 
            // _fileBrowse
            // 
            this._fileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fileBrowse.AutoSize = true;
            this._fileBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._fileBrowse.Image = global::ChecksumValidator.Resources.Resources.Open;
            this._fileBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._fileBrowse.Location = new System.Drawing.Point(449, 67);
            this._fileBrowse.Margin = new System.Windows.Forms.Padding(0, 3, 4, 3);
            this._fileBrowse.Name = "_fileBrowse";
            this._fileBrowse.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this._fileBrowse.Size = new System.Drawing.Size(99, 27);
            this._fileBrowse.TabIndex = 0;
            this._fileBrowse.Text = " Browse";
            this._fileBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tooltop.SetToolTip(this._fileBrowse, "Browse for \"File to verify\"");
            this._fileBrowse.UseVisualStyleBackColor = true;
            this._fileBrowse.Click += new System.EventHandler(this.OnBrowse);
            // 
            // _checksumLabel
            // 
            this._checksumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._checksumLabel.AutoSize = true;
            this._checksumLabel.Location = new System.Drawing.Point(7, 107);
            this._checksumLabel.Margin = new System.Windows.Forms.Padding(0, 10, 4, 0);
            this._checksumLabel.Name = "_checksumLabel";
            this._checksumLabel.Size = new System.Drawing.Size(115, 15);
            this._checksumLabel.TabIndex = 0;
            this._checksumLabel.Text = "Expected checksum:";
            // 
            // _checksum
            // 
            this._checksum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._checksum.Location = new System.Drawing.Point(11, 127);
            this._checksum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._checksum.Name = "_checksum";
            this._checksum.Size = new System.Drawing.Size(396, 23);
            this._checksum.TabIndex = 0;
            // 
            // _checksumPaste
            // 
            this._checksumPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._checksumPaste.AutoSize = true;
            this._checksumPaste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            layout.SetColumnSpan(this._checksumPaste, 2);
            this._checksumPaste.Image = global::ChecksumValidator.Resources.Resources.Paste;
            this._checksumPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._checksumPaste.Location = new System.Drawing.Point(415, 125);
            this._checksumPaste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._checksumPaste.Name = "_checksumPaste";
            this._checksumPaste.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this._checksumPaste.Size = new System.Drawing.Size(133, 27);
            this._checksumPaste.TabIndex = 0;
            this._checksumPaste.Text = "Paste";
            this._checksumPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tooltop.SetToolTip(this._checksumPaste, "Paste clipboard as \"Expected checksum\"");
            this._checksumPaste.UseVisualStyleBackColor = true;
            this._checksumPaste.Click += new System.EventHandler(this.OnChecksumPaste);
            // 
            // _resultLabel
            // 
            this._resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._resultLabel.AutoSize = true;
            this._resultLabel.Enabled = false;
            this._resultLabel.Location = new System.Drawing.Point(7, 165);
            this._resultLabel.Margin = new System.Windows.Forms.Padding(0, 10, 4, 0);
            this._resultLabel.Name = "_resultLabel";
            this._resultLabel.Size = new System.Drawing.Size(124, 15);
            this._resultLabel.TabIndex = 0;
            this._resultLabel.Text = "Computed checksum:";
            // 
            // _result
            // 
            this._result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._result.BackColor = System.Drawing.SystemColors.Window;
            this._result.Enabled = false;
            this._result.Location = new System.Drawing.Point(11, 187);
            this._result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._result.Name = "_result";
            this._result.ReadOnly = true;
            this._result.Size = new System.Drawing.Size(396, 23);
            this._result.TabIndex = 0;
            // 
            // _resultCompute
            // 
            this._resultCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._resultCompute.AutoSize = true;
            layout.SetColumnSpan(this._resultCompute, 2);
            this._resultCompute.Enabled = false;
            this._resultCompute.Image = global::ChecksumValidator.Resources.Resources.Run;
            this._resultCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._resultCompute.Location = new System.Drawing.Point(415, 183);
            this._resultCompute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._resultCompute.Name = "_resultCompute";
            this._resultCompute.Padding = new System.Windows.Forms.Padding(7, 1, 4, 1);
            this._resultCompute.Size = new System.Drawing.Size(133, 31);
            this._resultCompute.TabIndex = 0;
            this._resultCompute.Text = "Compute";
            this._resultCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tooltop.SetToolTip(this._resultCompute, "Compute checksum and verify it against the specified expected value");
            this._resultCompute.UseVisualStyleBackColor = true;
            this._resultCompute.Click += new System.EventHandler(this.OnCompute);
            // 
            // cancel
            // 
            cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancel.Location = new System.Drawing.Point(0, 0);
            cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cancel.Name = "cancel";
            cancel.Size = new System.Drawing.Size(88, 27);
            cancel.TabIndex = 0;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _timer
            // 
            this._timer.Interval = 20;
            // 
            // _cmbMethods
            // 
            this._cmbMethods.FormattingEnabled = true;
            this._cmbMethods.Location = new System.Drawing.Point(118, 3);
            this._cmbMethods.Name = "_cmbMethods";
            this._cmbMethods.Size = new System.Drawing.Size(120, 23);
            this._cmbMethods.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AcceptButton = this._resultCompute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = cancel;
            this.ClientSize = new System.Drawing.Size(693, 316);
            this.Controls.Add(layout);
            this.Controls.Add(cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main dialog";
            layout.ResumeLayout(false);
            layout.PerformLayout();
            this._methodsContainer.ResumeLayout(false);
            this._methodsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _file;
        private System.Windows.Forms.Label _checksumLabel;
        private System.Windows.Forms.TextBox _checksum;
        private System.Windows.Forms.Button _fileBrowse;
        private System.Windows.Forms.Button _checksumPaste;
        private System.Windows.Forms.Label _resultLabel;
        private System.Windows.Forms.Button _resultCompute;
        private System.Windows.Forms.TextBox _result;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Label _fileLabel;
        private System.Windows.Forms.FlowLayoutPanel _methodsContainer;
        private System.Windows.Forms.Label _methodLabel;
        private System.Windows.Forms.Button _filePaste;
        private ComboBox _cmbMethods;
    }
}