using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class AppInfoData
    {
        /// <summary>
        /// 包名
        /// </summary>
        [JsonProperty("pkg_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version_name")]
        public int VersionCode { get; set; }
    }
}