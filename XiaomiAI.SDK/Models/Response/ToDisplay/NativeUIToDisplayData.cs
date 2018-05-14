using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// Native UI 显示的类型
    /// </summary>
    public class NativeUIToDisplayData : IToDisplayData
    {
        /// <summary>
        /// 显示的类型： 2 Native UI
        /// </summary>
        [JsonProperty("type")]
        public ToDisplayType Type => ToDisplayType.NativeUI;

        /// <summary>
        /// 给有显示屏的设备提供显示的文字
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 显示的模板，有屏设备支持一些显示模板，可以通过这个配置 
        /// </summary>
        [JsonProperty("ui_template")]
        public UITemplateData UiTemplate { get; set; }
    }
}