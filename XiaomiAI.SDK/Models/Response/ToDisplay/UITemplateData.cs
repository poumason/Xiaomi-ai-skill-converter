using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 使用小米内置 UI template 内文
    /// </summary>
    public class UITemplateData
    {
        /// <summary>
        /// 表示要使用的template的类型
        /// </summary>
        [JsonProperty("type")]
        public UITemplateType Type { get; set; } = default(UITemplateType);

        /// <summary>
        /// response.to_display.ui_template.type 为 0 时的必填字段，表示列表中的各个元素
        /// </summary>
        [JsonProperty("items")]
        public List<ItemData> Items { get; set; }

        /// <summary>
        /// 开发者的logo地址
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// response.to_display.ui_template.type为 1，2 时的必填字段，表示一个显示单元
        /// </summary>
        [JsonProperty("item")]
        public ItemData Item { get; set; }
    }
}