#pragma checksum "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/Account/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9746f5960fe6e14c58a6b0318c7c63f38cbeec44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Error), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Error.cshtml", typeof(ckl.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Error), null)]
namespace ckl.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/_ViewImports.cshtml"
using ckl.Areas.Identity;

#line default
#line hidden
#line 3 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/_ViewImports.cshtml"
using ckl.Data;

#line default
#line hidden
#line 4 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/_ViewImports.cshtml"
using ckl.Models.ViewModels;

#line default
#line hidden
#line 2 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using ckl.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9746f5960fe6e14c58a6b0318c7c63f38cbeec44", @"/Areas/Identity/Pages/Account/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a706c7a9761596c2b1bdbe8ed227f1aa938557", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"225cb07f47415cfd5e1305d81fd848762d11dc9a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/Account/Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(62, 116, true);
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
            EndContext();
#line 10 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/Account/Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(206, 51, true);
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(258, 15, false);
#line 13 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/Account/Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(273, 17, true);
            WriteLiteral("</code>\n    </p>\n");
            EndContext();
#line 15 "/Users/bakari/Projects/ckl/abc/abcastrologyCore/Areas/Identity/Pages/Account/Error.cshtml"
}

#line default
#line hidden
            BeginContext(292, 554, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
