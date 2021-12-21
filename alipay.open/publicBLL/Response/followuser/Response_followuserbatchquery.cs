using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.followuser
{
    public class Response_followuserbatchquery
    {
        /// <summary>
        /// 用户的userId列表
        /// </summary>
        public List<string> user_id_list { get; set; }

        /// <summary>
        /// 查询分组的userid,批量多次时使用
        /// </summary>
        public string next_user_id { get; set; }

        /// <summary>
        /// 本次调用获取的userId个数，最大值为10000
        /// </summary>
        public string count { get; set; }
    }
}
