using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 文字显示的类型
    /// </summary>
    public class PlainTextToDisplayData : IToDisplayData
    {
        /// <summary>
        /// 显示的类型： 0 文字
        /// </summary>
        [JsonProperty("type")]
        public ToDisplayType Type => ToDisplayType.PlainText;

        /// <summary>
        /// 给有显示屏的设备提供显示的文字
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}