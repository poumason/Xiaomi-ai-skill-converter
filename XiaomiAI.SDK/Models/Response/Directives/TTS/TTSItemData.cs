using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class TTSItemData
    {
        /// <summary>
        /// tts 资源的类型 (string required), tts type
        /// </summary>
        [JsonProperty("type")]
        public string Type => "text";

        /// <summary>
        /// (string optional), tts text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}