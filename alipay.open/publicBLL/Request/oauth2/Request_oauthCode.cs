using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.oauth2
{
    public class Request_oauthCode
    {
        /// <summary>
        /// 用户对应用授权后得到，即第二步中开发者获取到的 auth_code 值
        /// </summary>
        public string auth_code { get; set; }
    }
}
