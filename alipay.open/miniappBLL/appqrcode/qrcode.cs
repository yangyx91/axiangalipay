using alipay.open.Enums;
using alipay.open.miniappBLL.Request.qrcode;
using alipay.open.miniappBLL.Response.qrcode;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.miniappBLL.appqrcode
{
    /// <summary>
    /// 小程序：qrcode
    /// </summary>
    public class qrcode:miniappBLL_Base
    {

        /// <summary>
        /// 小程序生成推广二维码接口
        /// </summary>
        public Response_appqrcodecreate appqrcodecreate(Request_appqrcodecreate req)
        {
            var result = new Response_appqrcodecreate();
            try
            {
                AlipayOpenAppQrcodeCreateRequest request = new AlipayOpenAppQrcodeCreateRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenAppQrcodeCreateResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.qr_code_url = res.QrCodeUrl;
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
