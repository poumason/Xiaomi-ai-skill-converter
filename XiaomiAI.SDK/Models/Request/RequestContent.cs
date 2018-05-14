using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// <para>小米大脑请求第三方开发者的接口定义</para>
    /// </summary>
    public class RequestContent
    {
        /// <summary>
        /// 版本号，表示当前智能服务对第三方 APP 的 API 版本号，可定为 1.0，后续假如更新，可以通过这个帮助 APP 判断好做兼容支持
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 用户语音输入的识别结果 
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// <para>一轮对话相关的信息</para>
        /// </summary>
        [JsonProperty("session")]
        public SessionData Session { get; set; }

        /// <summary>
        /// <para>上下文相关的信息 </para>
        /// </summary>
        [JsonProperty("context")]
        public ConextData Context { get; set; }

        /// <summary>
        /// 请求相关的信息 
        /// </summary>
        [JsonProperty("request")]
        public RequestData Request { get; set; }
    }
}