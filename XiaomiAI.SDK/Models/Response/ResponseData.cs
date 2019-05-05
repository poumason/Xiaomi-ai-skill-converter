using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// <para>回傳本文</para>
    /// </summary>
    public class ResponseData
    {
        /// <summary>
        /// 是否需要开麦（相关指导建议详见最佳实践），默认不开麦 
        /// </summary>
        [JsonProperty("open_mic")]
        public bool? OpenMic { get; set; } = null;

        /// <summary>
        /// <para>tts要说的话，通常简单的回复可以使用这个字段</para>
        /// <para>(jsobject required)</para>
        /// <para>和 directives 二选一，复杂的用 directives，简单的用 tospeak</para>
        /// </summary>
        [JsonProperty("to_speak")]
        public ToSpeakData ToSpeak { get; set; }

        /// <summary>
        /// <para>有屏设备显示的数据</para>
        /// <para>(jsobject optional)</para>
        /// </summary>
        [JsonProperty("to_display")]
        public IToDisplayData ToDisplay { get; set; }

        /// <summary>
        /// <para>设备的复杂操作通常放在这里，例如多句tts，url音频播放等</para>
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

        /// <summary>
        /// 动作类型, 常见的动作有：leave_msg, play_msg等
        /// </summary>
        /// <see cref="https://xiaoai.mi.com/documents/Home?type=/api/doc/render_markdown/SkillAccess/SkillDocument/EventsAndTheme#动作"/>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// ActionPropertyData
        /// </summary>
        [JsonProperty("action_property")]
        public ActionPropertyData ActionProperty { get; set; }

        /// <summary>
        /// 需要注册的事件类型
        /// </summary>
        [JsonProperty("register_events")]
        public List<RegisterEventData> RegisterEvents { get; set; }
    }
}