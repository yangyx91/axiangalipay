using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.qrcode
{
    public class Response_qrcodecreate
    {
        /// <summary>
        /// 二维码图片地址，可跳转到实际图片
        /// </summary>
        public string code_img { get; set; }

        /// <summary>
        /// 二维码有效时间，单位（秒）。永久码暂时忽略该信息
        /// </summary>
        public string expire_second { get; set; }
    }
}
