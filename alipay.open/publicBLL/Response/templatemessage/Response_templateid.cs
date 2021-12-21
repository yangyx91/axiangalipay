using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.templatemessage
{
    public class Response_templateid
    {
        /// <summary>
        /// 消息模板id--商户领取母版后生成的唯一模板id
        /// </summary>
        public string msg_template_id { get; set; }

        /// <summary>
        /// 模板内容: {"appId":"${ALIPAY.appId}","createTime":${ALIPAY.createTime},
        /// "toUserId":"${ALIPAY.toUserId}","msgType":"text","push":"true"}
        /// </summary>
        public string template { get; set; }
    }
}
