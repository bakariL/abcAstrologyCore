#pragma checksum "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Shared\Components\TopNavBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6571f2104fcd218c31e7d9335536148bd3e2bc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Pages.Shared.Components.TopNavBar.Views_Shared_Components_TopNavBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopNavBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopNavBar/Default.cshtml", typeof(ckl.Pages.Shared.Components.TopNavBar.Views_Shared_Components_TopNavBar_Default))]
namespace ckl.Pages.Shared.Components.TopNavBar
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Shared\Components\TopNavBar\Default.cshtml"
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
#line 3 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Shared\Components\TopNavBar\Default.cshtml"
using ckl.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6571f2104fcd218c31e7d9335536148bd3e2bc4", @"/Views/Shared/Components/TopNavBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48165eb9a75cfa0b3a8bdff2dd76eb4140ddc3c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopNavBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_loginPartilAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Shared\Components\TopNavBar\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(209, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(238, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29c1b0a86147442682387d63a86429e9", async() => {
                BeginContext(244, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Default</title>\r\n");
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
            BeginContext(340, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(342, 3185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86bc45bdf763438b8608d800492f8939", async() => {
                BeginContext(348, 142, true);
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand navbar-dark bg-dark static-top\">\r\n        <a class=\"navbar-brand mr-1\" href=\"index.html\"></a>\r\n        ");
                EndContext();
                BeginContext(490, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1383a406c8d84902ad4eb4e00ec920f7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(526, 42, true);
                WriteLiteral("\r\n        <!-- Navbar Search -->\r\n        ");
                EndContext();
                BeginContext(568, 527, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecb04bbe5b840f5843a80fc3f3ae86b", async() => {
                    BeginContext(653, 435, true);
                    WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" class=""form-control"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button class=""btn btn-primary"" type=""button"">
                        <i class=""fas fa-search""></i>
                    </button>
                </div>
            </div>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1095, 2425, true);
                WriteLiteral(@"
        <!-- Navbar -->
        <ul class=""navbar-nav ml-auto ml-md-0"">
            <li class=""nav-item dropdown no-arrow mx-1"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-bell fa-fw""></i>
                    <span class=""badge badge-danger"">9+</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""alertsDropdown"">
                    <a class=""dropdown-item"" href=""#"">Action</a>
                    <a class=""dropdown-item"" href=""#"">Another action</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                </div>
            </li>
            <li class=""nav-item dropdown no-arrow mx-1"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""");
                WriteLiteral(@"dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-envelope fa-fw""></i>
                    <span class=""badge badge-danger"">7</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""messagesDropdown"">
                    <a class=""dropdown-item"" href=""#"">Action</a>
                    <a class=""dropdown-item"" href=""#"">Another action</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                </div>
            </li>
            <li class=""nav-item dropdown no-arrow"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-user-circle fa-fw""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
           ");
                WriteLiteral(@"         <a class=""dropdown-item"" href=""#"">Settings</a>
                    <a class=""dropdown-item"" href=""#"">Activity Log</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">Logout</a>
                </div>
            </li>
        </ul>
    </nav>
   

");
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
            BeginContext(3527, 17, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
