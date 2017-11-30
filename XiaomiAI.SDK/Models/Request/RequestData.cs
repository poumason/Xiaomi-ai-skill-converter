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
        /// 用户没有响应（一般用于无屏设备，例如小米AI音箱），开发者看到这个标志应该回复一些提醒话术提醒用户
        /// </summary>
        [JsonProperty("no_response")]
        public bool NoResponse { get; set; }
    }
}