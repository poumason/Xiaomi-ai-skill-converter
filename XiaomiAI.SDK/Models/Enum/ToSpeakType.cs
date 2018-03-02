namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// tts需要说的类型
    /// </summary>
    public enum ToSpeakType
    {
        /// <summary>
        /// TTS
        /// </summary>
        TTS = 0,
        /// <summary>
        /// Audio
        /// </summary>
        Audio = 1,
        /// <summary>
        /// SSML,目前只支持 TTS
        /// </summary>
        SSML = 2,
    }
}