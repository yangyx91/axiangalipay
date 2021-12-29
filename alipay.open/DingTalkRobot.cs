using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Text.Encodings;

namespace alipay.open
{
    public class DingTalkRobot
    {

        /// <summary>
        /// 钉钉机器人推送URL，参考文档：https://open.dingtalk.com/document/robots/custom-robot-access
        /// </summary>
        private static readonly string robotApi = "https://oapi.dingtalk.com/robot/send?access_token=XXXXXX";

        /// <summary>
        /// 钉钉机器人加签Sercet
        /// </summary>
        private static readonly string robotSecret = "XXXXXX";

        /// <summary>
        /// 获取加签后的钉钉机器人推送URL
        /// 2、把 timestamp和第一步得到的签名值拼接到URL中。
        /// https://oapi.dingtalk.com/robot/send?access_token=XXXXXX&timestamp=XXX&sign=XXX
        /// </summary>
        /// <returns></returns>
        public static string InitRobotApi()
        {
            if (!string.IsNullOrWhiteSpace(robotSecret))
            {
                var timeStamp = GetTimeStamp();
                var sign = SignBySHA256(timeStamp);
                return robotApi + "&timestamp=" + timeStamp + "&sign=" + sign;
            }
            return robotApi;
        }

        /// <summary>
        /// 获取时间戳,单位是毫秒，与请求调用时间误差不能超过1小时。
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        /// <summary>
        /// SHA256加签
        /// 1、把timestamp+"\n"+密钥当做签名字符串，使用HmacSHA256算法计算签名，然后进行Base64 encode，最后再把签名参数再进行urlEncode，得到最终的签名（需要使用UTF-8字符集）。
        /// </summary>
        /// <returns></returns>
        public static string SignBySHA256(string timeStamp)
        {
            var currentSignText = timeStamp + "\n" + robotSecret;
            HMACSHA256 hmacSHA256 = new HMACSHA256(Encoding.UTF8.GetBytes(robotSecret));
            byte[] signData= hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes(currentSignText));
            return System.Web.HttpUtility.UrlEncode(Convert.ToBase64String(signData));
        }

        
    }
}
