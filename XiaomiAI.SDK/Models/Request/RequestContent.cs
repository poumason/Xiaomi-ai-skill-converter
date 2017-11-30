using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 小米大脑请求第三方开发者的接口定义
    /// </summary>
    public class RequestContent
    {
        /// <summary>
        /// 版本号，表示当前智能服务对第三方 AP P的 API 版本号，可定为 1.0，后续假如更新，可以通过这个帮助 APP 判断好做兼容支持
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 用户输入的文字
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// Session 本文
        /// </summary>
        [JsonProperty("session")]
        public SessionData Session { get; set; }

        /// <summary>
        /// 表示当前用户的一些账号认证信息，例如 OAuth 开发者的返回
        /// </summary>
        [JsonProperty("context")]
        public ConextData Context { get; set; }
        
        /// <summary>
        /// 請求本文
        /// </summary>
        [JsonProperty("request")]
        public RequestData Request { get; set; }
    }
}