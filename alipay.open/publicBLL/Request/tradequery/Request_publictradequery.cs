using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.tradequery
{
    public class Request_publictradequery
    {
        /// <summary>
        /// 订单支付时传入的商户订单号
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string trade_no { get; set; }
    }
}
