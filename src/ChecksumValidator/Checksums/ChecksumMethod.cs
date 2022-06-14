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
        SHA256,
        SHA384,
        SHA512,
        MD5,
        CRC32,
        // ReSharper restore InconsistentNaming
    }

    internal static class ChecksumMethodResolver
    {
        public static ChecksumMethod GetFromName(string methodName)
        {
            return methodName switch
            {
                "SHA1" => ChecksumMethod.SHA1,
                "SHA256" => ChecksumMethod.SHA256,
                "SHA384" => ChecksumMethod.SHA384,
                "SHA512" => ChecksumMethod.SHA512,
                "MD5" => ChecksumMethod.MD5,
                "CRC32" => ChecksumMethod.CRC32,
                _ => ChecksumMethod.None
            };
        }
    }

}
