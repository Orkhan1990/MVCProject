#pragma checksum "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b359cb2feef2f7e954896497dd76dee956d5ff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#nullable restore
#line 4 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models.Writer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b359cb2feef2f7e954896497dd76dee956d5ff3", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba6d76b1225ae13ab2af6aa923e23b37917f9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blogu Düzəltmək</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("BlogId"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                         ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(p => p.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                               ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(p => p.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                       ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Sekli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                             ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(p => p.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                       ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kateqoriyası"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                    ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(p => p.CategoryID,(List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                                                              ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Məzmunu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                               ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(p => p.BlogContent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                         ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Düzəlt</button>\r\n");
#nullable restore
#line 27 "C:\Users\Mr Orkhan\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
