#pragma checksum "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29d43fbb5b2003166ae301b6e335387a4c332672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Role_RoleForm), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Role/RoleForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29d43fbb5b2003166ae301b6e335387a4c332672", @"/Areas/SystemManage/Views/Role/RoleForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9ebe3cfeb019585c2f076342bfd621d3c2d55d", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Role_RoleForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"wrapper animated fadeInRight\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29d43fbb5b2003166ae301b6e335387a4c3326725149", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">角色名称<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""roleName"" col=""RoleName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">显示顺序</label>
            <div class=""col-sm-8"">
                <input id=""roleSort"" col=""RoleSort"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">状态</label>
            <div class=""col-sm-8"" id=""roleStatus"" col=""RoleStatus"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label "">备注</label>
            <div class=""col-sm-8"">
                <input id=""remark"" col=""Remark"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
          ");
                WriteLiteral("  <label class=\"col-sm-3 control-label \">菜单权限</label>\n            <div class=\"col-sm-8\">\n                <div id=\"menuTree\" class=\"ztree\"></div>\n            </div>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<script type=\"text/javascript\">\n    var id = ys.request(\"id\");\n    $(function () {\n        $(\"#roleStatus\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 42 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });

        loadMenuTree();

        getForm();

        $(""#form"").validate({
            rules: {
                roleName: { required: true }
            }
        });
    });

    function loadMenuTree() {
        $('#menuTree').ysTree({
            async: false,
            url: '");
#nullable restore
#line 58 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
             Write(Url.Content("~/SystemManage/Menu/GetMenuTreeListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            check: { enable: true },\n            expandLevel: 0\n        })\n    }\n\n    function getForm() {\n        if (id > 0) {\n            ys.ajax({\n                url: \'");
#nullable restore
#line 67 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                 Write(Url.Content("~/SystemManage/Role/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $(""#form"").setWebControls(obj.Data);
                        $('#menuTree').ysTree(""setCheckedNodes"", obj.Data.MenuIds);
                    }
                }
            });
        }
        else {
            ys.ajax({
                url: '");
#nullable restore
#line 79 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                 Write(Url.Content("~/SystemManage/Role/GetMaxSortJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var defaultData = {};
                        defaultData.RoleSort = obj.Data;
                        defaultData.RoleStatus = """);
#nullable restore
#line 85 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                                             Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                        $(""#form"").setWebControls(defaultData);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            postData.MenuIds = $('#menuTree').ysTree(""getCheckedNodes"");
            ys.ajax({
                url: '");
#nullable restore
#line 98 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\SystemManage\Views\Role\RoleForm.cshtml"
                 Write(Url.Content("~/SystemManage/Role/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""post"",
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }
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
