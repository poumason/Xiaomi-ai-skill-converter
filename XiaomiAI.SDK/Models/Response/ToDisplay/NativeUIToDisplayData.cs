using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// Native UI 显示的类型
    /// </summary>
    public class NativeUIToDisplayData : IToDisplayData
    {
        /// <summary>
        /// 显示的类型： 2 navie ui
        /// </summary>
        [JsonProperty("type")]
        public ToDisplayType Type => ToDisplayType.NativeUI;

        /// <summary>
        /// 给有显示屏的设备提供显示的文字
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 使用小米内置 UI
        /// </summary>
        [JsonProperty("ui_template")]
        public UITemplateData UiTemplate { get; set; }
    }
}