using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.materialimage
{
    public class Response_materialimageupload
    {
        /// <summary>
        /// 图片/视频在商家中心的唯一标识
        /// </summary>
        public string image_id { get; set; }

        /// <summary>
        /// 图片/视频的访问地址（为了防止盗链，该地址不允许嵌在其他页面展示，只能在新页面展示）
        /// </summary>
        public string image_url { get; set; }
    }
}
