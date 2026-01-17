using System.Text.Json;

namespace WinFormsAppDemo.Common
{
    public class LocalizationManager
    {
        private Dictionary<string, string> _translations = new();
        public string CurrentLanguage { get; private set; } = "zh-CN";

        public void LoadLanguage(string langCode)
        {
            CurrentLanguage = langCode;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", $"lang-{langCode}.json");
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                _translations = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new();
            }
        }

        public string GetString(string key)
        {
            return _translations.TryGetValue(key, out var value) ? value : key;
        }
    }
}
