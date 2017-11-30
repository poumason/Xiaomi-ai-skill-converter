using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class ApplicationData
    {
        /// <summary>
        /// 唯一标识提供服务的 app
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
    }
}