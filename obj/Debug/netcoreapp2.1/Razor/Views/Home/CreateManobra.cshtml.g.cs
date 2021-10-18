#pragma checksum "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7093505fc3bd309c92ab78e6e76576c45258985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateManobra), @"mvc.1.0.view", @"/Views/Home/CreateManobra.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CreateManobra.cshtml", typeof(AspNetCore.Views_Home_CreateManobra))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7093505fc3bd309c92ab78e6e76576c45258985", @"/Views/Home/CreateManobra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92ec06f89912539327145ef2122384aaf211f24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateManobra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManobraModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
  
    ViewData["Title"] = "CreateManobra";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(117, 28, true);
            WriteLiteral("\r\n<h2>CreateManobra</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
 using (Html.BeginForm("CreateManobra", "Home", FormMethod.Post, new { id = "CreateManobra" }))
{

#line default
#line hidden
            BeginContext(245, 90, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputEmail1\">ID</label>\r\n        ");
            EndContext();
            BeginContext(336, 66, false);
#line 13 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
   Write(Html.TextBoxFor(model => Model.Id, new { @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(402, 116, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Data Início</label>\r\n        ");
            EndContext();
            BeginContext(519, 47, false);
#line 17 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
   Write(Html.TextBoxFor(model => Model.DtManobraInicio));

#line default
#line hidden
            EndContext();
            BeginContext(566, 113, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Data Fim</label>\r\n        ");
            EndContext();
            BeginContext(680, 44, false);
#line 21 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
   Write(Html.TextBoxFor(model => Model.DtManobraFim));

#line default
#line hidden
            EndContext();
            BeginContext(724, 114, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Concluído</label>\r\n        ");
            EndContext();
            BeginContext(839, 42, false);
#line 25 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
   Write(Html.CheckBoxFor(model => Model.Concluido));

#line default
#line hidden
            EndContext();
            BeginContext(881, 16, true);
            WriteLiteral("\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(899, 90, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Carro</label>\r\n\r\n");
            EndContext();
#line 32 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
          
            SelectList SelectListCarros = new SelectList(Model.oListEntityCarro.ToList(), "id", "PlacaCarro", Model.oCarro.id);

            

#line default
#line hidden
            BeginContext(1145, 118, false);
#line 35 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
       Write(Html.DropDownListFor(model => Model.oCarro.id, SelectListCarros, "Selecione um item", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1292, 95, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Manobrista</label>\r\n\r\n");
            EndContext();
#line 43 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
          
            SelectList SelectListManobrista = new SelectList(Model.oListManobristaEntity.ToList(), "id", "Nome", Model.oCarro.id);

            

#line default
#line hidden
            BeginContext(1546, 127, false);
#line 46 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
       Write(Html.DropDownListFor(model => Model.oManobrista.id, SelectListManobrista, "Selecione um item", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1704, 97, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Tipo Manobra</label>\r\n\r\n");
            EndContext();
#line 55 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
          
            SelectList SelectListTipoManobra = new SelectList(Model.oListTipoManobra.ToList(), "id", "_TipoManobra", Model.oCarro.id);

            

#line default
#line hidden
            BeginContext(1964, 129, false);
#line 58 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
       Write(Html.DropDownListFor(model => Model.oTipoManobra.id, SelectListTipoManobra, "Selecione um item", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(2124, 98, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Classificação</label>\r\n\r\n");
            EndContext();
#line 67 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
          
            SelectList SelectListClassificacao = new SelectList(Model.oListClassificacaoEntity.ToList(), "id", "Descricao", Model.oCarro.id);

            

#line default
#line hidden
            BeginContext(2392, 133, false);
#line 70 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
       Write(Html.DropDownListFor(model => Model.oClassificacao.id, SelectListClassificacao, "Selecione um item", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2540, 81, true);
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n");
            EndContext();
#line 76 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\CreateManobra.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManobraModel> Html { get; private set; }
    }
}
#pragma warning restore 1591