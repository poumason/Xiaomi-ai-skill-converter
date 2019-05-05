using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    public class ConextData
    {
        /// <summary>
        /// 设备唯一标识，需要申请才会给到
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// OAuth账号绑定的额外信息
        /// </summary>
        [JsonProperty("passport")]
        public object Passport { get; set; }

        /// <summary>
        /// 客户端APP相关信息, list[ClientAppInfo]
        /// </summary>
        [JsonProperty("app_info")]
        public List<AppInfoData> AppInfo { get; set; }
    }
}