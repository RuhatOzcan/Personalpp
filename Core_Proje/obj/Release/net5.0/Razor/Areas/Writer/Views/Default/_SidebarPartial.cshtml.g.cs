#pragma checksum "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\_SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21bbb4db9c5f8a49e875c6a9d5a40e6ef11d367"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default__SidebarPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21bbb4db9c5f8a49e875c6a9d5a40e6ef11d367", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/SendMessage/"">
                <i class=""ti-email menu-icon""></i>
                <span class=""menu-title"">Yeni Mesaj</span>

            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/ReceiverMessage/"">
                <i class=""ti-archive menu-icon""></i>
                <span class=""menu-title"">Gelen Mesajlar</span>

            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/SenderMessage/"">
                <i class=""ti-location-arrow menu-icon""></i>
                <span class=""men");
            WriteLiteral(@"u-title"">Gönderilenler</span>

            </a>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Default/Index/"">
                <i class=""ti-announcement menu-icon""></i>
                <span class=""menu-title"">Duyurular</span>
            </a>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""ti-user menu-icon""></i>
                <span class=""menu-title"">Profil</span>

            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""ti-settings menu-icon""></i>
                <span class=""menu-title"">Ayarlar</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Login/LogOut/"">
                <i class=""icon-paper menu-icon""></i>
                <span class=""menu-title"">Çıkış Yap</span>
            </a>
      ");
            WriteLiteral("  </li>\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
