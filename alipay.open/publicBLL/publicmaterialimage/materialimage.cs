using alipay.open.Enums;
using alipay.open.publicBLL.Request.materialimage;
using alipay.open.publicBLL.Response.materialimage;
using Aop.Api.Request;
using Aop.Api.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace alipay.open.publicBLL.publicmaterialimage
{
    /// <summary>
    ///店铺Api：图片素材管理
    /// </summary>
    public class materialimage:publicBLL_Base
    {

        /// <summary>
        /// 上传门店照片和视频接口
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Response_materialimageupload materialimageupload(Request_materialimageupload req)
        {
            var result = new Response_materialimageupload();
            try
            {
                AlipayOfflineMaterialImageUploadRequest request = new AlipayOfflineMaterialImageUploadRequest()
                {
                    ImageContent = new Aop.Api.Util.FileItem(req.image_name,req.image_content),
                    ImageName=req.image_name,
                    ImagePid=req.image_pid,
                    ImageType=req.image_type
                };
                AlipayOfflineMaterialImageUploadResponse res = ExecuteRequest(request);
                if (res != null && res.Code == ((int)responseCodeEnums.success).ToString() && !res.IsError)
                {
                    result.image_id= res.ImageId;
                    result.image_url = res.ImageUrl;
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
