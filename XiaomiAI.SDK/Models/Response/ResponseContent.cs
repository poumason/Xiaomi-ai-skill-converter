using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 第三方开发者返回给小米大脑的接口定义
    /// </summary>
    public class ResponseContent
    {
        /// <summary>
        /// 在请求时指定，回传即可
        /// </summary>
        [JsonProperty("version")]
        public string version => "1.0";

        /// <summary>
        /// <para>APP希望持久化的信息，下次同session的请求提供</para>
        /// <para>JSObject</para>
        /// </summary>
        [JsonProperty("session_attributes")]
        public object SessionAttributes { get; set; } = null;

        /// <summary>
        /// 是否结束当前会话
        /// </summary>
        [JsonProperty("is_session_end")]
        public bool IsSessionEnd { get; set; } = false;

        /// <summary>
        /// 返回的具体信息
        /// </summary>
        [JsonProperty("response")]
        public ResponseData Response { get; set; }
    }
}