#pragma checksum "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832aec350667db67984ab3b1f06dadbc02ec042f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Secretary_Views_UserPost_Members), @"mvc.1.0.view", @"/Areas/Secretary/Views/UserPost/Members.cshtml")]
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
#line 1 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\_ViewImports.cshtml"
using EESV2.DAL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\_ViewImports.cshtml"
using EESV2.DAL.EditModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\_ViewImports.cshtml"
using EESV2.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\_ViewImports.cshtml"
using EESV2.DAL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\_ViewImports.cshtml"
using AutoMapper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832aec350667db67984ab3b1f06dadbc02ec042f", @"/Areas/Secretary/Views/UserPost/Members.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03fec586121672e71b9fbca12904617e0c672f2", @"/Areas/Secretary/_ViewImports.cshtml")]
    public class Areas_Secretary_Views_UserPost_Members : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/css/animate.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/js/wow.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
  
    var userPost = _uw.UserPostRepository.Get(up => up.ID == (int)ViewData["id"])
                                            .Select(up => new
                                            {
                                                up.Title,
                                                members=up.Users.Select(u=>new
                                                {
                                                    u.ID,
                                                    u.FirstName,
                                                    u.LastName,
                                                    u.Username,
                                                    OfficeName=u.Office.Name,
                                                    StatusTitle=u.Status.Title,
                                                    EmploymentTypeTitle=u.EmploymentType.Title,
                                                    PortalMembershipTypeTitle=u.PortalMembershipType.Title
                                                })
                                            })
                                            .SingleOrDefault();
    ViewData["page"] = "UPUSRS";
    ViewData["Title"] = "سمت";
    Layout = "Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- DataTables -->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "832aec350667db67984ab3b1f06dadbc02ec042f7668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "832aec350667db67984ab3b1f06dadbc02ec042f8783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832aec350667db67984ab3b1f06dadbc02ec042f9896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"content-wrapper\" style=\"min-height: 915.8px;\">\n    <section class=\"content-header\">\n        <h1 class=\"wow animate__animated animate__lightSpeedInRight\">\n            لیست افراد دارای سمت \"");
#nullable restore
#line 33 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                             Write(userPost.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""/Home/Index""><i class=""fas fa-home""></i> خانه</a></li>
            <li class=""active"">مدیریت سمت ها</li>
            <li class=""active"">افراد دارای سمت</li>
        </ol>
    </section>

    <section class=""content wow animate__animated animate__zoomInDown"" data-wow-delay="".3s"">
        <div class=""box"">
            <div class=""box-body table-responsive pad"">
                <table id=""DataTable1"" class=""table table-bordered table-hover data-table dataTable"">
                    <thead>
                        <tr>
                            <th>نام</th>
                            <th>نام خانوادگی</th>
                            <th>شماره پرسنلی</th>
                            <th>نام اداره</th>
                            <th>وضعیت</th>
                            <th>نوع استخدامی</th>
                            <th>نوع عضویت در پرتال</th>
                            <th></th>
                        </tr>
                    </the");
            WriteLiteral("ad>\n                    <tbody>\n");
#nullable restore
#line 59 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                         foreach (var user in userPost.members)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 62 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 63 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 64 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 65 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.OfficeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 66 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.StatusTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 67 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.EmploymentTypeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 68 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                           Write(user.PortalMembershipTypeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3344, "\"", 3383, 2);
            WriteAttributeValue("", 3351, "/Secretary/User/Edit?id=", 3351, 24, true);
#nullable restore
#line 70 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
WriteAttributeValue("", 3375, user.ID, 3375, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ویرایش</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 73 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Areas\Secretary\Views\UserPost\Members.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </section>\n</div>\n\n\n<!-- DataTables -->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832aec350667db67984ab3b1f06dadbc02ec042f15880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832aec350667db67984ab3b1f06dadbc02ec042f16918", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(function () {
        $('#DataTable1').DataTable({
            'paging': true,
            'lengthChange': true,
            'searching': true,
            'ordering': true,
            'info': true,
            'autoWidth': false,
            ""order"": [[0, 'desc']],
            'lengthMenu': [[10, 25, 50, -1], [10, 25, 50, ""همه""]],
            'language': {
                'zeroRecords': 'رکوردی برای نمایش وجود ندارد',
                'lengthMenu': 'نمایش _MENU_ رکورد در یک صفحه',
                'search': 'جستجو در تمام ستون ها : ',
                'info': 'تعداد کل رکورد ها :   _TOTAL_',
                'infoFiltered': '',
                ""infoEmpty"": '',
                ""paginate"": {
                    ""first"": ""اولین"",
                    ""last"": ""آخرین"",
                    ""next"": ""بعدی"",
                    ""previous"": ""قبلی""
                },
            }
        })
    })
</script>




");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUnitOfWork _uw { get; private set; }
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
