using alipay.open.Enums;
using alipay.open.publicBLL.Request.menu;
using alipay.open.publicBLL.Response.menu;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alipay.open.publicBLL.publicmenu
{
    /// <summary>
    /// 生活号：publicmenu
    /// </summary>
    public class menu:publicBLL_Base
    {
        /// <summary>
        /// 默认菜单创建接口，每个生活号必须有一套默认菜单
        /// </summary>
        public Response_publicmenucreate publicmenucreate(Request_publicmenucreate req)
        {
            var result = new Response_publicmenucreate();
            try
            {
                AlipayOpenPublicMenuCreateRequest request = new AlipayOpenPublicMenuCreateRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenPublicMenuCreateResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.menu_key = res.MenuKey;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 默认菜单更新接口,开发者可调用该接口更新默认菜单，菜单更新成功后实时生效
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_publicmenucreate publicmenumodify(Request_publicmenucreate req)
        {
            var result = new Response_publicmenucreate();
            try
            {
                AlipayOpenPublicMenuCreateRequest request = new AlipayOpenPublicMenuCreateRequest()
                {
                    BizContent = JsonConvert.SerializeObject(req)
                };
                AlipayOpenPublicMenuCreateResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.menu_key = res.MenuKey;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        /// <summary>
        /// 菜单列表查询接口，开发者可调用该接口查询自己创建的菜单列表,
        /// 默认菜单+个性化菜单 
        /// </summary>
        /// <returns></returns>
        public Response_menubatchquery publicmenubatchquery()
        {
            var result = new Response_menubatchquery();
            try
            {
                AlipayOpenPublicMenuBatchqueryRequest request = new AlipayOpenPublicMenuBatchqueryRequest();
                AlipayOpenPublicMenuBatchqueryResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.count = res.Count;
                    result.menus = new List<Response_menubatchquery.QueryMenu>();
                    //文本菜单为“default”，icon菜单为“iconDefault”
                    if (res.Menus!=null && res.Menus.Count>0 
                        && res.Menus.Exists(m=>m.MenuKey.ToLower()=="default" 
                        || m.MenuKey.ToLower() == "icondefault"))
                    {
                        res.Menus = res.Menus.Where(m => m.MenuKey.ToLower() == "default"
                        || m.MenuKey.ToLower() == "icondefault").ToList();
                        res.Menus.ForEach(menu => {
                            var newmenu = new Response_menubatchquery.QueryMenu()
                            {
                                button = ConvertButtons(menu.Button),
                                type = menu.Type,
                                menu_key = menu.MenuKey, //该套个性化菜单key
                                label_rule = new List<Response_menubatchquery.QueryLabelRule>()
                            };

                            result.menus.Add(newmenu);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// DTO模型转换
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        private List<Response_menubatchquery.ButtonObject> ConvertButtons(
            List<Aop.Api.Domain.ButtonObject> buttons)
        {
            var buttonsResult = new List<Response_menubatchquery.ButtonObject>();
            if (buttons!=null && buttons.Count>0)
            {
                buttons.ForEach(b => {
                    var button = new Response_menubatchquery.ButtonObject()
                    {
                        action_param = b.ActionParam,
                        action_type = b.ActionType,
                        name = b.Name,
                        icon = b.Icon,
                        sub_button = new List<Response_menubatchquery.SubButton>()
                    };

                    if (b.SubButton!=null && b.SubButton.Count>0)
                    {
                        b.SubButton.ForEach(s=> {
                            var subButton = new Response_menubatchquery.SubButton()
                            {
                               action_param=s.ActionParam,
                               action_type=s.ActionType,
                               icon=s.Icon,
                               name=s.Name
                            };

                            button.sub_button.Add(subButton);
                        });
                        
                    }

                    buttonsResult.Add(button);

                });
            }
            return buttonsResult;

        }
    }
}
