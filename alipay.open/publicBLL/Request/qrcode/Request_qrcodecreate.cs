using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.qrcode
{
    public class Request_qrcodecreate
    {
        public Request_qrcodecreate(string _sceneid="")
        {
            this.code_type = "PERM";
            this.expire_second = "";
            this.show_logo = "Y";
            this.code_info = new CodeInfo()
            {
                scene = new Scene()
                {
                    scene_id = _sceneid
                }
            };
        }

        /// <summary>
        /// 服务窗创建带参二维码接口，开发者自定义信息
        /// </summary>
        public CodeInfo code_info { get; set; }

        /// <summary>
        /// 二维码类型，目前只支持两种类型：TEMP：临时的（默认）；PERM：永久的
        /// </summary>
        public string code_type { get; set; }

        /// <summary>
        /// 临时码过期时间，以秒为单位，最大不超过1800秒；永久码置空
        /// </summary>
        public string expire_second { get; set; }

        /// <summary>
        /// 二维码中间是否显示服务窗logo，Y：显示；N：不显示（默认）
        /// </summary>
        public string show_logo { get; set; } 

        public class CodeInfo
        {
            public CodeInfo()
            {
                this.goto_url = "";
            }
            /// <summary>
            /// 场景信息
            /// </summary>
            public Scene scene { get; set; }

            public string goto_url { get; set; }
        }

        public class Scene
        {
            /// <summary>
            /// 场景Id，最长32位，英文字母、数字以及下划线，开发者自定义
            /// </summary>
            public string scene_id { get; set; }
        }
    }
}
