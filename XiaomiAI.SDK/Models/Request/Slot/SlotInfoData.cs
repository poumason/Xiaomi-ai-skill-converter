using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    public class SlotInfoData
    {
        /// <summary>
        /// 此次请求命中的意图名称 
        /// </summary>
        [JsonProperty("intent_name")]
        public string IntentName { get; set; }

        /// <summary>
        /// 此命中的意图是否确认了，所谓意图确认是指上一轮命中了这个意图，假如开发者配置了意图确认，平台会要求用户确认一次，假如这次用户确认了，会将这个bool值设置为true 
        /// </summary>
        [JsonProperty("is_confirmed")]
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// 该意图提取出的所有槽位值 
        /// </summary>
        [JsonProperty("slots")]
        public List<SlotData> Slots { get; set; }
    }
}
