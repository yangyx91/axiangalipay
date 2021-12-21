using alipay.open.Enums;
using alipay.open.publicBLL.Request.templatemessage;
using alipay.open.publicBLL.Response.templatemessage;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publictemplatemessage
{
    /// <summary>
    /// 生活号：publictemplatemessage
    /// </summary>
    public class templatemessage:publicBLL_Base
    {
        /// <summary>
        /// 消息模板领取接口
        /// </summary>
        /// <param name="req"></param>
        public Response_templateid PublicTemplateMessageGet(Request_templateid req)
        {
            var result = new Response_templateid(); 
            try
            {
                AlipayOpenPublicTemplateMessageGetRequest request = new AlipayOpenPublicTemplateMessageGetRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenPublicTemplateMessageGetResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.msg_template_id = res.MsgTemplateId;
                    result.template = res.Template;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 单发模板消息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_templatemessage PublicTemplateMessageSingleSend(Request_templatemessage req) 
        {
            var result = new Response_templatemessage();
            try
            {
                AlipayOpenPublicMessageSingleSendRequest request = new AlipayOpenPublicMessageSingleSendRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenPublicMessageSingleSendResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.code = res.Code;
                    result.msg = res.Msg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
