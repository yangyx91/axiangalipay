using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.tradequery
{
    public class Response_publictradequery
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string trade_no { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        public string buyer_logon_id { get; set; }

        /// <summary>
        /// 交易状态：
        /// WAIT_BUYER_PAY（交易创建，等待买家付款）、
        /// TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、
        /// TRADE_SUCCESS（交易支付成功）、
        /// TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        public string trade_status { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数
        /// </summary>
        public double total_amount { get; set; }

        /// <summary>
        /// 买家实付金额，单位为元，两位小数
        /// </summary>
        public double buyer_pay_amount { get; set; }

        /// <summary>
        /// 交易中用户支付的可开具发票的金额，单位为元，两位小数。
        /// </summary>
        public double invoice_amount { get; set; }

        /// <summary>
        /// 本次交易打款给卖家的时间
        /// </summary>
        public string send_pay_date { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        public string buyer_user_id { get; set; }
    }
}
