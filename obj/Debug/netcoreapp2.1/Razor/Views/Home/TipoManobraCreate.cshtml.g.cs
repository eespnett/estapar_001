#pragma checksum "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\TipoManobraCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de8617b9055340105e4cb23cc9715c0ca1c5a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TipoManobraCreate), @"mvc.1.0.view", @"/Views/Home/TipoManobraCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TipoManobraCreate.cshtml", typeof(AspNetCore.Views_Home_TipoManobraCreate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de8617b9055340105e4cb23cc9715c0ca1c5a7a", @"/Views/Home/TipoManobraCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92ec06f89912539327145ef2122384aaf211f24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TipoManobraCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TipoManobraModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\TipoManobraCreate.cshtml"
  
    ViewData["Title"] = "TipoManobraCreate";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 32, true);
            WriteLiteral("\r\n<h2>TipoManobraCreate</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\TipoManobraCreate.cshtml"
 using (Html.BeginForm("TipoManobraCreate", "Home", FormMethod.Post, new { id = "TipoManobraCreate" }))
{


#line default
#line hidden
            BeginContext(267, 90, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputEmail1\">ID</label>\r\n        ");
            EndContext();
            BeginContext(358, 66, false);
#line 14 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\TipoManobraCreate.cshtml"
   Write(Html.TextBoxFor(model => Model.Id, new { @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(424, 114, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Descrição</label>\r\n        ");
            EndContext();
            BeginContext(539, 43, false);
#line 18 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\TipoManobraCreate.cshtml"
   Write(Html.TextBoxFor(model => Model.TipoManobra));

#line default
#line hidden
            EndContext();
            BeginContext(582, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(600, 67, true);
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n");
            EndContext();
#line 23 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\TipoManobraCreate.cshtml"
}

#line default
#line hidden
            BeginContext(670, 7, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TipoManobraModel> Html { get; private set; }
    }
}
#pragma warning restore 1591