#pragma checksum "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\Shared\ProductSumary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16491fb62229d44633fa4b52bd01a07b557300ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSumary), @"mvc.1.0.view", @"/Views/Shared/ProductSumary.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\_ViewImports.cshtml"
using AppTea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\_ViewImports.cshtml"
using AppTea.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\_ViewImports.cshtml"
using AppTea.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16491fb62229d44633fa4b52bd01a07b557300ac", @"/Views/Shared/ProductSumary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469325a85aa87b1c5ae4b70dca5fae4623df2e2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSumary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>");
#nullable restore
#line 5 "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\Shared\ProductSumary.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <span class=\"badge badge-pill badge-primary\" style=\"float: right\">\r\n            <small>");
#nullable restore
#line 7 "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\Shared\ProductSumary.cshtml"
              Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        </span>\r\n    </div>\r\n    <div class=\"card-text p-1\">\r\n        ");
#nullable restore
#line 11 "C:\Users\User\source\repos\ASP\AppTea\AppTea\Views\Shared\ProductSumary.cshtml"
   Write(Model.Desciption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591