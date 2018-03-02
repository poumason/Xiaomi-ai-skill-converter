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
        /// <para>提示信息</para>
        /// <para>(string required)</para>
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// <para>表示 prompt 下面的标签</para>
        /// <para>(array optional)</para>
        /// </summary>
        [JsonProperty("hints")]
        public List<HintData> Hints { get; set; }
    }
}