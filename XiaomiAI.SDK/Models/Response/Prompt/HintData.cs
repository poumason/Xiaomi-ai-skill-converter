using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class HintData
    {
        /// <summary>
        /// 标签显示的文字
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        public HintData(string text)
        {
            Text = text;
        }
    }
}