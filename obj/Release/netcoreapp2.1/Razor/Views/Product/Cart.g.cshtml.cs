#pragma checksum "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Product\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbcd1cefeda6ca7f3664c5db036182e772090cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Pages.Product.Views_Product_Cart), @"mvc.1.0.view", @"/Views/Product/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Cart.cshtml", typeof(ckl.Pages.Product.Views_Product_Cart))]
namespace ckl.Pages.Product
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcd1cefeda6ca7f3664c5db036182e772090cb7", @"/Views/Product/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48165eb9a75cfa0b3a8bdff2dd76eb4140ddc3c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Product\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_ecommerceLayout1.cshtml";

#line default
#line hidden
            BeginContext(99, 2217, true);
            WriteLiteral(@"
<div class=""container"">
    <table id=""cart"" class=""table table-hover table-condensed"">
        <thead>
            <tr>
                <th style=""width:50%"">Product</th>
                <th style=""width:10%"">Price</th>
                <th style=""width:8%"">Quantity</th>
                <th style=""width:22%"" class=""text-center"">Subtotal</th>
                <th style=""width:10%""></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td data-th=""Product"">
                    <div class=""row"">
                        <div class=""col-sm-2 hidden-xs""><img src=""http://placehold.it/100x100"" alt=""..."" class=""img-responsive"" /></div>
                        <div class=""col-sm-10"">
                            <h4 class=""nomargin"">Product 1</h4>
                            <p>Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet.</p>
                        </div>
                    </div>
     ");
            WriteLiteral(@"           </td>
                <td data-th=""Price"">$1.99</td>
                <td data-th=""Quantity"">
                    <input type=""number"" class=""form-control text-center"" value=""1"">
                </td>
                <td data-th=""Subtotal"" class=""text-center"">1.99</td>
                <td class=""actions"" data-th="""">
                    <button class=""btn btn-info btn-sm""><i class=""fa fa-refresh""></i></button>
                    <button class=""btn btn-danger btn-sm""><i class=""fa fa-trash-o""></i></button>
                </td>
            </tr>
        </tbody>
        <tfoot>
            <tr class=""visible-xs"">
                <td class=""text-center""><strong>Total 1.99</strong></td>
            </tr>
            <tr>
                <td><a href=""#"" class=""btn btn-warning""><i class=""fa fa-angle-left""></i> Continue Shopping</a></td>
                <td colspan=""2"" class=""hidden-xs""></td>
                <td class=""hidden-xs text-center""><strong>Total $1.99</strong></td>
           ");
            WriteLiteral("     <td><a href=\"#\" class=\"btn btn-success btn-block\">Checkout <i class=\"fa fa-angle-right\"></i></a></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
