#pragma checksum "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c303309daa8d7fc7baf60063e3ba969d3efd88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c303309daa8d7fc7baf60063e3ba969d3efd88", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba6d76b1225ae13ab2af6aa923e23b37917f9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Contact/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">

    <h3 class=""tittle"">Biziml?? ??laq??</h3>
    <p class=""sub text-center"">Bizim sizin fikirl??ri ??yr??nm??k xo??dur!</p>
    <div class=""contact-map inner-sec"">

        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d100949.24429313939!2d-122.44206553967531!3d37.75102885910819!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x80859a6d00690021%3A0x4a501367f076adff!2sSan+Francisco%2C+CA%2C+USA!5e0!3m2!1sen!2sin!4v1472190196783""
                class=""map"" style=""border:0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 644, "\"", 662, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
    </div>
    <div class=""ad-inf-sec bg-light"">
        <div class=""container"">
            <div class=""address row"">

                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""far fa-map""></i>
                        </div>
                        <div class=""col-md-8 address-right text-left"">
                            <h6>??nvan</h6>
                            <p>
                                Bak??, Az??rbaycan

                            </p>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""far fa-envelope""></i>
                        </div>
                        <div ");
            WriteLiteral(@"class=""col-md-8 address-right text-left"">
                            <h6>Elektron ??nvan</h6>
                            <p>
                                Elektron ??nvan :
                                <a href=""mailto:orkhan.talibli@gmail.com""> orkhan.talibli@gmail.com</a>

                            </p>
                        </div>

                    </div>
                </div>
                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""fas fa-mobile-alt""></i>
                        </div>
                        <div class=""col-md-8 address-right text-left"">
                            <h6>Telefon</h6>
                            <p>+994 70 840 73 49</p>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        ");
            WriteLiteral("<div class=\"contact_grid_right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c303309daa8d7fc7baf60063e3ba969d3efd887420", async() => {
                WriteLiteral(@"
                <div class=""row contact_left_grid"">
                    <div class=""col-md-6 con-left"">
                        <div class=""form-group"">
                            <label for=""validationCustom01 my-2"">Ad,Soyad</label>
                            <input class=""form-control"" type=""text"" name=""ContactUserName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3132, "\"", 3146, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3147, "\"", 3158, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleFormControlInput1"">Elektron ??nvan</label>
                            <input class=""form-control"" type=""email"" name=""ContactMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3421, "\"", 3435, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3436, "\"", 3447, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"validationCustom03 my-2\">M??vzu</label>\r\n                            <input class=\"form-control\" type=\"text\" name=\"ContactSubject\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3702, "\"", 3716, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3717, "\"", 3728, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-md-6 con-right"">
                        <div class=""form-group"">
                            <label for=""textarea"">Mesaj</label>
                            <textarea id=""textarea"" name=""ContactMessage""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4034, "\"", 4048, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                        </div>\r\n                        <input class=\"form-control\" type=\"submit\" value=\"T??sdiql??\">\r\n\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
