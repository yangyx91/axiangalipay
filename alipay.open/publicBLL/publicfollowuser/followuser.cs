using alipay.open.Enums;
using alipay.open.publicBLL.Request.followuser;
using alipay.open.publicBLL.Response.followuser;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publicfollowuser
{
    /// <summary>
    /// 生活号：publicfollowuser
    /// </summary> 
    public class followuser:publicBLL_Base
    {
        /// <summary>
        /// 获取关注者列表,一次拉取调用最多拉取10000个关注者的userId，
        /// 可以通过多次拉取的方式来满足需求
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_followuserbatchquery publicfollowbatchquery(Request_followuserbatchquery req) 
        {

            var result = new Response_followuserbatchquery();
            try
            {
                AlipayOpenPublicFollowBatchqueryRequest request = new AlipayOpenPublicFollowBatchqueryRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenPublicFollowBatchqueryResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.user_id_list = res.UserIdList;
                    result.next_user_id = res.NextUserId;
                    result.count = res.Count;
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
