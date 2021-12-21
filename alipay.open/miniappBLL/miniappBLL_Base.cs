using Aop.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.miniappBLL
{
    public class miniappBLL_Base
    {
        /// <summary>
        /// 支付宝分配给开发者的小程序应用ID
        /// </summary>
        public static string APPID = "2021002162684160";
        /// <summary>
        /// 开发者私钥，由开发者自己生成。
        /// </summary>
        public static string APP_PRIVATE_KEY =
        "MIIEogIBAAKCAQEArWMzDSdWzSiSNg09mvbF86muYM2+ntFH0+e5VNZKIlUYMR6DdwsSbSzt3Vzr2o1HBFgh/q6q/LJO97QRfykPU2DID3ZsK/x5pBjU1xweKM1t8RFj6AIQZkZkj7kMfnA0ylxlpz1qoqNXREuOLKIoRBxnOiYNeHQGGnsqvZZ7OycjNGoktznbKq3SbTJgWDjPSNNcj2Pi+mx2WfSDywoF4wr9uLQsMQ56wDHxeXUeXJO+tfkJ3Ui1kNZKZ2TRE+JuBoRf5T1FzD2IjfufRWoB6P/WYcUngglRjda1NUiRvDskFO5FXElUfD1h/vtKSS26ywgGvxwbgq9T1tStzaRhGQIDAQABAoIBACiKtXkx5Z37CpUQ64K8iPS8jEWeViAUl1L5L+Ciaps0gn+Zvuuq7xgQFV5ZR9zGhACECw7eEKUdnFFXDXBKTYcVbjIPYqO2WUsBc2MI9BReVIK1qkKpmOQROZpRjpZR7kYS7MH6HmEBCHqzn/7Xu8qRSaHTG/s6ReMTQZ8q/I2L6ZEW/UjTT51IcnDH51CLr3lbwNabkswVXQafjMR6FJOJk8D4ckncmLx9Y3Ch2A2ySgOwqSDiWFEYOaxmn04Q7rDwBG8h7lT/vSvHl4JTQOkH063u2mEHVA0LHCzmFipfCltwl7Y21HIDhHhp4lSXkr0zX6lBDOV5keyD30DsvfECgYEA9LzyZELJKrHkhE7tii8tVO7O/2QSVW87h8utlk5dwxtPaAtKZ3PeBjOlRYwLJAg9A5aD9CpP+Ep7M8CvtXt8wIL5lmgvpR3PHduR8m0oKvPr07kRod1qhPH0+rlFCMj2XpPYEMWOaQchlsfBabyybTBdE3NzVgDSs9V+y7zUgSMCgYEAtV27RTxdkg6rga9vzWYjVWGDoCdNYuqLl6+Lode0mJ8AW5C+HKPQp3NBOrHreEyMU/tC4wVwu+GCqx9AcHMJ+8yrG0tdMJHc+Rr6fjylfGgzznDLcIdj19Q6UNYv/PKlpzEd536hnbpWjoqVC4qlR4KklnevFXPaw5ZSR0olfpMCgYAUn/PBdUtkuLcsW0ZzdcRZOwLgzPsqjgQzTnvjhdkq/xszBniPvVkBpsqP0NyDfdo+einGouY4Y3Z8hwmHvs9lneQQw9j4DkoNFxr2ljJjZEkEf703qeQ3LfjaRFDIC7+PeuAjkbKNsVcoUM9A7PEQeJnvcLRQlCMtmplj7BbwhwKBgAHD/dS4t7h6SBUlHhOD0Qg9wMhIWaqC2gUKAnP645kwwxIhIJiqx5c5ugLWRJKRPDR9F7OaE/TgRyNfVINDu28mGOxVGX0ljl8mchXUhU/mu8pgsrpPtxscx8yNqT3vJsmv4rikNPKSI9GTa8wG94DwtqV4WM3+qLyKtBZZlG/dAoGALoe17yWlZh0QGlQQnns0BT8FSjlCcYqnMym2Il2sMhKwK6uHRh47VF6jPqGNhAKHMoSOP1A/6qEInQ13GabU6Tzc5I2lH2us9T/4BrjVpHCwf+NEjE2jN6L9QPzXKrjhECNnGoSlgLJpmOYjaceO+vwgSMQd4+dsmtC8D7vr4UM=";

        /// <summary>
        /// 支付宝公钥，由支付宝生成。
        /// </summary>
        public static string ALIPAY_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnjd/xBpz7R7urTUXFUNER5Z2bZ6+dSTYnSCEHJnd2kVtisyHSqUtHRND7c+dieqo2bRGm3FlrkUtFd/7jAMYvTGcc7Lqc8D0jbPLX4zxukWb7MJgzJriYd6rdcSuBQ0hcMu1KKrlUTl898PveiWIEP0uT/I1zFG8T8S5p+9ML6mn43J05gR2/IuOcqZ7DoyzZF3jpl3C8caXRWKWWf45JaZVeIbyfOG9UYtw9gj/Ki3FvY1NkU7aPvLeYolf6ni2iPwlTbTsFtYDf1+GXqFu6P3gWZrMbwhqxKq2dVtmOshDPRDFzxJAcqsrDqDaCx5PjhtC3Kpwkz30v2tCROM7xQIDAQAB";

        /// <summary>
        /// 请求使用的编码格式，如utf-8,gbk,gb2312等
        /// </summary>
        public static string CHARSET = "utf-8";

        public static IAopClient _client = null;

        /// <summary>
        /// 初始化AopClient
        /// </summary>
        /// <returns></returns>
        public IAopClient InitAopClient()
        {
            if (_client == null)
            {
                _client = new DefaultAopClient(
                "https://openapi.alipay.com/gateway.do",
                APPID,
                APP_PRIVATE_KEY,
                "json", "1.0", "RSA2",
                ALIPAY_PUBLIC_KEY,
                CHARSET,
                false);
            }
            return _client;
        }

        public string bizContentStr(Dictionary<string, object> bizContent)
        {
            return JsonConvert.SerializeObject(bizContent);
        }

        /// <summary>
        /// 调用alipay api open
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T ExecuteRequest<T>(IAopRequest<T> request) where T : AopResponse
        {
            IAopClient client = InitAopClient();
            return client.Execute<T>(request);
        }

        /// <summary>
        /// 授权令牌,调用alipay api open
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public T ExecuteRequest<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {
            IAopClient client = InitAopClient();
            return client.Execute<T>(request, accessToken);
        }

        /// <summary>
        /// 授权令牌,调用alipay api open
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="accessToken"></param>
        /// <param name="appauthtoken"></param>
        /// <returns></returns>
        public T ExecuteRequest<T>(IAopRequest<T> request, string accessToken, string appauthtoken) where T : AopResponse
        {
            IAopClient client = InitAopClient();
            return client.Execute<T>(request, accessToken, appauthtoken);
        }
    }
}
