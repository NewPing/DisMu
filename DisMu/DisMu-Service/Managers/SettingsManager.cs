
using DisMu_Service.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DisMu_Service.Manager
{
    public static class SettingsManager
    {
        public static Settings settings = null;
        public static bool validSettings = false;

        public static void Init()
        {
            ReadSettings();
            CheckSettings();
        }

        private static void ReadSettings()
        {
            try
            {
                if (File.Exists("settings.json"))
                {
                    var json = File.ReadAllText("settings.json");
                    settings = JsonSerializer.Deserialize<Settings>(json);
                }
                else
                {
                    var json = JsonSerializer.Serialize(new Settings());
                    File.WriteAllText("settings.json", json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CheckSettings()
        {
            if (!String.IsNullOrWhiteSpace(settings.DiscordToken))
            {
                validSettings = true;
            }
        }
    }
}
