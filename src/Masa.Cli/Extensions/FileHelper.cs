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
                    filePath = filePath.Replace(item.Item1, item.Item2.Trim('.'));
                }
            }

            return filePath;
        }

        public static string CreateDirectory(string filePath)
        {
            var dir = filePath.Replace(Path.GetFileName(filePath), "");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return filePath;
        }

        public static string GetFileName(string dir, string fileFilter = "*.sln")
        {
            var files = Directory.GetFiles(dir, fileFilter, SearchOption.AllDirectories);
            if (files == null || files.Length < 1)
            {
                return null;
            }
            var file = files.First();
            return Path.GetFileNameWithoutExtension(file);
        }
    }
}
