using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// HTML 显示的类型
    /// </summary>
    public class HtmlToDisplayData : IToDisplayData
    {
        /// <summary>
        /// 显示的类型： 1 HTML
        /// </summary>
        [JsonProperty("type")]
        public ToDisplayType Type => ToDisplayType.UrlOrHtml;

        /// <summary>
        /// 给有显示屏的设备提供 HTML 页面显示能力
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}