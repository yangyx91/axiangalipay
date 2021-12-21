using alipay.open.Enums;
using alipay.open.publicBLL.Request.tradeclose;
using alipay.open.publicBLL.Response.tradeclose;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publictradeclose
{
    public class tradeclose:publicBLL_Base
    {
        /// <summary>
        /// 统一收单交易关闭接口,用于交易创建后，用户在一定时间内未进行支付，可调用该接口直接将未付款的交易进行关闭。
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_publictradeclose publictradeclose(Request_publictradeclose req)
        {
            var result = new Response_publictradeclose();
            try
            {
                AlipayTradeCloseRequest request = new AlipayTradeCloseRequest();
                Dictionary<string, object> bizContent = new Dictionary<string, object>();
                bizContent.Add("out_trade_no", req.out_trade_no);
                bizContent.Add("trade_no", req.trade_no);
                request.BizContent = JsonConvert.SerializeObject(bizContent);

                AlipayTradeCloseResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.trade_no = res.TradeNo;
                    result.out_trade_no = res.OutTradeNo;
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
