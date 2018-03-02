using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class ConextData
    {
        /// <summary>
        /// 表示当前用户的一些账号认证信息，例如 OAuth 开发者的返回
        /// </summary>
        [JsonProperty("passport")]
        public object Passport { get; set; }

        /// <summary>
        /// 表示设备的唯一标识
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
    }
}