using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.materialimage
{
    public class Request_materialimageupload
    {
        public Request_materialimageupload()
        {
            this.image_pid = "";
        }
        /// <summary>
        /// 图片/视频格式,jpg或mp4
        /// </summary>
        public string image_type { get; set; }
        /// <summary>
        /// 图片/视频名称
        /// </summary>
        public string image_name { get; set; }
        /// <summary>
        /// 用于显示指定图片/视频所属的partnerId（支付宝内部使用，外部商户无需填写此字段）
        /// </summary>
        public string image_pid { get; set; }

        /// <summary>
        /// 图片/视频二进制内容，图片/视频大小不能超过5M
        /// </summary>
        public byte[] image_content { get; set; }
    }
}
