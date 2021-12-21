using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.oauth2
{
    public class Response_oauthCode
    {
        /// <summary>
        /// 交换令牌,用于获取用户信息
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// 用户的 userId,支付宝用户的唯一 userId
        /// </summary>
        public string user_id { get; set; }

        /// <summary>
        /// 令牌有效期,交换令牌的有效期，单位秒
        /// </summary>
        public int expires_in { get; set; }

        /// <summary>
        /// 刷新令牌有效期,刷新令牌有效期，单位秒
        /// </summary>
        public int re_expires_in { get; set; }

        /// <summary>
        /// 刷新令牌,通过该令牌可以刷新 access_token
        /// </summary>
        public string refresh_token { get; set; }


    }
}
