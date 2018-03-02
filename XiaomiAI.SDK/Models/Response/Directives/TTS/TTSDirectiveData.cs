using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class TTSDirectiveData : IDirectiveData
    {
        /// <summary>
        /// 回复用户时设备需要做的操作类型: TTS
        /// </summary>
        [JsonProperty("type")]
        public string Type => "tts";

        [JsonProperty("tts_item")]
        public TTSItemData TTSItem { get; set; } = null;
    }    
}