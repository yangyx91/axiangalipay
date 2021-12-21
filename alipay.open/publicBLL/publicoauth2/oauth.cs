using System;
using System.Collections.Generic;
using System.Text;
using alipay.open.Enums;
using alipay.open.publicBLL.Request.oauth2;
using alipay.open.publicBLL.Response.oauth2;
using Aop.Api.Request;
using Aop.Api.Response;

namespace alipay.open.publicBLL.publicoauth2
{
    /// <summary>
    /// 生活号：publicauth
    /// </summary>
    public class oauth:publicBLL_Base 
    {
        private static string oauth2Url =
            @"https://openauth.alipay.com/oauth2/publicAppAuthorize.htm?app_id={0}&scope={1}&redirect_uri={2}";

      
        /// <summary>
        /// URL 拼接,重定向返回auth_code/临时授权码，一次有效
        /// </summary>
        /// <param name="appid">开发者应用的 APPID</param>
        /// <param name="scope">接口权限值，目前只支持 auth_user 和 auth_base 两个值</param>
        /// <param name="redirecturi">回调页面，是 经过转义 的url链接（url 必须以 http 或者 https 开头）</param>
        public string EncodeURL(string appid, string scope, string redirecturi)
        {
            return string.Format(oauth2Url, appid, scope, System.Web.HttpUtility.UrlEncode(redirecturi));
        }

        /// <summary>
        /// 当 scope=auth_base，可以获取到用户的userId；
        /// 调用：alipay.system.oauth.token，换取 access_token 和 userId
        /// </summary>
        public Response_oauthCode OauthUserId(Request_oauthCode req)
        {
            var result = new Response_oauthCode(); 
            try
            {
                AlipaySystemOauthTokenRequest request = new AlipaySystemOauthTokenRequest()
                {
                    GrantType = "authorization_code",
                    Code = req.auth_code
                };
                AlipaySystemOauthTokenResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString()&& !res.IsError)
                {
                    result.access_token=res.AccessToken;
                    result.user_id = res.UserId;
                    var expires_in = 0;
                    if (!string.IsNullOrWhiteSpace(res.ExpiresIn)&& int.TryParse(res.ExpiresIn,out expires_in))
                    {
                        result.expires_in = expires_in;
                    }
                    var reexpires_in = 0;
                    if (!string.IsNullOrWhiteSpace(res.ReExpiresIn) && int.TryParse(res.ReExpiresIn, out reexpires_in))
                    {
                        result.re_expires_in = reexpires_in;
                    }
                    result.refresh_token = res.RefreshToken;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 当scope=auth_user，通过access_token调用用户信息共享接口获取用户信息。 
        /// 接口名称：alipay.user.info.share 可以获取用户的userId、头像、昵称等基础信息。
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_oauthUserInfo OauthUserInfo(Request_oauthToken req)
        {
            var result = new Response_oauthUserInfo();
            try
            {
                AlipayUserInfoShareRequest request = new AlipayUserInfoShareRequest();
                AlipayUserInfoShareResponse res = ExecuteRequest(request,req.auth_token);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.user_id = res.UserId;
                    result.user_type = res.UserType;
                    result.nick_name = res.NickName;
                    result.user_status = res.UserStatus;
                    result.province = res.Province;
                    result.city = res.City;
                    result.avatar = res.Avatar;
                    result.gender = res.Gender;
                    result.is_certified = res.IsCertified;
                    result.is_student_certified = res.IsStudentCertified;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
