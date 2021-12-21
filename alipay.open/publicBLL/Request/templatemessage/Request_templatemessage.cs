using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.templatemessage
{
    public class Request_templatemessage
    {
        /// <summary>
        /// 支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        public string to_user_id { get; set; }

        /// <summary>
        /// 消息模板相关参数，其中包括templateId模板ID和context模板上下文
        /// </summary>
        public Template template { get; set; }

        public class Template
        {
            /// <summary>
            /// 消息模板ID
            /// </summary>
            public string template_id { get; set; }
            /// <summary>
            /// 消息模板上下文，即模板中定义的参数及参数值
            /// </summary>
            public Context context { get; set; }
        }

        public class Context
        {
            /// <summary>
            /// 顶部色条的色值,格式：#85be53
            /// </summary>
            public string head_color { get; set; }

            /// <summary>
            /// 模板跳转URL：点击消息后承接页的地址
            /// </summary>
            public string url { get; set; }

            /// <summary>
            /// 底部链接描述文字，如“查看详情”，最多能传8个汉字或16个英文字符，长度超出会报错
            /// </summary>
            public string action_name { get; set; }

            /// <summary>
            /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
            /// </summary>
            public ContextKeyword keyword1 { get; set; }

            /// <summary>
            /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
            /// </summary>
            public ContextKeyword keyword2 { get; set; }

            /// <summary>
            /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
            /// </summary>
            public ContextKeyword first { get; set; }

            /// <summary>
            /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
            /// </summary>
            public ContextKeyword remark { get; set; }
        }

        public class ContextKeyword
        {
            /// <summary>
            /// 当前文字颜色
            /// </summary>
            public string color { get; set; }
            /// <summary>
            /// 模板中占位符的值
            /// </summary>
            public string value { get; set; }
        }
    }
}
