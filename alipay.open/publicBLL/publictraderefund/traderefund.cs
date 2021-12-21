using alipay.open.Enums;
using alipay.open.publicBLL.Request.traderefund;
using alipay.open.publicBLL.Response.traderefund;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publictraderefund
{
    public class traderefund : publicBLL_Base
    {
        /// <summary>
        /// 统一收单交易退款接口
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_publictraderefund publictraderefund(Request_publictraderefund req)
        {
            var result = new Response_publictraderefund();
            try
            {
                AlipayTradeRefundRequest request = new AlipayTradeRefundRequest();
                Dictionary<string, object> bizContent = new Dictionary<string, object>();
                bizContent.Add("out_trade_no", req.out_trade_no);
                bizContent.Add("trade_no", req.trade_no);
                bizContent.Add("refund_amount", req.refund_amount);
                bizContent.Add("refund_reason", req.refund_reason);
                request.BizContent = JsonConvert.SerializeObject(bizContent);

                AlipayTradeRefundResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.trade_no = res.TradeNo;
                    result.out_trade_no = res.OutTradeNo;
                    result.buyer_logon_id = res.BuyerLogonId;
                    result.fund_change=res.FundChange;
                    var amount = 0d;
                    if (double.TryParse(res.RefundFee, out amount))
                    {
                        result.refund_fee = Convert.ToDouble(amount);
                    }
                    result.buyer_user_id = res.BuyerUserId;
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
