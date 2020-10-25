
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
        #if DEBUG
        private static string settingsPath = Path.GetFullPath(@"..\..\") + "settings.json";
        #else
        private static string settingsPath = "settings.json";
        #endif
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
                if (File.Exists(settingsPath))
                {
                    var json = File.ReadAllText(settingsPath);
                    settings = JsonSerializer.Deserialize<Settings>(json);
                }
                else
                {
                    var json = JsonSerializer.Serialize(new Settings());
                    File.WriteAllText(settingsPath, json);
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
