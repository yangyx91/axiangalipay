using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.Request.menu
{
    public class Request_publicmenucreate
    {
        public Request_publicmenucreate()
        {
            this.type = "text";
        }

        /// <summary>
        /// 菜单类型，不填时默认为 text（文本型菜单）。枚举值如下：* text：文本型菜单。* icon：表示 icon 型菜单，
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 一级菜单列表。
        /// </summary>
        public List<ButtonObject> button { get; set; }

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
