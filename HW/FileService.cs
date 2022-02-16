using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public static class FileService
    {
        public static void WriteLogs(Config config)
        {
            string directoryPath = config.Logger.DirectoryPath;
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            DeleteOldLoggs(directoryPath, directoryInfo);

            string fileName = DateTime.Now.ToString(config.Logger.NameFormat);
            string fileExtension = config.Logger.Extension;
            string filePath = $"{directoryPath}\\{fileName}{fileExtension}";

            using StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
            try
            {
                foreach (var log in Logger.GetLogger().GetLoggs())
                {
                    sw.WriteLine(log.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void DeleteOldLoggs(string directoryPath, DirectoryInfo directoryInfo)
        {
            var files = directoryInfo.GetFiles();

            if (files.Length > 3)
            {
                var oldestFileDate = DateTime.Now;
                string oldestFilePath = string.Empty;
                foreach (var file in files)
                {
                    if (oldestFileDate > file.LastWriteTime)
                    {
                        oldestFileDate = file.LastWriteTime;
                        oldestFilePath = file.Name;
                    }
                }

                File.Delete($"{directoryPath}\\{oldestFilePath}");
            }
        }
    }
}
