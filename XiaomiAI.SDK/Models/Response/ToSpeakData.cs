using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 需要說的文字
    /// </summary>
    public class ToSpeakData
    {
        /// <summary>
        /// int required, tts需要说的类型
        /// </summary>
        [JsonProperty("type")]
        public ToSpeakType Type { get; set; } = default(ToSpeakType);

        /// <summary>
        /// tts需要说的文字
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}