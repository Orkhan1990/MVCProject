#pragma checksum "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ac055a91beb89b4212c908c70dda9d7d67ec3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterByBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterByBlog/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ac055a91beb89b4212c908c70dda9d7d67ec3f", @"/Views/Shared/Components/WriterByBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427f0e4697a7fb2e39e838fb03b34642621d13b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterByBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h4>Top stories of the week</h4>\r\n");
#nullable restore
#line 4 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Yeni məlumatlar yoxdur</p>\r\n");
#nullable restore
#line 7 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-grids row mb-3\">\r\n                <div class=\"col-md-5 blog-grid-left\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 365, "\"", 402, 2);
            WriteAttributeValue("", 372, "/Blog/BlogDetails/", 372, 18, true);
#nullable restore
#line 16 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
WriteAttributeValue("", 390, item.BlogID, 390, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 434, "\"", 455, 1);
#nullable restore
#line 17 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
WriteAttributeValue("", 440, item.BlogImage, 440, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 474, "\"", 480, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n                <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                    <h5>\r\n                        <a href=\"single.html\">");
#nullable restore
#line 23 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </h5>\r\n                    <div class=\"sub-meta\">\r\n                        <span>\r\n                            <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 27 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
                                                    Write(item.BlogCreateDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterByBlog\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
