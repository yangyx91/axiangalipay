using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.followuser
{
    public class Request_followuserbatchquery
    {
        public Request_followuserbatchquery(string _next_user_id = "")
        {
            this.next_user_id = _next_user_id;
        }

        /// <summary>
        /// 当关注者数量超过10000时使用，本次拉取数据中第一个用户的userId，
        /// 从上次接口调用返回值中获取。第一次调用置空
        /// </summary>
        public string next_user_id { get; set; }
    }
}
