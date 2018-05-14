using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 請求本文
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// 请求的类型
        /// </summary>
        [JsonProperty("type")]
        public RequestType Type { get; set; }

        /// <summary>
        /// 唯一标识一次请求
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 唯一标识一次请求的时间
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// <para>是否用户没响应小爱（例如用户没有在小爱音箱旁边），开发者看到这个标志应该回复一些提醒话术提醒用户</para>
        /// </summary>
        [JsonProperty("no_response")]
        public bool NoResponse { get; set; }

        /// <summary>
        /// <para>事件类型</para>
        /// </summary>
        /// <see cref="https://xiaoai.mi.com/documents/Home?type=/api/doc/render_markdown/SkillAccess/SkillDocument/EventsAndTheme#事件"/>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// 事件的相关信息
        /// </summary>
        [JsonProperty("event_property")]
        public EventPropertyData EventProperty { get; set; }

        /// <summary>
        /// 请求的地区，默认是 zh-CN
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// 仅当为意图请求类型时提供, 小米智能服务针对当前请求识别出的意图，用户可在开放平台网站上注册和修改
        /// </summary>
        [JsonProperty("intent")]
        public IntentData Intent { get; set; }

        /// <summary>
        /// 意图信息
        /// </summary>
        [JsonProperty("slot_info")]
        public SlotInfoData SlotInfo { get; set; }
    }
}