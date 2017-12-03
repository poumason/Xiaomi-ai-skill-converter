using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class ConextData
    {
        /// <summary>
        /// 表示当前用户的一些账号认证信息，例如OAuth开发者的返回
        /// </summary>
        [JsonProperty("passport")]
        public object Passport { get; set; }
    }
}