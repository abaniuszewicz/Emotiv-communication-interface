using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VirtualKeyboard.ViewModels;

namespace VirtualKeyboard.Utilities
{
    public static class SettingsSerializer
    {
        private static readonly string _settingsFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "settings.json");

        public static void Serialize(Models.Settings settings)
        {
            File.WriteAllText(_settingsFilePath,
                JsonConvert.SerializeObject(settings, Formatting.Indented,
                    new JsonSerializerSettings() {NullValueHandling = NullValueHandling.Include}));
        }

        public static Models.Settings Deserialize()
        {
            return File.Exists(_settingsFilePath)
                ? JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText(_settingsFilePath))
                : new Models.Settings(); //file does not exists
        }
    }
}
