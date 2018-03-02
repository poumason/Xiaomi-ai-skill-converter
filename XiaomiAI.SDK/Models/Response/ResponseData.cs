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
        /// 指示客户端是否需要关闭mic, true，打开麦克风；false，关闭麦克风
        /// </summary>
        [JsonProperty("open_mic")]
        public bool? OpenMic { get; set; } = null;

        /// <summary>
        /// <para>需要說的文字</para>
        /// <para>(jsobject required)</para>
        /// <para>和directive 二选一，复杂的用directive，简单的用tospeak</para>
        /// </summary>
        [JsonProperty("to_speak")]
        public ToSpeakData ToSpeak { get; set; }

        /// <summary>
        /// <para>显示的内容</para>
        /// <para>(jsobject optional)</para>
        /// </summary>
        [JsonProperty("to_display")]
        public IToDisplayData ToDisplay { get; set; }

        /// <summary>
        /// <para>回复用户时设备需要做的任務集合。</para>
        /// <para>例如播放音频, 和tospeak 二选一，复杂的用directive，简单的用tospeak</para>
        /// </summary>
        [JsonProperty("directives")]
        public List<IDirectiveData> Directives { get; set; }

        /// <summary>
        /// 当用户没有回复或者回复的不是所希望的时候用于提示用户
        /// </summary>
        [JsonProperty("prompt")]
        public PromptData Prompt { get; set; }

        /// <summary>
        /// 表示开发者是否理解语义，平台会计数决定是否退出技能(最多两次)，详见技能最佳实践
        /// </summary>
        [JsonProperty("not_understand")]
        public bool NotUnderstand { get; set; }
    }
}