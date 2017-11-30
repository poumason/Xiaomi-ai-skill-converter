namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 请求的类型
    /// </summary>
    public enum RequestType
    {
        None = -1,
        /// <summary>
        /// 唤醒词请求
        /// </summary>
        Wakeup = 0,
        /// <summary>
        /// 意图请求 
        /// </summary>
        Intent = 1,
        /// <summary>
        /// 结束词请求
        /// </summary>
        End = 2,
    }
}