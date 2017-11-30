using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class UserData
    {
        /// <summary>
        /// 用户绑定一个新的技能即生成一个新的id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户小米账号绑定开发者账号后的授权信息
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}