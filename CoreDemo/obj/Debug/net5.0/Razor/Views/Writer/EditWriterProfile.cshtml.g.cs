#pragma checksum "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af73a83f832e7d0c8a9b4884351bbd2e56058053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_EditWriterProfile), @"mvc.1.0.view", @"/Views/Writer/EditWriterProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af73a83f832e7d0c8a9b4884351bbd2e56058053", @"/Views/Writer/EditWriterProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba6d76b1225ae13ab2af6aa923e23b37917f9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_EditWriterProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
  
    ViewData["Title"] = "EditWriterProfile";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
 using (Html.BeginForm("EditWriterProfile", "Writer", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Yazarın profil məlumatı</h4>\r\n                <br/>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af73a83f832e7d0c8a9b4884351bbd2e560580534758", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
               Write(Html.HiddenFor(p => p.WriterID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Ad,Soyad</label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.TextBoxFor(p => p.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Email Address</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.TextBoxFor(p => p.EmailAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Parol</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.PasswordFor(p => p.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    </div>

                    <div class=""form-group"">
                        <label>Şəkil yüklə</label>
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info"" disabled placeholder=""Şəkil seç"">
                            <span class=""input-group-append"">
                                <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Yüklə</button>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleTextarea1"">Haqqında</label>
                        ");
#nullable restore
#line 42 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"
                   Write(Html.TextAreaFor(p => p.WriterAbout, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Təsdiqlə</button>\r\n                    <button class=\"btn btn-light\">Ləğv et</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Writer\EditWriterProfile.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
