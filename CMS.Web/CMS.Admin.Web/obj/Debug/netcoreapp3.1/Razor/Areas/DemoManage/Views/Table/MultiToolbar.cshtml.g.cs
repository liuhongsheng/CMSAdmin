#pragma checksum "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\Views\Table\MultiToolbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3001055f2299159538bc24c86c905cf17d2629d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Table_MultiToolbar), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Table/MultiToolbar.cshtml")]
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
#line 3 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using CMS.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using CMS.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using CMS.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using CMS.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using CMS.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3001055f2299159538bc24c86c905cf17d2629d1", @"/Areas/DemoManage/Views/Table/MultiToolbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428b7431c84a7b800ba9697f01412574b18f8671", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Table_MultiToolbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\Views\Table\MultiToolbar.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-div"">
    <div>
        <div class=""btn-group-sm toolbar"" id=""toolbar1"">
            <a id=""btnAdd"" class=""btn btn-success""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary disabled""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger disabled""><i class=""fa fa-remove""></i> 删除</a>
        </div>
        <div class=""col-sm-12 select-table table-bordered"">
            <table id=""gridTable1"" data-mobile-responsive=""true""></table>
        </div>
    </div>

    <div>
        <div class=""btn-group-sm toolbar"" id=""toolbar2"">
            <a id=""btnImport"" class=""btn btn-success""><i class=""fa fa-upload""></i> 导入</a>
            <a id=""btnExport"" class=""btn btn-primary disabled""><i class=""fa fa-download""></i> 导出</a>
        </div>
        <div class=""col-sm-12 select-table table-bordered"">
            <table id=""gridTable2"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
 ");
            WriteLiteral("   $(function () {\n        initGrid();\n    });\n\n    function initGrid() {\n        var queryUrl = \'");
#nullable restore
#line 34 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\DemoManage\Views\Table\MultiToolbar.cshtml"
                   Write(Url.Content("~/DemoManage/Table/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable1').ysTable({
            url: queryUrl,
            toolbar: '#toolbar1',
            pageSize: 3,
            columns: [
                [
                    { checkbox: true },
                    { field: 'Id', title: '用户ID' },
                    { field: 'RealName', title: '用户姓名' },
                    { field: 'Mobile', title: '用户手机' },
                    { field: 'Email', title: '邮箱' },
                    {
                        title: '操作',
                        align: 'center',
                        formatter: function (value, row, index) {
                            var actions = [];
                            actions.push('<a class=""btn btn-success btn-xs"" href=""#""><i class=""fa fa-edit""></i>编辑</a> ');
                            actions.push('<a class=""btn btn-danger btn-xs"" href=""#""><i class=""fa fa-remove""></i>删除</a>');
                            return actions.join('');
                        }
                    }
                ]
            ],
          ");
            WriteLiteral(@"  queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });

        $('#gridTable2').ysTable({
            url: queryUrl,
            toolbar: '#toolbar2',
            pageSize: 5,
            columns: [
                [
                    { checkbox: true },
                    { field: 'Id', title: '用户ID' },
                    { field: 'RealName', title: '用户姓名' },
                    { field: 'Mobile', title: '用户手机' },
                    { field: 'Email', title: '邮箱' },
                    {
                        title: '操作',
                        align: 'center',
                        formatter: function (value, row, index) {
                            var actions = [];
                            actions.push('<a class=""btn btn-success btn-xs"" href=""#""><i class=""fa fa-edit""></i>编辑</a> ');
          ");
            WriteLiteral(@"                  actions.push('<a class=""btn btn-danger btn-xs"" href=""#""><i class=""fa fa-remove""></i>删除</a>');
                            return actions.join('');
                        }
                    }
                ]
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
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
