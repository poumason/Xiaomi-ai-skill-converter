using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 需要說的文字
    /// </summary>
    public class ToSpeakData
    {
        /// <summary>
        /// <para>TTS 需要说的类型</para>
        /// <para>(int required)</para>
        /// </summary>
        [JsonProperty("type")]
        public ToSpeakType Type { get; set; } = default(ToSpeakType);

        /// <summary>
        /// TTS 需要说的文字
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}