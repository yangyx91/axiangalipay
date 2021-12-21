using Aop.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL
{
    /// <summary>
    /// 参考文档，以下配置为沙箱：https://opendocs.alipay.com/open/284/106001
    /// 买家账号rfpqjd1792@sandbox.com
    /// 登录密码111111
    /// 支付密码111111
    /// </summary>
    public class publicBLL_Base  
    { 
        /// <summary>
        /// 支付宝分配给开发者的应用ID
        /// </summary>
        public static string APPID = "2021000117695809";
        /// <summary>
        /// 开发者私钥，由开发者自己生成。
        /// </summary>
        public static string APP_PRIVATE_KEY =
        "MIIEpAIBAAKCAQEAp0XvHKVfoDdUNHmB34S3gHh85Nyo6zJdzHrLopqIdJNOTTNTZtlJ9N6Aio62Gkt+g7K+1X5vFAM7pXqSGRtoHo/yg1sN7cXz7oRcT82/WaDQ8u9e+MwwyrheR6Jj8KNsEgW2soYkLr4G3LnWuNtbdnDIb72j2uQgd7pqH2FkvfupdNRXM++s/2Yi83Y94wFDaGueGfz+j7VpQfuIq0Orl5eT21XFNfqeSlqYsOz63ZgfNtDNfJUGVEZp1xLbA8jaPvmEO4BDYc/bVRSePfXpH5T1AJAUy8sYzCPObxzzl1JMSAIKMZh0v83Y/0Sc4uruSRY5Sfzui5DiYGpvE65/pQIDAQABAoIBAFpIGKJxb4dd1Yjs+/fT/ebNITu1DUbETHQM4tPEbFnfF6f7R8x/ArezT9V46TiP/py+YNmCABnhFNRfr3L1o+C6+L2E66Ol796QefJorhqF/cDhCXVnX/5KPDiVoTNEQRQJGW6JkAXacoG3m/jyDA+FF+mXhVSjRBLa/mQpgOI4ju1U6N3sgkpZgsFuM0NBe+8FxL243Oy+P9e4Rcxq53Dg1bqwP95CvQfGohAGv2Dws3VF6cMEMJfnmae/IPMPCVZGrF1i7Vo+h9A392gkeusrAU7iVwBDsH19b2rHcBF4rQ4YUakKkquSAs4yJQarY/T55nvsbREi7A+hLZABuhECgYEA1Fs98jZ7WBkTy44racBgg6hTsFu/WBKldF00K2TcL3UZ1T0nGgrN35uuA82qUT+rMdvNSVsMlhHc9GpKb7cNW0koUQP+FLAn0NHNGBPU3ZyKw8R7KEZIU/Jo5L3noqozN+BYlGuyy/AL+lmGbXk7SyWChYi44fWXrUp9vyNCZW8CgYEAyaa3nNAjeWnIVNOrbY6Ly6UZqtg5z1MXc0XRBcF+AjOC78cLaywVEb/BuvdJnV+gLeYE4j0qYnMpUwmnf6KnjAHF8tUziS51Ve9oPVscxGohHelnlwPTpfPxw/gzWxwhQvbsP4p2UmkvOTqQrqsyF+scseOULJBMqPOrG64w6isCgYEAuaP6B2Bxe5aQo4ZplU1EElR4tNe/8nJ6ibtg+/50LlikeLG5GR8Q0sX53gFRPy31ruSEFfiujBKZomG5KOhRmNffktN2rwdAB2Ehdkb/86wB8xo0wASQ/jIQWMdbU+yOUe6iAT4VVAtJrVXOGq28k/j6nVnkpkRYkHlqbEmapakCgYBffrBddsQV716LrWH1lBfn7Nvm6FcYM8VbNajzDNrbuAE+BAkIS+v+Z80a+ZjHCk4U7mVJrqWv0dG0HVJRQ3oM95oCkazCPloaxDGdPNS2v3vHao1AGvPUF15a6+OGNiAaUk03Gh9Gj8FpXK6/yRsD8Le6FohJQlzLdfmGNku72QKBgQDM/txG2O/tGqKUocrKFhoGxFBBtWetsOHrTk4XQhyS0gZFOygOm1mwDjQjZ3wlVCDIk7Ey2wRdbdT12zjVJcnc7F7HkGYhD/YXGl522BHgO9tbdE8OLx1+Kx7P5kYLpnV/uvYgX4Y7Y1v41tkIETJcYlqcg+9EAKU0e//q23kizg==";

        /// <summary>
        /// 支付宝公钥，由支付宝生成。
        /// </summary>
        public static string ALIPAY_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnjd/xBpz7R7urTUXFUNER5Z2bZ6+dSTYnSCEHJnd2kVtisyHSqUtHRND7c+dieqo2bRGm3FlrkUtFd/7jAMYvTGcc7Lqc8D0jbPLX4zxukWb7MJgzJriYd6rdcSuBQ0hcMu1KKrlUTl898PveiWIEP0uT/I1zFG8T8S5p+9ML6mn43J05gR2/IuOcqZ7DoyzZF3jpl3C8caXRWKWWf45JaZVeIbyfOG9UYtw9gj/Ki3FvY1NkU7aPvLeYolf6ni2iPwlTbTsFtYDf1+GXqFu6P3gWZrMbwhqxKq2dVtmOshDPRDFzxJAcqsrDqDaCx5PjhtC3Kpwkz30v2tCROM7xQIDAQAB";

        /// <summary>
        /// 请求使用的编码格式，如utf-8,gbk,gb2312等
        /// </summary>
        public static string CHARSET = "utf-8";

        public static string SignType = "RSA2";

        public static string GateWay = "https://openapi.alipaydev.com/gateway.do"; //https://openapi.alipay.com/gateway.do

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
                GateWay,
                APPID,
                APP_PRIVATE_KEY,
                "json", "1.0", 
                SignType,
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
        public T ExecuteRequest<T>(IAopRequest<T> request) where T:AopResponse
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
        public T ExecuteRequest<T>(IAopRequest<T> request,string accessToken) where T : AopResponse
        {
            IAopClient client = InitAopClient();
            return client.Execute<T>(request,accessToken);
        }

        /// <summary>
        /// 授权令牌,调用alipay api open
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="accessToken"></param>
        /// <param name="appauthtoken"></param>
        /// <returns></returns>
        public T ExecuteRequest<T>(IAopRequest<T> request, string accessToken,string appauthtoken) where T : AopResponse
        { 
            IAopClient client = InitAopClient();
            return client.Execute<T>(request, accessToken,appauthtoken);
        }

        public T ExecutePageRequest<T>(IAopRequest<T> request) where T : AopResponse
        { 
            IAopClient client = InitAopClient();
            return client.pageExecute<T>(request);
        }
    }
}
