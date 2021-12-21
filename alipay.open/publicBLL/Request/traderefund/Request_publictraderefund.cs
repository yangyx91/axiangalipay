using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.traderefund
{
    public class Request_publictraderefund
    {
        public string out_trade_no { get; set; }

        public string trade_no { get; set; }

        public double refund_amount { get; set; }

        /// <summary>
        /// 退款原因说明
        /// </summary>
        public string refund_reason { get; set; }
    }
}
