#pragma checksum "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\Messages\SuccessAddNewProposal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed2703cfbd260a307dd6dd93df747fbb5db04f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_SuccessAddNewProposal), @"mvc.1.0.view", @"/Views/Messages/SuccessAddNewProposal.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using EESV2.DAL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using EESV2.DAL.EditModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using EESV2.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using EESV2.DAL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using EESV2.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\_ViewImports.cshtml"
using AutoMapper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed2703cfbd260a307dd6dd93df747fbb5db04f32", @"/Views/Messages/SuccessAddNewProposal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011c076d515db2fa6309d90ca7ed75236259b1fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_SuccessAddNewProposal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\Messages\SuccessAddNewProposal.cshtml"
   
    ViewData["page"] = "MSG";
    ViewData["Title"] = "???????????? ????????";
    Layout = "Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content"">
        <div class=""alert alert-success alert-dismissible"">
            <button type=""button"" class=""close pull-left"" data-dismiss=""alert"" aria-hidden=""true"">??</button>
            <h4><i class=""icon fa fa-check""></i> ????????</h4>
            ?????????????? ?????? ???? ???????????? ?????? ???? ???? ???????????? ?????? : &nbsp;&nbsp;&nbsp;");
#nullable restore
#line 11 "F:\IMS PROJECTS\1401.09.06\EESV4-main\EESV2\Views\Messages\SuccessAddNewProposal.cshtml"
                                                                       Write((string)ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </section>\n    <!-- /.content -->\n</div>");
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
