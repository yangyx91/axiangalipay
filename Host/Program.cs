using System;
using alipay.open.publicBLL.publicmaterialimage;
using alipay.open.publicBLL.publicmenu;
using alipay.open.publicBLL.Request.materialimage;
using System.IO;
using alipay.open.miniappBLL.appqrcode;
using alipay.open.miniappBLL.Request.qrcode;
using alipay.open.publicBLL.publictradepagepay;
using alipay.open.publicBLL.Request.tradepagepay;
using Snowflake.Core;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ///雪花IDworker生成器
            var worker = new IdWorker(1, 1);
            long id = worker.NextId();
            var publictradePay=new tradepagepay().publictradepagepay(new Request_publictradepagepay()
            {
                 out_trade_no = DateTime.Now.ToString("yyyyMMddHHmmss"),
                 total_amount=0.01,
                 subject="9.9元兑换券"
            });

            var r = publictradePay;
            //var file = new System.IO.FileInfo("D:\\Documents\\Pictures\\IMG1.jpg");
            //byte[] fileContent;
            //using (FileStream fs=File.OpenRead(file.FullName))
            //{
            //    using (MemoryStream ms=new MemoryStream())
            //    {
            //        fs.CopyTo(ms);
            //        fileContent= ms.ToArray();
            //    }
            //}
            //if (fileContent.Length>0)
            //{
            //    var uploadFile = new Request_materialimageupload()
            //    {
            //        image_name =file.Name,
            //        image_type="jpg",
            //        image_content=fileContent,
            //    };
            //    var uploadResult = new materialimage().materialimageupload(uploadFile);
            //    var newFile = uploadResult.image_id;
            //    var newFileUrl = uploadResult.image_url;
            //}

            //var req = new Request_appqrcodecreate()
            //{
            //     describe="首页",
            //     query_param="qrcode",
            //     url_param="/page/view/index"

            //};
            //var a = new qrcode().appqrcodecreate(req);

            Console.WriteLine("Hello World!");
        }
    }
}
