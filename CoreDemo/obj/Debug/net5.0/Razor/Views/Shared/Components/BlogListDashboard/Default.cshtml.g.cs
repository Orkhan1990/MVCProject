#pragma checksum "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18b5c6a8ab7cc22f742e7a88a161b582275ad231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using EntitiesLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18b5c6a8ab7cc22f742e7a88a161b582275ad231", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427f0e4697a7fb2e39e838fb03b34642621d13b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Bloq</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Başlıq</th>
                                <th>Kateqoriya</th>
                                <th>Tarix</th>
                                <th>Detallar</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 19 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 916, "\"", 937, 1);
#nullable restore
#line 23 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 922, item.BlogImage, 922, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\">\r\n                                    </td>\r\n                                    <td> ");
#nullable restore
#line 25 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 27 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 29 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1408, "\"", 1445, 2);
            WriteAttributeValue("", 1415, "/Blog/BlogDetails/", 1415, 18, true);
#nullable restore
#line 30 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1433, item.BlogID, 1433, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Ətraflı</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591