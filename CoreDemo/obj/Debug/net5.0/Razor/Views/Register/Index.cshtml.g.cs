#pragma checksum "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d03ba520ed9d267af8ab9f6f4709fdbba275b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d03ba520ed9d267af8ab9f6f4709fdbba275b7", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba6d76b1225ae13ab2af6aa923e23b37917f9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Qeydiyyatdan Ke??</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 12 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Ad,Soyad</label>\r\n                            ");
#nullable restore
#line 18 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(p => p.WriterName, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 19 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(p => p.WriterName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Elektron ??nvan</label>\r\n                            ");
#nullable restore
#line 26 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(p => p.EmailAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(p => p.EmailAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">??ifr??</label>
                            ");
#nullable restore
#line 35 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(p => p.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(p => p.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">????kil</label>\r\n                            ");
#nullable restore
#line 42 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(p => p.WriterImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(p => p.WriterImage, "", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>


                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Qeydiyyat Ol</button>
                    <p>
                        <a href=""#"" id=""btn"">Qaydalar?? oxu,q??bul edirs??ns?? t??sdiql??!</a>
                    </p>
");
#nullable restore
#line 54 "C:\Users\Mr Orkhan\Desktop\MVCProject\CoreDemo\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<script>
    $(""#btn"").click(function () {
        swal(""????rtl??r"",""Sistem?? daxil etdiyiniz elektron ??nvan ??z??rind??n m??lumat v?? x??b??rl??ri spam ??l????s??n?? varmadan g??nd??rilm??y?? davam etdiril??c??k.??g??r bu prossesi dayand??rmaq ist??s??niz mesaj g??nd??rm??k funksiyas??n?? dayand??ra bil??rsiniz.Sizin m??lumatlar??n??z bizim bazaya ??ifr??li olaraq y??kl??nir v?? saxlan??l??r.Sizin m??lumatlar maksimum ????kild?? qorunur."");

    })
</script>


");
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
