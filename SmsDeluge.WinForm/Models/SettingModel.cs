using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmsDeluge.WinForm.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsDeluge.WinForm.Models
{
    public class SettingModel
    {
        private const string SETTING_JSON = "setting.json";

        public string Desc { get; set; }
        public string Method { get; set; }
        public string Url { get; set; }
        public Dictionary<string, string> Header { get; set; }
        public JToken Data { get; set; }
        public string Content { get; set; }

        public async Task<List<SettingModel>> GetSettingsAsync(string mobile)
        {
            if (!File.Exists(SETTING_JSON))
            {
                return null;
            }
            var josn = File.ReadAllText(SETTING_JSON);
            List<SettingModel> settings;
            try
            {
                settings = JsonConvert.DeserializeObject<List<SettingModel>>(josn);
            }
            catch (Exception ex)
            {
                return null;
            }
            settings.ForEach(f => {
                if (!string.IsNullOrWhiteSpace(f.Url))
                {
                    f.Url = f.Url.Replace("[phone]", mobile).Replace("[timestamp]", DateTime.Now.Timestamp().ToString());
                }
                if (f.Data != null)
                {
                    f.Content = f.Data.ToString().Replace("[phone]", mobile).Replace("[timestamp]", DateTime.Now.Timestamp().ToString());
                    f.Content = f.Content.Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace(" ", "").Replace("\"", "'");
                }
            });
            return await Task.FromResult(settings);
        }
    }
}
