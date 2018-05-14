using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class EventPropertyData
    {
        /// <summary>
        /// 录音的语音识别结果文本
        /// </summary>
        [JsonProperty("asr_text")]
        public string ASRText { get; set; }

        /// <summary>
        /// 录音所得的文件id 
        /// </summary>
        [JsonProperty("msg_file_id")]
        public string MsgFileId { get; set; }
    }
}