#pragma checksum "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Shared\Components\TopPanelAdmin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5acdfa4cb960436800809df165b2c03eb1c5179c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Pages.Shared.Components.TopPanelAdmin.Views_Shared_Components_TopPanelAdmin_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopPanelAdmin/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopPanelAdmin/Default.cshtml", typeof(ckl.Pages.Shared.Components.TopPanelAdmin.Views_Shared_Components_TopPanelAdmin_Default))]
namespace ckl.Pages.Shared.Components.TopPanelAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\_ViewImports.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5acdfa4cb960436800809df165b2c03eb1c5179c", @"/Views/Shared/Components/TopPanelAdmin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48165eb9a75cfa0b3a8bdff2dd76eb4140ddc3c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopPanelAdmin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8ee4fd0b7c49fe9973f3b5dd3968a2", async() => {
                BeginContext(58, 211, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css\">\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Top Panel Admin Default</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(276, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(278, 3363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14332dd600444fab169bd6494947b6d", async() => {
                BeginContext(284, 469, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-xl-3 col-sm-6 mb-3"">
            <div class=""card  text-black-50 bg-primary o-hidden h-100"">
                <div class=""card-body"">
                    <div class=""card-body-icon"">
                        <input disabled=""disabled"" class=""blue"" id=""number"" value="""" placeholder=""0"" />
                        <i class=""fas fa-fw fa-comments""></i>
                    </div>
                    <div class=""mr-5"">");
                EndContext();
                BeginContext(754, 28, false);
#line 20 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Shared\Components\TopPanelAdmin\Default.cshtml"
                                 Write(Model.SaturnReportsRequested);

#line default
#line hidden
                EndContext();
                BeginContext(782, 2747, true);
                WriteLiteral(@" New Saturn Rquest!</div>
                </div>
                <a class=""card-footer  text-black-50 clearfix small z-1"" href=""#"">
                    <span class=""float-left"">View Details</span>
                    <span class=""float-right"">
                        <i class=""fas fa-angle-right""></i>
                    </span>
                </a>
            </div>
        </div>
        <div class=""col-xl-3 col-sm-6 mb-3"">
            <div class=""card text-black-50 bg-warning o-hidden h-100"">
                <div class=""card-body"">
                    <div class=""card-body-icon"">
                        <i class=""fas fa-fw fa-list""></i>
                    </div>
                    <div class=""mr-5"">11 New Tasks!</div>
                </div>
                <a class=""card-footer  text-black-50 clearfix small z-1"" href=""#"">
                    <span class=""float-left"">View Details</span>
                    <span class=""float-right"">
                        <i class=""fas fa-angle-righ");
                WriteLiteral(@"t""></i>
                    </span>
                </a>
            </div>
        </div>
        <div class=""col-xl-3 col-sm-6 mb-3"">
            <div class=""card text-black-50 bg-success o-hidden h-100"">
                <div class=""card-body"">
                    <div class=""card-body-icon"">
                        <i class=""fas fa-fw fa-shopping-cart""></i>
                    </div>
                    <div class=""mr-5"">123 New Orders!</div>
                </div>
                <a class=""card-footer  text-black-50 clearfix small z-1"" href=""#"">
                    <span class=""float-left"">View Details</span>
                    <span class=""float-right"">
                        <i class=""fas fa-angle-right""></i>
                    </span>
                </a>
            </div>
        </div>
        <div class=""col-xl-3 col-sm-6 mb-3"">
            <div class=""card  text-black-50 bg-danger o-hidden h-100"">
                <div class=""card-body"">
                    <div class=""ca");
                WriteLiteral(@"rd-body-icon"">
                        <i class=""fas fa-fw fa-life-ring""></i>
                    </div>
                    <div class=""mr-5"">13 New Tickets!</div>
                </div>
                <a class=""card-footer  text-black-50 clearfix small z-1"" href=""#"">
                    <span class=""float-left"">View Details</span>
                    <span class=""float-right"">
                        <i class=""fas fa-angle-right""></i>
                    </span>
                </a>
            </div>
        </div>
            <div class=""col-6"">&nbsp;</div>
            <div class=""col-6"">
                <p id=""messagesList""></p>
            </div>
        </div>
    ");
                EndContext();
                BeginContext(3529, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e481261f4554ac88e3cee5bad5d36e2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3590, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3596, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "465c031e2f5145959f93ccfc5cca3031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3632, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3641, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
