#pragma checksum "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d435cb26282fdeadcf1066d7d42040198331675"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d435cb26282fdeadcf1066d7d42040198331675", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    string color = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Duyurular</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Tür</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if (item.Status == "yeni yazı")
                            {
                                color = "badge badge-danger";
                            }
                            if (item.Status == "yeni Kamp")
                            {
                                color = "badge badge-warning";
                            }
                            if (item.Status == "workshop")
                            {
                                color = "badge badge-info";
                            }
                            if (item.Status == "Yeni Video")
                            {
                                color = "badge badge-success";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 47 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><label");
            BeginWriteAttribute("class", " class=\"", 1890, "\"", 1904, 1);
#nullable restore
#line 50 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 1898, color, 1898, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                                     Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1971, "\"", 2022, 2);
            WriteAttributeValue("", 1978, "/Writer/Default/AnnouncementDetails/", 1978, 36, true);
#nullable restore
#line 51 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2014, item.Id, 2014, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\ruhat\Desktop\.net\PersonalWebsite\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
