#pragma checksum "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c03b93e1c43b84edaa44b756553fc58ff1386afa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\_ViewImports.cshtml"
using EntitiesLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models.Writer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03b93e1c43b84edaa44b756553fc58ff1386afa", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba6d76b1225ae13ab2af6aa923e23b37917f9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yaz??????n??n yazarlar??</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Ba??l??????</th>
        <th>Tarixi</th>
        <th>Kateqorya</th>
        <th>Status</th>
        <th>Sil</th>
        <th>Yenil??</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogCreateDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 692, "\"", 728, 2);
            WriteAttributeValue("", 699, "/Blog/DeleteBlog/", 699, 17, true);
#nullable restore
#line 26 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 716, item.BlogID, 716, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 785, "\"", 819, 2);
            WriteAttributeValue("", 792, "/Blog/EditBlog/", 792, 15, true);
#nullable restore
#line 27 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 807, item.BlogID, 807, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">D??z??lt</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Blog/AddBlog\" class=\"btn btn-primary\">Yeni Blog Yarat</a>\r\n\r\n");
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
