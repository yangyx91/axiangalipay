using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace alipay.open
{
    public static class XmlHelper
    {
        /// <summary>
        /// string字符串转XMLNode
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static XmlNode ReadXmlNode(string xmlString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            XmlNode root = doc.FirstChild;
            //示例使用
            //string nonce = root["Nonce"].InnerText;
            return root;
        }
    }
}
