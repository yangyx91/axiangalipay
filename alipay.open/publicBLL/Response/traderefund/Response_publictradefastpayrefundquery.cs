using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.traderefund
{
    public class Response_publictradefastpayrefundquery
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string trade_no { get; set; }

        /// <summary>
        /// 创建交易传入的商户订单号
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 本笔退款对应的退款请求号
        /// </summary>
        public string out_request_no { get; set; }

        /// <summary>
        /// 发起退款时，传入的退款原因
        /// </summary>
        public string refund_reason { get; set; }

        /// <summary>
        /// 该笔退款所对应的交易的订单金额
        /// </summary>
        public double total_amount { get; set; }

        /// <summary>
        /// 本次退款请求，对应的退款金额
        /// </summary>
        public double refund_amount { get; set; }

        /// <summary>
        /// 退款状态。枚举值：
        /// REFUND_SUCCESS 退款处理成功；
        /// 未返回该字段表示退款请求未收到或者退款失败；
        /// </summary>
        public string refund_status { get; set; }

        /// <summary>
        /// 退款时间。默认不返回该信息，
        /// 需要在入参的query_options中指定"gmt_refund_pay"值时才返回该字段信息。
        /// </summary>
        public string gmt_refund_pay { get; set; }

    }
}
