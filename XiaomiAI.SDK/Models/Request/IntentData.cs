using Newtonsoft.Json;

namespace XiaomiAI.SDK.Models
{
    public class IntentData
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("score")]
        public float Score { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("skillType")]
        public string SkillType { get; set; }

        [JsonProperty("sub_domain")]
        public string Subdomain { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("need_fetch_token")]
        public bool NeedFetchToken { get; set; }

        [JsonProperty("is_direct_wakeup")]
        public bool IsDirectWakeup { get; set; }
    }
}