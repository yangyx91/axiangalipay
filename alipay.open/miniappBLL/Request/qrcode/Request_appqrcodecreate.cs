using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.miniappBLL.Request.qrcode
{
    public class Request_appqrcodecreate
    {
        /// <summary>
        /// /page/component/component-pages/view/view为小程序中能访问到的页面路径
        /// </summary>
        public string url_param { get; set; }

        /// <summary>
        /// 小程序的启动参数，打开小程序的query ，在小程序 onLaunch的方法中获取
        /// </summary>
        public string query_param { get; set; }

        /// <summary>
        /// 对应的二维码描述
        /// </summary>
        public string describe { get; set; } 
    }
}
