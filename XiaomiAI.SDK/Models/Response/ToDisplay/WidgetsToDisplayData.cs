using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// Widgets 显示的类型
    /// </summary>
    public class WidgetsToDisplayData : IToDisplayData
    {
        /// <summary>
        /// 显示的类型： 3 widgets
        /// </summary>
        [JsonProperty("type")]
        public ToDisplayType Type => ToDisplayType.Widgets;

        [JsonProperty("widgets")]
        public List<WidgetData> Widges { get; set; }
    }

    public class WidgetData
    {
        /// <summary>
        /// APP希望显示界面时提供的，此处为界面的标识信息
        /// </summary>
        [JsonProperty("info")]
        public WidgetInfoData Info { get; set; }

        /// <summary>
        /// APP希望显示界面时提供的，此处为界面显示所需要的参数
        /// </summary>
        [JsonProperty("params")]
        public object Parameters { get; set; }
    }

    public class WidgetInfoData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>com.xiaomi.intent.category.VOICE_CONTROL_WIDGET_WEATHER</example>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example>com.xiaomi.tweather</example>
        [JsonProperty("package_name")]
        public string PackageName { get; set; }

        [JsonProperty("min_version_code")]
        public int MiniVersionCode { get; set; }
    }
}