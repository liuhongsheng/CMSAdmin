#pragma checksum "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Shared\AreaFormPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adfdc1e744f810192a094c9d3c58108dcffea8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Shared_AreaFormPartial), @"mvc.1.0.view", @"/Areas/SystemManage/Shared/AreaFormPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 2 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using CMS.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using CMS.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using CMS.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using CMS.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using CMS.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using CMS.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0adfdc1e744f810192a094c9d3c58108dcffea8e", @"/Areas/SystemManage/Shared/AreaFormPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9ebe3cfeb019585c2f076342bfd621d3c2d55d", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Shared_AreaFormPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"form-group\">\n    <label");
            BeginWriteAttribute("class", " class=\'", 35, "\'", 82, 3);
            WriteAttributeValue("", 43, "col-sm-", 43, 7, true);
#nullable restore
#line 2 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Shared\AreaFormPartial.cshtml"
WriteAttributeValue("", 50, ViewData["Label"], 50, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 68, "control-label", 69, 14, true);
            EndWriteAttribute();
            WriteLiteral(">所在区域</label>\n    <div");
            BeginWriteAttribute("class", " class=\"", 105, "\"", 140, 2);
            WriteAttributeValue("", 113, "col-sm-", 113, 7, true);
#nullable restore
#line 3 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Shared\AreaFormPartial.cshtml"
WriteAttributeValue("", 120, ViewData["Content"], 120, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <div id=\"areaId\" col=\"AreaId\"></div>\n    </div>\n</div>\n\n<script type=\"text/javascript\">\n    $(function () {\n        $(\'#areaId\').ysComboBoxTree({ url: \'");
#nullable restore
#line 10 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Shared\AreaFormPartial.cshtml"
                                       Write(Url.Content("~/SystemManage/Area/GetZtreeAreaListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', expandLevel: 0 });\n    });\n</script>");
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
