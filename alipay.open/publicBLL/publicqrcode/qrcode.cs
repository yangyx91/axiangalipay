using alipay.open.Enums;
using alipay.open.publicBLL.Request.qrcode;
using alipay.open.publicBLL.Response.qrcode;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publicqrcode
{
    /// <summary>
    /// 生活号：publicqrcode
    /// </summary>
    public class qrcode : publicBLL_Base
    {
        /// <summary>
        /// 带参推广二维码接口,使用该接口可以获得多个带不同场景值的二维码，
        /// 用户扫描后，公众号可以接收到事件推送。
        /// 目前有2种类型的二维码，分别是临时二维码、和永久二维码，
        /// 前者有过期时间，最大为1800秒。 
        /// 每次创建二维码ticket需要提供一个开发者自行设定的参数（scene_id）
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_qrcodecreate publicqrcodecreate(Request_qrcodecreate req)
        {
            var result = new Response_qrcodecreate();
            try
            {
                AlipayOpenPublicQrcodeCreateRequest request = new AlipayOpenPublicQrcodeCreateRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenPublicQrcodeCreateResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.code_img = res.CodeImg;
                    result.expire_second = res.ExpireSecond;
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
