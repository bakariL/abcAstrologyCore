#pragma checksum "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/Admin/Indexx.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5c3b20c9fa4be60de6ecdcc0bdd20361916876b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Pages.Admin.Views_Admin_Indexx), @"mvc.1.0.view", @"/Views/Admin/Indexx.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Indexx.cshtml", typeof(ckl.Pages.Admin.Views_Admin_Indexx))]
namespace ckl.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/_ViewImports.cshtml"
using ckl.Areas.Identity;

#line default
#line hidden
#line 3 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/_ViewImports.cshtml"
using ckl.Models;

#line default
#line hidden
#line 4 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/_ViewImports.cshtml"
using ckl.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c3b20c9fa4be60de6ecdcc0bdd20361916876b", @"/Views/Admin/Indexx.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e342580aead1ea27e50e2a696d83cada47ddd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Indexx : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SaturnReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("saturnBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(143, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/Admin/Indexx.cshtml"
  
    ViewData["Title"] = "Admin";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(233, 726, true);
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-offset-8"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">
                    <a href=""#"">Dashboard</a>
                </li>
                <li class=""breadcrumb-item active"">Charts</li>
            </ol>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""card"">
                <input class=""blue"" id=""number"" value="""" placeholder=""0"" />
                <h4 class=""card-header "">Saturn Report Request</h4>
                <div class=""card-body"">
                    <h5 class=""card-title"">view, edit, and create your Saturn Reports.</h5>
                    ");
            EndContext();
            BeginContext(959, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5c3b20c9fa4be60de6ecdcc0bdd20361916876b7072", async() => {
                BeginContext(1052, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1060, 690, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-3"">
            <div class=""card"">
                <h4 class=""card-header""> Calendar </h4>
                <div class=""card-body"">
                    <h5 class=""card-title"">view, edit, and create your schedule.</h5>
                    <a href=""#"" class=""btn btn-default"">View</a>
                </div>
            </div>
        </div>
        <div class=""col-md-3"">
            <div class=""card"">
                <h4 class=""card-header""> Users </h4>
                <div class=""card-body"">
                    <h5 class=""card-title"">view, edit, and create your customer list.</h5>
                    ");
            EndContext();
            BeginContext(1750, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5c3b20c9fa4be60de6ecdcc0bdd20361916876b9501", async() => {
                BeginContext(1824, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1832, 836, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-3"">
            <div class=""card"">
                <h4 class=""card-header""> Help </h4>
                <div class=""card-body"">
                    <h5 class=""card-title"">Helpful links, tips, and FAQs.</h5>
                    <a href=""#"" class=""btn btn-default"">View</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""card"" id=""leftPanel"">
                <h4 class=""card-header""> Recent Activity </h4>
                <h6> Total Users </h6>
                <div class=""card-body"">
                   
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card"" id=""rightPanel"">
                ");
            EndContext();
            BeginContext(2669, 43, false);
#line 72 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Views/Admin/Indexx.cshtml"
           Write(await Component.InvokeAsync("CustomerData"));

#line default
#line hidden
            EndContext();
            BeginContext(2712, 610, true);
            WriteLiteral(@"
            </div>
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""card"" id=""midLeft"">

                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <hr />
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-6"">&nbsp;</div>
        <div class=""col-6"">
            <ul id=""saturnRequestList""></ul>
        </div>
    </div>
</div>
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
");
            EndContext();
            BeginContext(3322, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5c3b20c9fa4be60de6ecdcc0bdd20361916876b12979", async() => {
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
            EndContext();
            BeginContext(3383, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3384, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5c3b20c9fa4be60de6ecdcc0bdd20361916876b14139", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3420, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3439, 52, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(3493, 1, true);
            WriteLiteral("\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ckl.Data.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ckl.Data.ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591