using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class ActionPropertyData
    {
        /// <summary>
        /// 要播放的文件id，用于play_msg动作 
        /// </summary>
        [JsonProperty("file_id_list")]
        public object FileIdList { get; set; }
    }
}