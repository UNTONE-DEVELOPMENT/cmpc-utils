namespace cmpc
{
    public static class Utils
    {
        public static void extractFileToFolder(string file, string folder)
        {
            ZipUtil.Unzip(file, folder);
        }
    }
}
