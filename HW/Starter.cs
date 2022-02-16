using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW
{
    public static class Starter
    {
        public static void Run()
        {
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int method = random.Next(1, 4);

                switch (method)
                {
                    case 1:
                        Actions.InfoLogg();
                        Logger.GetLogger().AddLogg(new LoggInfo(DateTime.Now,"Info", "Start method: StartApp"));
                        break;
                    case 2:
                        var ex = Actions.WarningLogg();
                        Logger.GetLogger().AddLogg(new LoggInfo(DateTime.Now, "Warning", $"Action got this custom Exception: {ex.Message}"));
                        break;
                    case 3:
                        try
                        {
                            Actions.ErrorLogg();
                        }
                        catch (Exception exception)
                        {
                            Logger.GetLogger().AddLogg(new LoggInfo(DateTime.Now, "Error", $"Action failed by reason: {exception}"));
                        }

                        break;
                }

                Console.WriteLine();

                string configFile = File.ReadAllText($"config.json");
                

                var config = JsonConvert.DeserializeObject<Config>(configFile);
                FileService.WriteLogs(config);
            }
        }
    }
}