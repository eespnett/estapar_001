#pragma checksum "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c195cd7d0648ef1f77613d01c78bdd312aaa49ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarroCreate), @"mvc.1.0.view", @"/Views/Home/CarroCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarroCreate.cshtml", typeof(AspNetCore.Views_Home_CarroCreate))]
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
#line 1 "C:\TesteEstapar\src\WebApplicationEstapar\Views\_ViewImports.cshtml"
using WebApplicationEstapar;

#line default
#line hidden
#line 2 "C:\TesteEstapar\src\WebApplicationEstapar\Views\_ViewImports.cshtml"
using WebApplicationEstapar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c195cd7d0648ef1f77613d01c78bdd312aaa49ea", @"/Views/Home/CarroCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92ec06f89912539327145ef2122384aaf211f24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarroCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarroModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
  
    ViewData["Title"] = "CarroCreate";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 24, true);
            WriteLiteral("\r\n<h2>CarroCreate</h2>\r\n");
            EndContext();
#line 8 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
 using (Html.BeginForm("CarroCreate", "Home", FormMethod.Post, new { id = "CarroCreate" }))
{

#line default
#line hidden
            BeginContext(233, 90, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputEmail1\">ID</label>\r\n        ");
            EndContext();
            BeginContext(324, 66, false);
#line 12 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
   Write(Html.TextBoxFor(model => Model.Id, new { @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(390, 111, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Marcao</label>\r\n        ");
            EndContext();
            BeginContext(502, 42, false);
#line 16 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
   Write(Html.TextBoxFor(model => Model.MarcaCarro));

#line default
#line hidden
            EndContext();
            BeginContext(544, 111, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Modelo</label>\r\n        ");
            EndContext();
            BeginContext(656, 43, false);
#line 20 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
   Write(Html.TextBoxFor(model => Model.ModeloCarro));

#line default
#line hidden
            EndContext();
            BeginContext(699, 110, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Placa</label>\r\n        ");
            EndContext();
            BeginContext(810, 42, false);
#line 24 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
   Write(Html.TextBoxFor(model => Model.PlacaCarro));

#line default
#line hidden
            EndContext();
            BeginContext(852, 81, true);
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n");
            EndContext();
#line 27 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CarroCreate.cshtml"
}

#line default
#line hidden
            BeginContext(936, 7, true);
            WriteLiteral("\r\n\r\n \r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
