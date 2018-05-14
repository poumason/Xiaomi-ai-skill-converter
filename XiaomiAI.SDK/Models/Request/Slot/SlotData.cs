using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class SlotData
    {
        /// <summary>
        /// 槽位名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 提取出的槽位值，例如city槽位可能提取的值是北京 
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// 追问超过开发者设置的次数会通过这个值告诉开发者。 什么是追问以及怎么设置最大值详见这里 
        /// </summary>
        [JsonProperty("is_inquire_failed")]
        public bool IsInquireFailed { get; set; }
    }
}