#pragma checksum "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Product\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5027121438e4154d8814507b4b6c32d457511681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ckl.Pages.Product.Views_Product_Payment), @"mvc.1.0.view", @"/Views/Product/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Payment.cshtml", typeof(ckl.Pages.Product.Views_Product_Payment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5027121438e4154d8814507b4b6c32d457511681", @"/Views/Product/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48165eb9a75cfa0b3a8bdff2dd76eb4140ddc3c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\blewis\Projects\abc\ckl\ckl\Views\Product\Payment.cshtml"
  
    ViewData["Title"] = "Payment";
    Layout = "~/Views/Shared/_ecommerceLayout1.cshtml";

#line default
#line hidden
            BeginContext(102, 872, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <!-- You can make it whatever width you want. I'm making it full width
             on <= small devices and 4/12 page width on >= medium devices -->
        <div class=""col-xs-12 col-md-4"">


            <!-- CREDIT CARD FORM STARTS HERE -->
            <div class=""panel panel-default credit-card-box"">
                <div class=""panel-heading display-table"">
                    <div class=""row display-tr"">
                        <h3 class=""panel-title display-td"">Payment Details</h3>
                        <div class=""display-td"">
                            <img class=""img-responsive pull-right"" src=""http://i76.imgup.net/accepted_c22e0.png"">
                        </div>
                    </div>
                </div>
                <div class=""panel-body"">
                    ");
            EndContext();
            BeginContext(974, 3519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5b4961fc7d497f828930779ff57d73", async() => {
                BeginContext(1053, 3433, true);
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""form-group"">
                                    <label for=""cardNumber"">CARD NUMBER</label>
                                    <div class=""input-group"">
                                        <input type=""tel""
                                               class=""form-control""
                                               name=""cardNumber""
                                               placeholder=""Valid Card Number""
                                               autocomplete=""cc-number""
                                               required autofocus />
                                        <span class=""input-group-addon""><i class=""fa fa-credit-card""></i></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">");
                WriteLiteral(@"
                            <div class=""col-xs-7 col-md-7"">
                                <div class=""form-group"">
                                    <label for=""cardExpiry""><span class=""hidden-xs"">EXPIRATION</span><span class=""visible-xs-inline"">EXP</span> DATE</label>
                                    <input type=""tel""
                                           class=""form-control""
                                           name=""cardExpiry""
                                           placeholder=""MM / YY""
                                           autocomplete=""cc-exp""
                                           required />
                                </div>
                            </div>
                            <div class=""col-xs-5 col-md-5 pull-right"">
                                <div class=""form-group"">
                                    <label for=""cardCVC"">CV CODE</label>
                                    <input type=""tel""
                                        ");
                WriteLiteral(@"   class=""form-control""
                                           name=""cardCVC""
                                           placeholder=""CVC""
                                           autocomplete=""cc-csc""
                                           required />
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""form-group"">
                                    <label for=""couponCode"">COUPON CODE</label>
                                    <input type=""text"" class=""form-control"" name=""couponCode"" />
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <button class=""subscribe btn btn-success btn-lg btn-block"" type=""button"">Start ");
                WriteLiteral(@"Subscription</button>
                            </div>
                        </div>
                        <div class=""row"" style=""display:none;"">
                            <div class=""col-xs-12"">
                                <p class=""payment-errors""></p>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4493, 7543, true);
            WriteLiteral(@"
                </div>
            </div>
            <!-- CREDIT CARD FORM ENDS HERE -->


        </div>

        <div class=""col-xs-12 col-md-8"" style=""font-size: 12pt; line-height: 2em;"">
            <p>
                <h1>Features:</h1>
                <ul>
                    <li>As-you-type, input formatting</li>
                    <li>Form field validation (also as you type)</li>
                    <li>Graceful error feedback for declined card, etc</li>
                    <li>AJAX form submission w/ visual feedback</li>
                    <li>Creates a Stripe credit card token</li>
                </ul>
            </p>
            <p>Be sure to replace the dummy API key with a valid Stripe API key.</p>

            <p>
                Built upon: Bootstrap, jQuery,
                <a href=""http://jqueryvalidation.org/"">jQuery Validation Plugin</a>,
                <a href=""https://github.com/stripe/jquery.payment"">jQuery.payment library</a>,
                and <a href=");
            WriteLiteral(@"""https://stripe.com/docs/stripe.js"">Stripe.js</a>
            </p>
        </div>

    </div>
</div>
<script type=""text/javascript"">
    /*
The MIT License (MIT)

Copyright (c) 2015 William Hilton

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE L");
            WriteLiteral(@"IABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
    var $form = $('#payment-form');
    $form.find('.subscribe').on('click', payWithStripe);

    /* If you're using Stripe for payments */
    function payWithStripe(e) {
        e.preventDefault();

        /* Abort if invalid form data */
        if (!validator.form()) {
            return;
        }

        /* Visual feedback */
        $form.find('.subscribe').html('Validating <i class=""fa fa-spinner fa-pulse""></i>').prop('disabled', true);

        var PublishableKey = 'pk_test_6pRNASCoBOKtIshFeQd4XMUh'; // Replace with your API publishable key
        Stripe.setPublishableKey(PublishableKey);

        /* Create token */
        var expiry = $form.find('[name=cardExpiry]').payment('cardExpiryVal');
        var ccData = {
            number: $form.find('[name=cardNumber]').val().replace(/\s/g, ''),
 ");
            WriteLiteral(@"           cvc: $form.find('[name=cardCVC]').val(),
            exp_month: expiry.month,
            exp_year: expiry.year
        };

        Stripe.card.createToken(ccData, function stripeResponseHandler(status, response) {
            if (response.error) {
                /* Visual feedback */
                $form.find('.subscribe').html('Try again').prop('disabled', false);
                /* Show Stripe errors on the form */
                $form.find('.payment-errors').text(response.error.message);
                $form.find('.payment-errors').closest('.row').show();
            } else {
                /* Visual feedback */
                $form.find('.subscribe').html('Processing <i class=""fa fa-spinner fa-pulse""></i>');
                /* Hide Stripe errors on the form */
                $form.find('.payment-errors').closest('.row').hide();
                $form.find('.payment-errors').text("""");
                // response contains id and card, which contains additional card details            
    ");
            WriteLiteral(@"            console.log(response.id);
                console.log(response.card);
                var token = response.id;
                // AJAX - you would send 'token' to your server here.
                $.post('/account/stripe_card_token', {
                    token: token
                })
                    // Assign handlers immediately after making the request,
                    .done(function (data, textStatus, jqXHR) {
                        $form.find('.subscribe').html('Payment successful <i class=""fa fa-check""></i>');
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        $form.find('.subscribe').html('There was a problem').removeClass('success').addClass('error');
                        /* Show Stripe errors on the form */
                        $form.find('.payment-errors').text('Try refreshing the page and trying again.');
                        $form.find('.payment-errors').closest('.row').show();
                    });");
            WriteLiteral(@"
            }
        });
    }
    /* Fancy restrictive input formatting via jQuery.payment library*/
    $('input[name=cardNumber]').payment('formatCardNumber');
    $('input[name=cardCVC]').payment('formatCardCVC');
    $('input[name=cardExpiry').payment('formatCardExpiry');

    /* Form validation using Stripe client-side validation helpers */
    jQuery.validator.addMethod(""cardNumber"", function (value, element) {
        return this.optional(element) || Stripe.card.validateCardNumber(value);
    }, ""Please specify a valid credit card number."");

    jQuery.validator.addMethod(""cardExpiry"", function (value, element) {
        /* Parsing month/year uses jQuery.payment library */
        value = $.payment.cardExpiryVal(value);
        return this.optional(element) || Stripe.card.validateExpiry(value.month, value.year);
    }, ""Invalid expiration date."");

    jQuery.validator.addMethod(""cardCVC"", function (value, element) {
        return this.optional(element) || Stripe.card.validateCVC(value);
    }, ""I");
            WriteLiteral(@"nvalid CVC."");

    validator = $form.validate({
        rules: {
            cardNumber: {
                required: true,
                cardNumber: true
            },
            cardExpiry: {
                required: true,
                cardExpiry: true
            },
            cardCVC: {
                required: true,
                cardCVC: true
            }
        },
        highlight: function (element) {
            $(element).closest('.form-control').removeClass('success').addClass('error');
        },
        unhighlight: function (element) {
            $(element).closest('.form-control').removeClass('error').addClass('success');
        },
        errorPlacement: function (error, element) {
            $(element).closest('.form-group').append(error);
        }
    });

    paymentFormReady = function () {
        if ($form.find('[name=cardNumber]').hasClass(""success"") &&
            $form.find('[name=cardExpiry]').hasClass(""success"") &&
            $form.find('[name=cardCVC]').val().le");
            WriteLiteral(@"ngth > 1) {
            return true;
        } else {
            return false;
        }
    }

    $form.find('.subscribe').prop('disabled', true);
    var readyInterval = setInterval(function () {
        if (paymentFormReady()) {
            $form.find('.subscribe').prop('disabled', false);
            clearInterval(readyInterval);
        }
    }, 250);

</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
