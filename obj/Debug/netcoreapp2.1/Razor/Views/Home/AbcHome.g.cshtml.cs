#pragma checksum "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db47698cdc688bbc086d650e38410c1a76ff027c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Pages.Home.Views_Home_AbcHome), @"mvc.1.0.view", @"/Views/Home/AbcHome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AbcHome.cshtml", typeof(ckl.Pages.Home.Views_Home_AbcHome))]
namespace ckl.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\_ViewImports.cshtml"
using ckl.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\_ViewImports.cshtml"
using ckl.Models;

#line default
#line hidden
#line 4 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\_ViewImports.cshtml"
using ckl.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db47698cdc688bbc086d650e38410c1a76ff027c", @"/Views/Home/AbcHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48165eb9a75cfa0b3a8bdff2dd76eb4140ddc3c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AbcHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaturnReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/videos/saturn-rising.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
  
    ViewData["Title"] = "index";
    Layout = "~/Views/Shared/_homeLayout.cshtml";

#line default
#line hidden
            BeginContext(151, 223, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row \">\r\n        <header>\r\n            <div class=\"overlay\"></div>\r\n            <video playsinline=\"playsinline\" autoplay=\"autoplay\" muted=\"muted\" loop=\"loop\">\r\n                ");
            EndContext();
            BeginContext(374, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8745eb62e2ac4cca9d463382e2282c0e", async() => {
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
            EndContext();
            BeginContext(432, 422, true);
            WriteLiteral(@"
            </video>
            <div class=""container h-100"">
                <div class=""d-flex text-center h-100"">
                    <div class=""my-auto w-100 text-white"">
                        <h2 class=""display-3 topTitle"">Character is Destiny</h2>
                    </div>
                </div>
            </div>
        </header>
    </div>
    <section id=""saturnReport"" class=""my-5"">
        ");
            EndContext();
            BeginContext(855, 47, false);
#line 24 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("HomeSaturnReport"));

#line default
#line hidden
            EndContext();
            BeginContext(902, 74, true);
            WriteLiteral("\r\n    </section>\r\n    <section id=\"learningCenter\" class=\"my-5\">\r\n        ");
            EndContext();
            BeginContext(977, 45, false);
#line 27 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("LearningCenter"));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 75, true);
            WriteLiteral("\r\n    </section>\r\n    <section id=\"newsletterEmail\" class=\"my-5\">\r\n        ");
            EndContext();
            BeginContext(1098, 46, false);
#line 30 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("NewsLetterEmail"));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 69, true);
            WriteLiteral("\r\n    </section>\r\n    <section id=\"whySaturn\" class=\"my-5\">\r\n        ");
            EndContext();
            BeginContext(1214, 40, false);
#line 33 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("WhySaturn"));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 70, true);
            WriteLiteral("\r\n    </section>\r\n    <section id=\"howItWorks\" class=\"my-5\">\r\n        ");
            EndContext();
            BeginContext(1325, 41, false);
#line 36 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("HowItWorks"));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 72, true);
            WriteLiteral("\r\n    </section>\r\n    <!-- Plans -->\r\n    <section id=\"plans\">\r\n        ");
            EndContext();
            BeginContext(1439, 36, false);
#line 40 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("Plans"));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 54, true);
            WriteLiteral("\r\n    </section>\r\n    <section id=\"mission\">\r\n        ");
            EndContext();
            BeginContext(1530, 38, false);
#line 43 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Home\AbcHome.cshtml"
   Write(await Component.InvokeAsync("Mission"));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 30, true);
            WriteLiteral("\r\n    </section>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1616, 56, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1675, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaturnReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
