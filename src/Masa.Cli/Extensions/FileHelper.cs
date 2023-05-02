namespace System.IO
{
    public static class FileHelper
    {
        public static string GetFileContent(string filePath, params Tuple<string, string>[] replaceStrs)
        {
            var fileContent = File.ReadAllText(filePath);
            if (replaceStrs != null && replaceStrs.Length > 0)
            {
                foreach (var item in replaceStrs)
                {
                    fileContent = fileContent.Replace(item.Item1, item.Item2);
                }
            }
            return fileContent;
        }

        public static string ReplaceFileName(string filePath, params Tuple<string, string>[] replaceStrs)
        {
            if (replaceStrs != null && replaceStrs.Length > 0)
            {
                foreach (var item in replaceStrs)
                {
                    filePath = filePath.Replace(item.Item1, item.Item2);
                }
            }

            return filePath;
        }

        public static string CreateDirectory(string filePath)
        {
            var dir= filePath.Replace(Path.GetFileName(filePath),"");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return filePath;
        }
    }
}
