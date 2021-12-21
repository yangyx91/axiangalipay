using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace alipay.open.Enums
{
    /// <summary>
    /// 支付宝网关的公共错误码
    /// </summary>
    public enum responseCodeEnums
    {
        [Description("接口调用成功")]
        success=10000,
        [Description("服务不可用")]
        unservice=20000,
        [Description("授权权限不足")]
        unauthorize=20001,
        [Description("缺少必选参数")]
        requireparam = 40001,
        [Description("非法的参数")]
        invalidparam= 40002,
        [Description("业务处理失败")]
        failservice= 40004,
        [Description("权限不足")]
        forbiddenauthorize= 40006
    }
}
