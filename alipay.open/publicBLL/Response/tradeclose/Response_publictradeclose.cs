using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.tradeclose
{
    public class Response_publictradeclose
    {
        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。
        /// </summary>
        public string trade_no { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。
        /// </summary>
        public string out_trade_no { get; set; }
    }
}
