using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.menu
{
    public class Request_personalizedmenucreate
    {
        public Request_personalizedmenucreate()
        {
            this.type = "text";
            this.mobile_client_type = "";
        }

        /// <summary>
        /// 人群分组id。分组创建及管理接入详情参见 分组管理。注意：group_id 与 label_rule（标签规则）不能同时为空。
        /// </summary>
        public string group_id { get; set; }

        /// <summary>
        /// 手机客户端类型，枚举支持：*iphone；*android；*wp；说明：不填为不区分机型。
        /// </summary>
        public string mobile_client_type { get; set; } 

        /// <summary>
        /// 菜单类型，不填时默认为 text（文本型菜单）。枚举值如下：* text：文本型菜单。* icon：表示 icon 型菜单，
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 一级菜单列表。
        /// </summary>
        public List<ButtonObject> button { get; set; }

        /// <summary>
        /// 标签规则，目前限定只能传入1条，在个性化菜单创建成功后，满足该标签规则的用户进入生活号首页，将看到该套菜单。
        /// </summary>
        public List<QueryLabelRule> label_rule { get; set; }
    

        public class QueryLabelRule
        {
            /// <summary>
            /// 标签id
            /// </summary>
            public string label_id { get; set; }

            /// <summary>
            /// 标签名
            /// </summary>
            public string label_name { get; set; }

            /// <summary>
            /// 运算符
            /// </summary>
            public string @operator { get; set; }

            /// <summary>
            /// 标签值，多值会用英文逗号分隔
            /// </summary>
            public string label_value { get; set; }

        }


        public class ButtonObject
            {
                /// <summary>
                /// 菜单名称，icon菜单名称不超过5个汉字，文本菜单名称不超过9个汉字，编码格式为GBK
                /// </summary>
                public string name { get; set; }

                /// <summary>
                /// 菜单类型：
                /// out——事件型菜单；
                /// link——链接型菜单；
                /// tel——点击拨打电话；
                /// map——点击查看地图；
                /// consumption——点击查看用户与生活号管理员账号之间的消费记录
                /// </summary>
                public string action_type { get; set; }

                /// <summary>
                /// 当actionType为link时，该参数为url链接；
                /// 当actionType为out时，该参数为用户自定义参数；
                /// 当actionType为tel时，该参数为电话号码。
                /// 当action_type为map时，该参数为查看地图的关键字。
                /// 当action_type为consumption时，该参数可不传。
                /// 该参数最长255个字符，不允许冒号等特殊字符。
                /// </summary>
                public string action_param { get; set; }

                /// <summary>
                /// icon图片url，必须是http协议的url，尺寸为60X60，最大不超过5M，
                /// 请先调用 图片上传接口获得图片url https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload
                /// </summary>
                public string icon { get; set; }

                /// <summary>
                /// 二级菜单数组，若sub_button为空，
                /// 则一级菜单必须指定action_type和action_param的值，
                /// 二级菜单个数可以为1~5个。
                /// </summary>
                public List<SubButton> sub_button { get; set; }
            }

        public class SubButton
        {
            /// <summary>
            /// 菜单名称，icon菜单名称不超过5个汉字，
            /// 文本菜单名称不超过9个汉字，编码格式为GBK
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 菜单类型：
            /// out——事件型菜单；
            /// link——链接型菜单；
            /// tel——点击拨打电话；
            /// map——点击查看地图；
            /// consumption——点击查看用户与生活号管理员账号之间的消费记录
            /// </summary>
            public string action_type { get; set; }

            /// <summary>
            /// 当actionType为link时，该参数为url链接；
            /// 当actionType为out时，该参数为用户自定义参数；
            /// 当actionType为tel时，该参数为电话号码。
            /// 当action_type为map时，该参数为查看地图的关键字。
            /// 当action_type为consumption时，该参数可不传。
            /// 该参数最长255个字符，不允许冒号等特殊字符。
            /// </summary>
            public string action_param { get; set; }

            /// <summary>
            /// icon图片url，必须是http协议的url，尺寸为60X60，最大不超过5M，
            /// 请先调用 图片上传接口获得图片url
            /// </summary>
            public string icon { get; set; }
        }
    }
}
