﻿using System;
using System.Text;
using NUnit.Framework;
using CMS.Util;

namespace CMS.UtilTest
{
    public class HttpHelperTest
    {
        [Test]
        public void TestMD5Encrypt()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);  // 注册Encoding

            HttpResult httpResult = new HttpHelper().GetHtml(new HttpItem
            {
                URL = "http://whois.pconline.com.cn/ip.jsp?ip=117.64.156.76",
                ContentType = "text/html; charset=gb2312"
            });           
        }
    }
}
