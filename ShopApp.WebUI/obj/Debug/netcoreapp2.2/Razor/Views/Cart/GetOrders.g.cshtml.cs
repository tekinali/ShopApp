#pragma checksum "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e583d94441e2cc9011fdbf23ae524b17c120890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/GetOrders.cshtml", typeof(AspNetCore.Views_Cart_GetOrders))]
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
#line 1 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#line 2 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 3 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e583d94441e2cc9011fdbf23ae524b17c120890", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3808263aa4ceb4175e8208552b42449d8cb661cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
  
    ViewData["Title"] = "GetOrders";

#line default
#line hidden
            BeginContext(74, 32, true);
            WriteLiteral("\r\n<h1>GetOrders</h1>\r\n<hr />\r\n\r\n");
            EndContext();
#line 9 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(139, 134, true);
            WriteLiteral("    <table class=\"table table-bordered table-sm mb-3\">\r\n        <thead>\r\n            <tr>\r\n                <th colspan=\"2\">Order Id: #");
            EndContext();
            BeginContext(274, 12, false);
#line 14 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                      Write(item.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(286, 128, true);
            WriteLiteral("</th>\r\n                <th>Price</th>\r\n                <th>Quantity</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
             foreach (var item2 in item.OrderItems)
            {

#line default
#line hidden
            BeginContext(482, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(520, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e583d94441e2cc9011fdbf23ae524b17c1208905126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 530, "~/img/", 530, 6, true);
#line 23 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
AddHtmlAttributeValue("", 536, item2.ImageUrl, 536, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(566, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(594, 10, false);
#line 24 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(item2.Name);

#line default
#line hidden
            EndContext();
            BeginContext(604, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(632, 11, false);
#line 25 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(item2.Price);

#line default
#line hidden
            EndContext();
            BeginContext(643, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(671, 14, false);
#line 26 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(item2.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(685, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(726, 126, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">Customer Name:</td>\r\n                <td>");
            EndContext();
            BeginContext(853, 14, false);
#line 33 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(867, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(869, 13, false);
#line 33 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(882, 123, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Address:</td>\r\n                <td colspan=\"2\">");
            EndContext();
            BeginContext(1006, 12, false);
#line 37 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                           Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 121, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Phone:</td>\r\n                <td colspan=\"2\">");
            EndContext();
            BeginContext(1140, 10, false);
#line 41 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                           Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 60, true);
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 46 "C:\Users\ali\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
