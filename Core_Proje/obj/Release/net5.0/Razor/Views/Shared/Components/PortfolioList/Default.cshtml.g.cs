#pragma checksum "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40560f247a6fac0f5df51f62dfc98c79373ca2d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
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
#line 1 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40560f247a6fac0f5df51f62dfc98c79373ca2d9", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Projelerim </h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>

");
#nullable restore
#line 12 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid-item\">\r\n                    <a href=\"https://dribbble.com\">\r\n                        <figure class=\"portfolio-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 632, "\"", 652, 1);
#nullable restore
#line 17 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 638, item.ImageUrl, 638, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
#nullable restore
#line 17 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                          Write(item.ImageUrl2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                            <figcaption>\r\n                                <h4 class=\"h5 mb-0\">");
#nullable restore
#line 19 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div>");
#nullable restore
#line 20 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </figcaption>\r\n                        </figure>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
