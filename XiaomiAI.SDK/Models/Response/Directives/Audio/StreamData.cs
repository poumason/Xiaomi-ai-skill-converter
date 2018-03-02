using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class StreamData
    {
        /// <summary>
        /// <para>播放该音频资源时需要的 token</para>
        /// <para>(string optional)</para>
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// <para>播放该音频资源时需要的 url</para>
        /// <para>(string required)</para>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// <para>播放该音频资源的起始位置</para>
        /// <para>(int optional)</para>
        /// </summary>
        [JsonProperty("offset_in_milliseconds")]
        public long OffsetInMilliseconds { get; set; }
    }
}