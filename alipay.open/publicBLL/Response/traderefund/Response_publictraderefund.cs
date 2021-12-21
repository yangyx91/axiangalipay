using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.traderefund
{
    public class Response_publictraderefund
    {
        public string trade_no { get; set; }

        public string out_trade_no { get; set; }

        public string buyer_logon_id { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化
        /// </summary>
        public string fund_change { get; set; }

        /// <summary>
        /// 退款总金额。
        /// </summary>
        public double refund_fee { get; set; }

        public string buyer_user_id { get; set; }

    }
}
