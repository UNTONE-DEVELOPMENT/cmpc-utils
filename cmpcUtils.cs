namespace cmpc
{
    using System;
    using System.IO.Compression;

    public static class Utils
    {
        public static void extractFileToFolder(string file, string folder)
        {
            ZipFile.ExtractToDirectory(file, folder);
        }
    }
}
