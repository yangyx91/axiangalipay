using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alipay.open
{
    #region 
    /// 参考消息类型文档：https://open.dingtalk.com/document/robots/custom-robot-access
    ///自定义机器人支持文本 (text)、链接 (link)、markdown(markdown)、ActionCard、FeedCard消息类型
    #endregion

    /// <summary>
    /// 文本 (text)
    /// </summary>
    public class DTO_MsgText : DTO_DingTalkRobotMsg
    {
        public DTO_MsgText(string msg)
        {
            this.msgtype = "text";
            this.text = new TextModel()
            {
                content = msg
            };
            this.at = new AtModel();
        }

        public TextModel text { get; set; }

        public class TextModel
        {
            /// <summary>
            /// 消息内容。
            /// </summary>
            public string content { get; set; }
        }
    }


    /// <summary>
    /// MarkDown消息类型
    /// </summary>
    public class DTO_MsgMarkDown: DTO_DingTalkRobotMsg
    {
        public DTO_MsgMarkDown(string title,string imgUrl)
        {
            this.msgtype = "markdown";
            this.markdown = new MarkDownModel()
            {
                title = title,
                text = $"![screenshot]({imgUrl})"
            };
            this.at = new AtModel();
        }

        public MarkDownModel markdown { get; set; }
        public class MarkDownModel
        {
            /// <summary>
            /// 首屏会话透出的展示内容。
            /// </summary>
            public string title { get; set; }

            /// <summary>
            /// markdown格式的消息。
            /// </summary>
            public string text { get; set; }
        }
    }

    /// <summary>
    /// link类型
    /// </summary>
    public class DTO_MsgLink: DTO_DingTalkRobotMsg
    {
        public DTO_MsgLink(string title,string messageUrl, string text="", string picUrl="")
        {
            this.msgtype = "link";
            this.link = new LinkModel()
            {
                 title=title,
                 messageUrl=messageUrl,
                 text=text,
                 picUrl=picUrl
            };
            this.at = null;
        }

        public LinkModel link { get; set; }

        public class LinkModel
        {
            /// <summary>
            /// 消息标题。
            /// </summary>
            public string title { get; set; }

            /// <summary>
            /// 消息内容。如果太长只会部分展示。
            /// </summary>
            public string text { get; set; }

            /// <summary>
            /// 点击消息跳转的URL
            /// </summary>
            public string messageUrl { get; set; }

            /// <summary>
            /// 图片URL
            /// </summary>
            public string picUrl { get; set; }
        }
    }

    /// <summary>
    /// 基类
    /// </summary>
    public class DTO_DingTalkRobotMsg 
    {
        public string msgtype { get; set; }

        public AtModel at { get; set; }

        public class AtModel
        {
            /// <summary>
            /// 被@人的手机号
            /// </summary>
            public List<string> atMobiles { get; set; }

            /// <summary>
            /// 被 @人的用户userid
            /// </summary>
            public List<string> atUserIds { get; set; }

            /// <summary>
            /// 是否@所有人
            /// </summary>
            public bool isAtAll { get; set; }

        }
    }
}
