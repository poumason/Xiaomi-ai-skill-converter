using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 回傳本文
    /// </summary>
    public class ResponseData
    {
        /// <summary>
        /// 指示客户端是否需要关闭 mic (boolean optional)
        /// </summary>
        [JsonProperty("open_mic")]
        public bool? OpenMic { get; set; } = null;

        /// <summary>
        /// 需要說的文字 (jsobject required)
        /// </summary>
        [JsonProperty("to_speak")]
        public ToSpeakData ToSpeak { get; set; }

        /// <summary>
        /// 显示的内容 (jsobject required)
        /// </summary>
        [JsonProperty("to_display")]
        public IToDisplayData ToDisplay { get; set; }

        /// <summary>
        /// 回复用户时设备需要做的任務集合。
        /// </summary>
        [JsonProperty("directives")]
        public List<IDirectiveData> Directives { get; set; }

        /// <summary>
        /// 当用户没有回复或者回复的不是所希望的时候用于提示用户
        /// </summary>
        [JsonProperty("prompt")]
        public PromptData Prompt { get; set; }
    }
}