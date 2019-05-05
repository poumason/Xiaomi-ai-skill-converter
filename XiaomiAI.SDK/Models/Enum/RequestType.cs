namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 请求的类型
    /// </summary>
    public enum RequestType
    {
        /// <summary>
        /// 唤醒词请求(技能进入请求)
        /// </summary>
        Wakeup = 0,
        /// <summary>
        /// 意图请求(技能进行中请求)
        /// </summary>
        Intent = 1,
        /// <summary>
        /// 结束词请求(请求结束请求)
        /// </summary>
        End = 2,
    }
}