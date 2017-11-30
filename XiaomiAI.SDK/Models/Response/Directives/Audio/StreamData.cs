using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class StreamData
    {
        /// <summary>
        /// 播放该音频资源时需要的 token (string optional)
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// 播放该音频资源时需要的 url (string required)
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 播放该音频资源的起始位置 (int optional)
        /// </summary>
        [JsonProperty("offset_in_milliseconds")]
        public long OffsetInMilliseconds { get; set; }
    }
}