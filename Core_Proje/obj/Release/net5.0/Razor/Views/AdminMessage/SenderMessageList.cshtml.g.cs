#pragma checksum "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a36610c7828cf350c451b03e9149f79b9ce7b9ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_SenderMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/SenderMessageList.cshtml")]
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
#line 1 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a36610c7828cf350c451b03e9149f79b9ce7b9ef", @"/Views/AdminMessage/SenderMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_SenderMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
  
    ViewData["Title"] = "SenderMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar-Admin Gönderilen Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Alıcı</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Mesajı Gör</th>
                            <th>Sil</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.Receiver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1230, "\"", 1292, 2);
            WriteAttributeValue("", 1237, "/AdminMessage/AdminMessageDetails/", 1237, 34, true);
#nullable restore
#line 36 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
WriteAttributeValue("", 1271, item.WriterMessageID, 1271, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Detaylar</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1383, "\"", 1444, 2);
            WriteAttributeValue("", 1390, "/AdminMessage/AdminMessageDelete/", 1390, 33, true);
#nullable restore
#line 37 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
WriteAttributeValue("", 1423, item.WriterMessageID, 1423, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Views\AdminMessage\SenderMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591