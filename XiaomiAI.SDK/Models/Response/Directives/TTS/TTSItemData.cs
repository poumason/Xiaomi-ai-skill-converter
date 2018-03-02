using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class TTSItemData
    {
        /// <summary>
        /// <para>tts 资源的类型</para>
        /// <para>(string required)</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type => "text";

        /// <summary>
        /// <para>tts text</para>
        /// <para>(string optional)</para>
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}