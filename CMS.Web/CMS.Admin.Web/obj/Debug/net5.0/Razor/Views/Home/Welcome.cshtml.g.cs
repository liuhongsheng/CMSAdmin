#pragma checksum "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7106bd13966bb4a4f4dce10a3b8d2c40e0856c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Entity.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Admin.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\_ViewImports.cshtml"
using CMS.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7106bd13966bb4a4f4dce10a3b8d2c40e0856c3", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d07137d6e6fbcb9234aab7a3cfde8f550b61455", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\Home\Welcome.cshtml"
   Layout = "~/Views/Shared/_FormGray.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""col-sm-12"">
        <div class=""row"">
            <!--<div class=""col-sm-6"">
                <div class=""ibox float-e-margins"">
                    <div class=""ibox-title"">
                        <h5>框架介绍</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                            <a class=""close-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <div class=""row"">
                            <div class=""col-sm-12"" style=""font-size:14px"">
                                <p>
                                    CMSAdmin 借鉴了很多开源项目的优点，让你开发Web管理系统和移动端Api更简单，所以我也把她开源了（前端<code>CSS</code>样式主要参考<a href=""http://demo.ruoyi.vip/"" target=""");
            WriteLiteral(@"_blank"">若依</a>，在此表示感谢 :）。<br />
                                    她适用于开发 <b>网站管理后台</b>、<b>CMS</b>、<b>CRM</b>、<b>ERP</b>、<b>OA</b> 这类的系统和开发<a href=""/api/api-doc"" target=""_blank""><b>移动端Api</b></a>。<br />
                                    代码完全免费开源，易读易懂、界面简洁美观，给你的项目多一种选择与参考。
                                </p>
                                <p>当前版本：");
#nullable restore
#line 27 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Views\Home\Welcome.cshtml"
                                   Write(CMS.Util.GlobalContext.GetVersion());

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;&nbsp;<span class=\"label label-warning\">¥免费开源</span></p>\n                                <p></p>\n                                <p>-->\n");
            WriteLiteral(@"                                <!--</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>-->
            <div class=""col-sm-6"">
                <div class=""ibox float-e-margins"">
                    <div class=""ibox-title"">
                        <h5>技术选型</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                            <a class=""close-link""><i class=""fa fa-times""></i></a>
                        </div>
                    </div>
                    <div class=""ibox-content"" style=""font-size:14px"">
                        <ul>
                            <li>1. 前端： Bootstrap 3.3.7</li>
                            <li>2. 核心框架：.Net Core MVC</li>
                            <li>3. 缓存层：Memory、Redis</li>
                            <li>4. 持久层框架：Entity Framework Co");
            WriteLiteral(@"re</li>
                            <li>5. 数据库支持：SqlServer,MySql,Oracle</li>
                            <li>6. 定时任务：Quartz.Net</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <!--<div class=""row"">
            <div class=""col-sm-4"">
                <div class=""ibox float-e-margins"">
                    <div class=""ibox-title"">
                        <h5>联系信息</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                            <a class=""close-link""><i class=""fa fa-times""></i></a>
                        </div>
                    </div>
                    <div class=""ibox-content"">-->
");
            WriteLiteral("        <!--<p>\n                        <i class=\"fa fa-qq\"></i> QQ群：<s>满 428703155</s> <a href=\"https://jq.qq.com/?_wv=1027&k=MQ6OdF8v\" target=\"_blank\">851661600</a>\n                    </p>\n                </div>\n            </div>\n        </div>-->\n");
            WriteLiteral(@"
    </div>

</div>
</div>
<script>
    $(function () {

        $("".modal"").appendTo(""body""), $(""[data-toggle=popover]"").popover(), $("".collapse-link"").click(function () {
            var div_ibox = $(this).closest(""div.ibox""),
                e = $(this).find(""i""),
                i = div_ibox.find(""div.ibox-content"");
            i.slideToggle(200),
                e.toggleClass(""fa-chevron-up"").toggleClass(""fa-chevron-down""),
                div_ibox.toggleClass("""").toggleClass(""border-bottom""),
                setTimeout(function () {
                    div_ibox.resize();
                }, 50);
        }), $("".close-link"").click(function () {
            var div_ibox = $(this).closest(""div.ibox"");
            div_ibox.remove()
        });

        $('#pay-qrcode').click(function () {
            var html = $(this).html();
            ys.openDialogContent({
                content: html,
                width: '600px',
                height: '321px'
            });
        });

    });

</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
