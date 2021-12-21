using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.traderefund
{
    public class Request_publictradefastpayrefundquery
    {
        /// <summary>
        /// 商户订单号。
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 支付宝交易号。
        /// </summary>
        public string trade_no { get; set; }


        /// <summary>
        /// 退款请求号，如果在退款请求时未传入，则该值为创建交易时的商户订单号。
        /// </summary>
        public string out_request_no { get; set; }

        /// <summary>
        /// 查询选项，
        /// 枚举支持：refund_detail_item_list：本次退款使用的资金渠道;
        /// gmt_refund_pay：退款执行成功的时间；
        /// </summary>
        public List<string> query_options { 
            get { return new List<string>() { "gmt_refund_pay" }; } 
            set { } 
        }
    }
}
