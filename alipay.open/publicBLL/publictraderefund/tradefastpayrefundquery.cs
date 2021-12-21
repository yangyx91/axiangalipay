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
    public class tradefastpayrefundquery:publicBLL_Base
    {
        /// <summary>
        /// 统一收单交易退款查询
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_publictradefastpayrefundquery publictradefastpayrefundquery(Request_publictradefastpayrefundquery req)
        {
            var result = new Response_publictradefastpayrefundquery();
            try
            {
                AlipayTradeFastpayRefundQueryRequest request = new AlipayTradeFastpayRefundQueryRequest();
                Dictionary<string, object> bizContent = new Dictionary<string, object>();
                bizContent.Add("out_trade_no", req.out_trade_no);
                bizContent.Add("trade_no", req.trade_no);
                bizContent.Add("out_request_no", req.out_request_no);
                bizContent.Add("query_options", req.query_options);
                request.BizContent = JsonConvert.SerializeObject(bizContent);

                AlipayTradeFastpayRefundQueryResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.trade_no = res.TradeNo;
                    result.out_trade_no = res.OutTradeNo;
                    result.out_request_no = res.OutRequestNo;
                    result.refund_reason = res.RefundReason;
                    var amount = 0d;
                    if (double.TryParse(res.TotalAmount, out amount))
                    {
                        result.total_amount = Convert.ToDouble(amount);
                    }
                    if (double.TryParse(res.RefundAmount, out amount))
                    {
                        result.refund_amount = Convert.ToDouble(amount);
                    }
                    result.refund_status = res.RefundStatus;
                    result.gmt_refund_pay = res.GmtRefundPay;
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
