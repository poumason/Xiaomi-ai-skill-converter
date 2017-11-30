using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    public class SessionData
    {
        /// <summary>
        /// 标识该 session 是否为新的 session
        /// </summary>
        [JsonProperty("is_new")]
        public bool IsNew { get; set; }

        /// <summary>
        /// 唯一标识一轮 session
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 服务的 app
        /// </summary>
        [JsonProperty("application")]
        public ApplicationData Application { get; set; }

        /// <summary>
        /// 帮助第三方服务持久化的数据结构，下一次同 session 会带上
        /// </summary>
        [JsonProperty("attributes")]
        public object Attributes { get; set; }

        /// <summary>
        /// 用戶本文
        /// </summary>
        [JsonProperty("user")]
        public UserData User { get; set; }
    }
}