using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 提示用户内容
    /// </summary>
    public class PromptData
    {
        /// <summary>
        /// 提示信息 (string required)
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 表示 prompt 下面的标签 (array optional)
        /// </summary>
        [JsonProperty("hints")]
        public List<HintData> Hints { get; set; }
    }
}