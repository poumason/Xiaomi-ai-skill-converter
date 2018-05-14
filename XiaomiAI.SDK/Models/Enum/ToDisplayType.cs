namespace XiaomiAI.SDK.Models
{
    /// <summary>
    /// 显示的类型 
    /// </summary>
    public enum ToDisplayType
    {
        /// <summary>
        /// 文字 
        /// </summary>
        PlainText = 0,
        /// <summary>
        /// URL or HTML
        /// </summary>
        UrlOrHtml = 1,
        /// <summary>
        /// Native UI
        /// </summary>
        NativeUI = 2,
        /// <summary>
        /// Widgets, 目前主要用在电视和手机等有屏设备 
        /// </summary>
        Widgets = 3,
    }
}