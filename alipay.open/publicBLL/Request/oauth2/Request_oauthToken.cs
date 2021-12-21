using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.oauth2
{
    public class Request_oauthToken
    {
        /// <summary>
        /// 授权令牌，通过auth_code获取的access_token
        /// </summary>
        public string auth_token { get; set; }
    }
}
