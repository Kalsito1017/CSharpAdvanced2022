namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);

            Dictionary<string, List<FileInfo>> result = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;

                if (!result.ContainsKey(extension))
                {
                    result.Add(extension, new List<FileInfo>());
                }
                result[extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var (ext, fs) in result.OrderByDescending(e => e.Value.Count()).ThenBy(e => e.Key))
            {
                sb.AppendLine(ext);

                foreach (FileInfo item in fs.OrderBy(f => f.Length))
                {
                    string line = $"--{item.Name} - {item.Length / 1024}kb";
                    sb.AppendLine(line);
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(path, textContent);
        }
    }
}