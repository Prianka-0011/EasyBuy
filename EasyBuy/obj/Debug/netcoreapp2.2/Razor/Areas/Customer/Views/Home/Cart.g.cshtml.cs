#pragma checksum "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33b93ce5926e7c820b126dd660147e4d3249456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Cart), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Cart.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Cart))]
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
#line 1 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\_ViewImports.cshtml"
using EasyBuy;

#line default
#line hidden
#line 2 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\_ViewImports.cshtml"
using EasyBuy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33b93ce5926e7c820b126dd660147e4d3249456", @"/Areas/Customer/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c3dfa97aeb6649f7ed01f55e2b385e9bbc25911", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EasyBuy.ViewModels.CartItemVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px; border-radius:25px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DecCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    int i = 1;
      decimal totalPrice = 0;

#line default
#line hidden
            BeginContext(138, 334, true);
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card mb-5"">
                    <div class=""card-header"">
                        <span class="" text-warning font-weight-normal""><b>Cart Product </b></span>
                    </div>
                    <div class=""table-responsive"">
");
            EndContext();
#line 15 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                         if (Model != null)
                        {


#line default
#line hidden
            BeginContext(546, 840, true);
            WriteLiteral(@"                            <table class="" table border-top-0 table-bordered m-3 table-striped font-weight-normal"">
                                <thead style=""font-size:12px"">
                                    <tr>
                                        <th>#</th>

                                        <th>Category</th>
                                        <th>Product Name</th>
                                        <th>Price</th>
                                        <th>PrevPrice</th>
                                        <th>Quantity</th>

                                        <th>Image</th>

                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody style=""font-size:11px"">
");
            EndContext();
#line 35 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1491, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1578, 1, false);
#line 38 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1631, 13, false);
#line 39 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                       Write(item.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1644, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1696, 9, false);
#line 40 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1705, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1757, 10, false);
#line 41 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1767, 54, true);
            WriteLiteral("</td>\r\n                                        <td><s>");
            EndContext();
            BeginContext(1822, 14, false);
#line 42 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                          Write(item.PrevPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 55, true);
            WriteLiteral("</s></td>\r\n                                        <td>");
            EndContext();
            BeginContext(1892, 13, false);
#line 43 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                       Write(item.Quentity);

#line default
#line hidden
            EndContext();
            BeginContext(1905, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1956, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b33b93ce5926e7c820b126dd660147e4d324945612013", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1966, "~/", 1966, 2, true);
#line 44 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
AddHtmlAttributeValue("", 1968, item.Image, 1968, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(2055, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 46 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                             if (@item.Quentity == 5)
                                            {

#line default
#line hidden
            BeginContext(2226, 93, true);
            WriteLiteral("                                                <a disabled><i class=\"fas fa-plus\"></i></a>\r\n");
            EndContext();
#line 49 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2463, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(2511, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33b93ce5926e7c820b126dd660147e4d324945614667", async() => {
                BeginContext(2595, 27, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2626, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2675, 52, true);
            WriteLiteral("\r\n                                            <span>");
            EndContext();
            BeginContext(2728, 13, false);
#line 55 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                             Write(item.Quentity);

#line default
#line hidden
            EndContext();
            BeginContext(2741, 53, true);
            WriteLiteral("</span>\r\n                                            ");
            EndContext();
            BeginContext(2794, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33b93ce5926e7c820b126dd660147e4d324945617921", async() => {
                BeginContext(2878, 28, true);
                WriteLiteral("<i class=\"fas fa-minus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                                                                                   WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2910, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(2956, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33b93ce5926e7c820b126dd660147e4d324945620471", async() => {
                BeginContext(3041, 6, true);
                WriteLiteral("Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                                                                                    WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3051, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 60 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                        i++;
                                    }

#line default
#line hidden
            BeginContext(3228, 80, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
            EndContext();
#line 64 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                            foreach (var item in Model)
                            {

                                totalPrice = totalPrice + (item.Quentity * item.Price);
                            }

                        }

#line default
#line hidden
            BeginContext(3547, 157, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-5 offset-md-7\">\r\n                            ");
            EndContext();
            BeginContext(3704, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33b93ce5926e7c820b126dd660147e4d324945624075", async() => {
                BeginContext(3755, 12, true);
                WriteLiteral("Back To List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3771, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3801, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33b93ce5926e7c820b126dd660147e4d324945625567", async() => {
                BeginContext(3877, 9, true);
                WriteLiteral("Check Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3890, 68, true);
            WriteLiteral("\r\n                            <span class=\"pull-right\"><b>Total:</b>");
            EndContext();
            BeginContext(3959, 10, false);
#line 77 "C:\Users\niku\source\repos\EasyBuy\EasyBuy\Areas\Customer\Views\Home\Cart.cshtml"
                                                             Write(totalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3969, 159, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n               \r\n            </div>\r\n           \r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EasyBuy.ViewModels.CartItemVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591