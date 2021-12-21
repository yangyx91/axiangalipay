using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.tradepagepay
{
    public class Request_publictradepagepay
    {
        public string notifyurl { get; set; }
        public string returnurl { get; set; }

        public string out_trade_no { get; set; }

        public double total_amount { get; set; }

        public string subject { get; set; }
    }
}
