using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class RegisterEventData
    {
        /// <summary>
        /// 事件名称，目前仅支持：mediaplayer.playbacknearlyfinished
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }
    }
}