#pragma checksum "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e259e3f64a0d6d7d283369d9f17f524c16a29fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_News_NewsForm), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/News/NewsForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e259e3f64a0d6d7d283369d9f17f524c16a29fc", @"/Areas/OrganizationManage/Views/News/NewsForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ddc129917fe77e97a3b7703ff32389993fe2e3", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_News_NewsForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\n    <link");
                BeginWriteAttribute("href", " href=\"", 156, "\"", 221, 1);
#nullable restore
#line 6 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
WriteAttributeValue("", 163, Url.Content("~/lib/summernote/0.8.15/summernote.min.css"), 163, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\n    <script");
                BeginWriteAttribute("src", " src=\'", 268, "\'", 327, 1);
#nullable restore
#line 7 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
WriteAttributeValue("", 274, Url.Content("~/lib/summernote/0.8.15/summernote.js"), 274, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\n    <script");
                BeginWriteAttribute("src", " src=\'", 373, "\'", 447, 1);
#nullable restore
#line 8 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
WriteAttributeValue("", 379, Url.Content("~/lib/summernote/0.8.15/lang/summernote-zh-CN.min.js"), 379, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\n\n    ");
#nullable restore
#line 10 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/imageupload/1.0/css/imgup.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 11 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/imageupload/1.0/js/imgup.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 13 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.tagsinput/0.8.0/bootstrap-tagsinput.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 14 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.tagsinput/0.8.0/bootstrap-tagsinput.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<div class=\"wrapper animated fadeInRight\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e259e3f64a0d6d7d283369d9f17f524c16a29fc8138", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">标题 <font class=""red""> *</font> </label>
            <div class=""col-sm-10"">
                <input id=""newsTitle"" col=""NewsTitle"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章类别<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""newsType"" col=""NewsType""></div>
            </div>
            <label class=""col-sm-2 control-label "">发布时间<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsDate"" col=""NewsDate"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">作者<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsAuthor"" col=""NewsAuthor"" type=""text"" class=""form-control"" />
       ");
                WriteLiteral(@"     </div>
            <label class=""col-sm-2 control-label "">排序<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsSort"" col=""NewsSort"" type=""text"" class=""form-control"" />
            </div>
        </div>
        ");
#nullable restore
#line 45 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
   Write(await Html.PartialAsync("/Areas/SystemManage/Shared/AreaFormPartial.cshtml", new ViewDataDictionary(this.ViewData) { { "Label", "2" }, { "Content", "10" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章标签</label>
            <div class=""col-sm-10"">
                <input id=""newsTag"" col=""NewsTag"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">
                <span>缩略图</span><br />
                <span>(宽高比 1.5：1)</span>
            </label>
            <div class=""col-sm-10"">
                <div id=""thumbImage"" class=""img-box"">
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章内容 </label>
            <div class=""col-sm-10"">
                <div id=""newsContent"" class=""summernote""></div>
            </div>
        </div>
    ");
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
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    var id = ys.request(""id"");
    $(function () {
        laydate.render({ elem: '#newsDate', type: 'datetime', format: 'yyyy-MM-dd HH:mm' });

        $('#newsTag').tagsinput({ trimValue: true });

        $(""#newsType"").ysComboBox({
            data: top.getDataDict(""NewsType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });

        $('#newsContent').summernote({
            height: '220px',
            lang: 'zh-CN',
            dialogsInBody: true,
            callbacks: {
                onImageUpload: function (files, editor, welEditable) {
                    uploadNewsImage(files[0], editor, welEditable);
                }
            }
        });

        $(""#thumbImage"").imageUpload({ uploadImage: 'uploadThumbImage', limit: 1, context: ctx });

        getForm();

        $(""#form"").validate({
            rules: {
                newsTitle: { required: true },
                newsType_select: { req");
            WriteLiteral(@"uired: true },
                newsDate: { required: true },
                newsAuthor: { required: true },
                newsSort: { required: true }
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 114 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        obj.Data.NewsDate = ys.formatDate(obj.Data.NewsDate, ""yyyy-MM-dd HH:mm"");
                        $(""#form"").setWebControls(obj.Data);
                        $(""#newsContent"").summernote('code', obj.Data.NewsContent);
                        $(""#thumbImage"").imageUpload(""setImageUrl"", obj.Data.ThumbImage);

                        $.each(obj.Data.NewsTag.split(','), function (index,val) {
                             $('#newsTag').tagsinput('add', val);
                        });
                    }
                }
            });
        }
        else {
            ys.ajax({
                url: '");
#nullable restore
#line 132 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/GetMaxSortJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n                type: \"get\",\n                success: function (obj) {\n                    if (obj.Tag == 1) {\n                        var defaultData = {};\n                        defaultData.NewsAuthor = \"");
#nullable restore
#line 137 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                             Write(ViewBag.OperatorInfo.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n                        defaultData.NewsDate = \'");
#nullable restore
#line 138 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                           Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                        defaultData.NewsSort = obj.Data;
                        $(""#form"").setWebControls(defaultData);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            postData.NewsContent = $(""#newsContent"").summernote('code');
            postData.ThumbImage = $(""#thumbImage"").imageUpload(""getImageUrl"");
            ys.ajax({
                url: '");
#nullable restore
#line 153 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/SaveFormJson"));

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

    function uploadNewsImage(file, editor, welEditable) {
        var formdata = new FormData();
        formdata.append(""fileList"", file);
        ys.ajaxUploadFile({
            url: '");
#nullable restore
#line 174 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 174 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                                                 Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            data: formdata,\n            success: function (obj) {\n                if (obj.Tag == 1) {\n                    $(\"#newsContent\").summernote(\'insertImage\', \'");
#nullable restore
#line 178 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                            Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + obj.Data, '/');
                }
                else {
                    ys.msgError(obj.Message);
                }
            }
        })
    }

    function uploadThumbImage(file, callback) {
        var formdata = new FormData();
        formdata.append(""fileList"", file);
        ys.ajaxUploadFile({
            url: '");
#nullable restore
#line 191 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 191 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                                                 Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            data: formdata,\n            success: function (obj) {\n                if (obj.Tag == 1) {\n                    if (callback) {\n                        callback(\'");
#nullable restore
#line 196 "D:\作品\CMSAdmin\CMS.Web\CMS.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + obj.Data);\n                    }\n                }\n                else {\n                    ys.msgError(obj.Message);\n                }\n            }\n        })\n    }\n</script>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; }
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
