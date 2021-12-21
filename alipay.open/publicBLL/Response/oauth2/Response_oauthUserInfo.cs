using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Response.oauth2
{
    public class Response_oauthUserInfo
    {
        /// <summary>
        /// 用户头像
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nick_name { get; set; }
        /// <summary>
        /// 用户注册时填写的省份
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 用户注册时填写的城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 用户性别,M为男性，F为女性
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary> 
        public string format_gender { 
            get {
                if (!string.IsNullOrWhiteSpace(gender))
                {
                    switch (gender.ToUpper().Trim())
                    {
                        case "M":
                            return "男性";
                        case "F":
                            return "女性";
                    }
                }
                return gender;
            } set { } 
        }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        public string user_id { get; set; }
        /// <summary>
        /// 用户类型,1代表公司账户;2代表个人账户
        /// </summary>
        public string user_type { get; set; }

        public string format_user_type
        {
            get
            {
                var boolInt = 0;
                if (!string.IsNullOrWhiteSpace(user_type) && int.TryParse(user_type,out boolInt))
                {
                    switch (boolInt)
                    {
                        case 1:
                            return "公司账户";
                        case 2:
                            return "个人账户";
                    }
                }
                return user_type;
            }
            set { }
        }

        /// <summary>
        /// 用户状态,Q代表快速注册用户;T代表已认证用户;B代表被冻结账户;W代表已注册，未激活的账户
        /// </summary>
        public string user_status { get; set; }

        public string format_user_status
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(user_status))
                {
                    switch (user_status.ToUpper().Trim())
                    {
                        case "Q":
                            return "快速注册用户";
                        case "T":
                            return "已认证用户";
                        case "B":
                            return "被冻结账户";
                        case "W":
                            return "已注册未激活账户";
                    }
                }
                return user_status;
            }
            set { }
        }

        /// <summary>
        /// 是否通过实名认证,T是通过 F是没有实名认证
        /// </summary>
        public string is_certified { get; set; }

        public string format_is_certified
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(is_certified))
                {
                    switch (is_certified.ToUpper().Trim())
                    {
                        case "T":
                            return "通过实名认证";
                        case "F":
                            return "没有实名认证";
                    }
                }
                return is_certified;
            }
            set { }
        }

        /// <summary>
        /// 是否是学生,T是学生 F不是学生
        /// </summary>
        public string is_student_certified { get; set; }

        public string format_is_student_certified
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(is_student_certified))
                {
                    switch (is_student_certified.ToUpper().Trim())
                    {
                        case "T":
                            return "学生";
                        case "F":
                            return "不是学生";
                    }
                }
                return is_student_certified;
            }
            set { }
        }


    }
}
