using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class ApplicationData
    {
        /// <summary>
        /// 技能唯一标示
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
    }
}