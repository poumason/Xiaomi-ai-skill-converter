using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class AudioDirectiveData : IDirectiveData
    {
        /// <summary>
        /// 回复用户时设备需要做的操作类型: Audio
        /// </summary>
        [JsonProperty("type")]
        public string Type => "audio";

        /// <summary>
        /// 播放媒體資源
        /// </summary>
        [JsonProperty("audio_item")]
        public AudioItemData AudioItem { get; set; }
    }
}