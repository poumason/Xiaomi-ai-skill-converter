using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class UserData
    {
        /// <summary>
        /// <para>用户唯一id，默认会对用户id进行加密，所以这个id不是真实的小米id，但是可以作为唯一标识</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// <para>如果使用了OAuth进行账号绑定，这里存放用户绑定后获取的token</para>
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>使用是否在设备上登录了小米账号</para>
        /// </summary>
        [JsonProperty("is_user_login")]
        public bool IsUserLogin { get; set; }

        /// <summary>
        /// <para>声纹识别出来的性别, 目前支持三种类型: male, female, child</para>
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }
    }
}