using Newtonsoft.Json;
using System.Collections.Generic;

namespace XiaomiAI.SDK.Models
{
    public class ItemData
    {
        /// <summary>
        /// 图片样式
        /// </summary>
        [JsonProperty("image_style")]
        public string ImageStyle { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 响应点击事件，创建一个android intent
        /// </summary>
        [JsonProperty("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public TitleData Title { get; set; }

        /// <summary>
        /// 主体内容
        /// </summary>
        [JsonProperty("body")]
        public List<TitleData> Body { get; set; }

        /// <summary>
        /// 背景图片
        /// </summary>
        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }
    }

    public class TitleData
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// text的样式
        /// </summary>
        [JsonProperty("style")]
        public TitleStyleData Style { get; set; }
    }

    public class TitleStyleData
    {
        /// <summary>
        /// (string optional) 水平对齐的样式, (left, center, right)
        /// </summary>
        [JsonProperty("horizontal_align")]
        public HorizontalAlign HoriztionalAlign { get; set; }

        /// <summary>
        /// (string optional) 垂直对齐的样式, (top, center, bottom)
        /// </summary>
        [JsonProperty("vertical_align")]
        public VerticalAlign VerticalAlign { get; set; }
    }
}