#pragma checksum "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a036deed9cb85ef1cda60adf4bfba215177ca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_User_UserDetail), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/User/UserDetail.cshtml")]
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
#line 3 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using CMS.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using CMS.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using CMS.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using CMS.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using CMS.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using CMS.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a036deed9cb85ef1cda60adf4bfba215177ca0", @"/Areas/OrganizationManage/Views/User/UserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ddc129917fe77e97a3b7703ff32389993fe2e3", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_User_UserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row animated fadeInRight"">
        <div class=""col-sm-6"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>个人信息</h5>
                    <div class=""ibox-tools"">

                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""profile.html#"">
                            <i class=""fa fa-edit""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li><a href=""javascript:showChangeUserForm()"">修改信息</a></li>
                            <li><a href=""javascript:showChangePasswordForm()"">修改密码</a></li>
                            <li><a href=""javascript:showUserAvatarForm()"">修改头像</a></li>
                        </ul>

                    </div>
                </div>
                <div class=""contact-box"">
                    <div class=""col-sm-4"">
                        <div>
                            <img i");
            WriteLiteral("d=\"portrait\" alt=\"用户头像\" style=\"margin:0 auto;\" class=\"img-circle m-t-xs img-responsive\">\n                            <div class=\"m-t-xs font-bold text-center\"><span>");
#nullable restore
#line 28 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                                                                       Write(ViewBag.Ip);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                        </div>
                    </div>
                    <div id=""userInfo"" class=""col-sm-8"">
                        <h3><strong><span col=""UserName""></span></strong></h3>
                        <p><i class=""fa fa-user""></i> <span col=""RealName""></span> / <span id=""roleName""></span>
                        <p><i class=""fa fa-phone""></i> <span col=""Mobile""></span></p>
                        <p><i class=""fa fa-group""></i> <span id=""departmentName""></span> / <span id=""positionName""></span></p>
                        <p><i class=""fa fa-transgender""></i> 性别：<span col=""Gender""></span></p>
                        <p><i class=""fa fa-envelope-o""></i> <span col=""Email""></span></p>
                        <p><i class=""fa fa-calendar""></i> <span col=""Birthday""></span></p>
                    </div>
                    <div class=""clearfix""></div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    var id = ys.request(""id"");");
            WriteLiteral("\n    $(function () {\n        getForm();\n    });\n\n    function getForm() {\n        if (id > 0) {\n            ys.ajax({\n                url: \'");
#nullable restore
#line 56 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'?id=\' + id,\n                type: \"get\",\n                success: function (obj) {\n                    if (obj.Tag == 1) {\n                        var result = obj.Data;\n                        result.Gender = ys.getValueByKey(");
#nullable restore
#line 61 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                                                    Write(Html.Raw(typeof(GenderTypeEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@", result.Gender);
                        $(""#userInfo"").setWebControls(result);

                        if (ys.isNullOrEmpty(result.Portrait)) {
                            result.Portrait = ctx + 'image/portrait.png';
                        }
                        else {
                            result.Portrait = '");
#nullable restore
#line 68 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                                          Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + result.Portrait;
                        }
                        $(""#portrait"").attr(""src"", result.Portrait);

                        getDepartmentName(result.DepartmentId);
                        getRoleName(result.RoleIds);
                        getPositionName(result.PositionIds);
                    }
                }
            });
        }
    }

    function getRoleName(roleIds) {
        if (!ys.isNullOrEmpty(roleIds)) {
            ys.ajax({
                url: '");
#nullable restore
#line 84 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/SystemManage/Role/GetRoleName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?RoleIds=' + roleIds,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $(""#roleName"").html(obj.Data);
                    }
                }
            });
        }
    }

    function getPositionName(positionIds) {
        if (!ys.isNullOrEmpty(positionIds)) {
            ys.ajax({
                url: '");
#nullable restore
#line 98 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/Position/GetPositionName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?PositionIds=' + positionIds,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $(""#positionName"").html(obj.Data);
                    }
                }
            });
        }
    }

    function getDepartmentName(id) {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 112 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/Department/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        $(""#departmentName"").html(obj.Data.DepartmentName);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            ys.ajax({
                url: '");
#nullable restore
#line 127 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/SaveFormJson"));

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

    function showChangePasswordForm() {
        ys.openDialog({
            title: ""修改密码"",
            content: '");
#nullable restore
#line 147 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/ChangePassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function showChangeUserForm() {
        ys.openDialog({
            title: ""修改信息"",
            content: '");
#nullable restore
#line 158 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/ChangeUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function showUserAvatarForm() {
        ys.openDialog({
            title: ""修改头像"",
            content: '");
#nullable restore
#line 169 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\User\UserDetail.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/UserPortrait"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'?id=\' + id,\n            callback: function (index, layero) {\n                var iframeWin = window[layero.find(\'iframe\')[0][\'name\']];\n                iframeWin.saveForm(index);\n            }\n        });\n    }\n</script>\n");
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
