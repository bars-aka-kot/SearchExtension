namespace SearchExtension
{
    public class SearchFile
    {
        public static List<string> list = new();
        private static bool IsFoundedText(string path, string text)
        {
            using StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                var tempString = sr.ReadLine();
                if (tempString.Contains(text))
                {
                    return true;
                }
            }
            return false;
        }
        public static void SearchExstension(string path, string extension, string text)
        {
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                var exten = Path.GetExtension(file);
                if (exten == "." + extension)
                {
                    if (IsFoundedText(file, text))
                    {
                        list.Add(file);
                    }
                }
            }
            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                SearchExstension(directory, extension, text);
            }
        }
    }
}
