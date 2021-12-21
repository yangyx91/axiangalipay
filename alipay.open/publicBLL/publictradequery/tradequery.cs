using alipay.open.Enums;
using alipay.open.publicBLL.Request.tradequery;
using alipay.open.publicBLL.Response.tradequery;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publictradequery
{
    public class tradequery:publicBLL_Base
    {
        /// <summary>
        /// 统一收单交易查询
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_publictradequery publictradequery(Request_publictradequery req)
        {
            var result = new Response_publictradequery();
            try
            {
                AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();
                Dictionary<string, object> bizContent = new Dictionary<string, object>();
                bizContent.Add("out_trade_no", req.out_trade_no);
                bizContent.Add("trade_no", req.trade_no);
                request.BizContent = JsonConvert.SerializeObject(bizContent);

                AlipayTradeQueryResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.trade_no = res.TradeNo;
                    result.out_trade_no=res.OutTradeNo;
                    result.buyer_logon_id = res.BuyerLogonId;
                    result.trade_status = res.TradeStatus;
                    var amount = 0d;
                    if (double.TryParse(res.TotalAmount,out amount))
                    {
                        result.total_amount = Convert.ToDouble(amount);
                    }
                    if (double.TryParse(res.BuyerPayAmount, out amount))
                    {
                        result.buyer_pay_amount = Convert.ToDouble(amount);
                    }
                    if (double.TryParse(res.InvoiceAmount, out amount))
                    {
                        result.invoice_amount = Convert.ToDouble(amount);
                    }
                    result.send_pay_date = res.SendPayDate;
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
