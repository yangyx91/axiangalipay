using alipay.open.Enums;
using alipay.open.publicBLL.Request.tradepagepay;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publictradepagepay
{
    public class tradepagepay : publicBLL_Base
    {
        /// <summary>
        /// 统一收单电脑付款页面
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public AlipayTradePagePayResponse publictradepagepay(Request_publictradepagepay req)
        {
            var result = new AlipayTradePagePayResponse();
            try
            {
                AlipayTradePagePayRequest request = new AlipayTradePagePayRequest();
                request.SetNotifyUrl(req.notifyurl);
                request.SetReturnUrl(req.returnurl);
                Dictionary<string, object> bizContent = new Dictionary<string, object>();
                bizContent.Add("out_trade_no", req.out_trade_no);
                bizContent.Add("total_amount", req.total_amount);
                bizContent.Add("subject", req.subject);
                bizContent.Add("product_code", "FAST_INSTANT_TRADE_PAY");
                request.BizContent = JsonConvert.SerializeObject(bizContent);

                AlipayTradePagePayResponse res = ExecutePageRequest(request);
                if (res != null && res.Body != null && !string.IsNullOrWhiteSpace(res.Body))
                {
                    result.Body = res.Body;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 统一收单手机付款页面
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public AlipayTradePagePayResponse publictradewappay(Request_publictradepagepay req)
        {
            var result = new AlipayTradePagePayResponse();
            try
            {
                AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
                request.SetNotifyUrl(req.notifyurl);
                request.SetReturnUrl(req.returnurl);
                Dictionary<string, object> bizContent = new Dictionary<string, object>();
                bizContent.Add("out_trade_no", req.out_trade_no);
                bizContent.Add("total_amount", req.total_amount);
                bizContent.Add("subject", req.subject);
                bizContent.Add("product_code", "QUICK_WAP_WAY");
                request.BizContent = JsonConvert.SerializeObject(bizContent);

                AlipayTradeWapPayResponse res = ExecutePageRequest(request);
                if (res != null && res.Body != null && !string.IsNullOrWhiteSpace(res.Body))
                {
                    result.Body = res.Body;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool CheckAliPayReturnParams(Dictionary<string, string> sArray)
        {
            return AlipaySignature.RSACheckV1(sArray, ALIPAY_PUBLIC_KEY, CHARSET, SignType, false);
        }

        public bool CheckAliPayNotifyParams(Dictionary<string, string> sArray)
        {
            return AlipaySignature.RSACheckV1(sArray, ALIPAY_PUBLIC_KEY, CHARSET, SignType, false);
        }
    }
}
