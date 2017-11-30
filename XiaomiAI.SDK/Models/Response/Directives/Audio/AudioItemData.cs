using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class AudioItemData
    {
        /// <summary>
        /// 播放该音频资源
        /// </summary>
        [JsonProperty("stream")]
        public StreamData Stream { get; set; }
    }
}