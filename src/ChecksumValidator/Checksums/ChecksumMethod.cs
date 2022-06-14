namespace ChecksumValidator.Checksums
{

    /// <summary>
    /// Define supported checksum (hash) methods.
    /// </summary>
    internal enum ChecksumMethod
    {
        // ReSharper disable InconsistentNaming
        None = 0,
        SHA1,
        MD5,
        CRC32,
        // ReSharper restore InconsistentNaming
    }

}
