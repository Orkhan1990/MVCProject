#pragma checksum "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6b05bf844119ba5e8a5ba6d01a90d94b71ae01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Details), @"mvc.1.0.view", @"/Views/Message/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6b05bf844119ba5e8a5ba6d01a90d94b71ae01", @"/Views/Message/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba6d76b1225ae13ab2af6aa923e23b37917f9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mesaj</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
Write(Html.Label("Kimdən"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
Write(Html.TextBoxFor(p => p.Sender.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
Write(Html.Label("Mövzu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
Write(Html.TextBoxFor(p => p.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 14 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
Write(Html.Label("Mesaj"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Message\Details.cshtml"
Write(Html.TextAreaFor(p => p.MessageDetails,20,3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
