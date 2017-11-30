using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// HTML 显示的类型
    /// </summary>
    public class HtmlToDisplayData : IToDisplayData
    {
        /// <summary>
        /// 显示的类型： 1 html
        /// </summary>
        [JsonProperty("type")]
        public ToDisplayType Type => ToDisplayType.UrlOrHtml;

        /// <summary>
        /// 给有显示屏的设备提供html页面显示能力
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}