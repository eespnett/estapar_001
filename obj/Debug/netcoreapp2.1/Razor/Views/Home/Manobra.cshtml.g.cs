#pragma checksum "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c358ab6a50ff27cc26db8dbf4149eb10c8ac1651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manobra), @"mvc.1.0.view", @"/Views/Home/Manobra.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manobra.cshtml", typeof(AspNetCore.Views_Home_Manobra))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c358ab6a50ff27cc26db8dbf4149eb10c8ac1651", @"/Views/Home/Manobra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92ec06f89912539327145ef2122384aaf211f24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manobra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
  
    ViewData["Title"] = "Manobra";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 344, true);
            WriteLiteral(@"
<h2>Manobra</h2>

<style>
    table {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    td, th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #dddddd;
    }
</style>


");
            EndContext();
#line 28 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
 if (ViewData["dataManobra"] != null)
{
    List<WebApplicationEstapar.Estapar.Entity.ManobaEnity> retorno = new List<WebApplicationEstapar.Estapar.Entity.ManobaEnity>();
    retorno = (List<WebApplicationEstapar.Estapar.Entity.ManobaEnity>)ViewData["dataManobra"];

#line default
#line hidden
            BeginContext(706, 324, true);
            WriteLiteral(@"    <table>
        <tr>
            <th>ID</th>
            <th>Carro</th>
            <th>Manobrista</th>
            <th>Tipo Manobra</th>
            <th>Data Início</th>
            <th>Data Fim</th>
            <th>Concluído</th>
            <th>Classificação</th>
            <th>Ações</th>
        </tr>
");
            EndContext();
#line 44 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
         foreach (var item in retorno)
        {

#line default
#line hidden
            BeginContext(1081, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1120, 7, false);
#line 47 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1127, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1155, 25, false);
#line 48 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.oCarro.id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1180, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1184, 33, false);
#line 48 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
                                            Write(item.oCarro.MarcaCarro.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1217, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1246, 30, false);
#line 49 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.oManobrista.id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1276, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1280, 32, false);
#line 49 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
                                                 Write(item.oManobrista.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1312, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1341, 31, false);
#line 50 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.oTipoManobra.id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1372, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1376, 41, false);
#line 50 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
                                                  Write(item.oTipoManobra._TipoManobra.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1417, 30, true);
            WriteLiteral(" </td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1448, 31, false);
#line 52 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.dtManobraInicio.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1479, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1507, 28, false);
#line 53 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.dtManobraFim.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1535, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1563, 25, false);
#line 54 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.Concluido.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1588, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1616, 33, false);
#line 55 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(item.oClassificacao.id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1649, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1653, 40, false);
#line 55 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
                                                    Write(item.oClassificacao.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1693, 54, true);
            WriteLiteral(" </td>\r\n\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(1748, 83, false);
#line 59 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(Html.ActionLink("Excluir", "ExcluirManbra", "Home", new { idManobrista = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1854, 84, false);
#line 60 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
               Write(Html.ActionLink("Alterar", "ManobraAlterar", "Home", new { idManobrista = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1938, 50, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 66 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
        }

#line default
#line hidden
            BeginContext(1999, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 69 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
}

#line default
#line hidden
            BeginContext(2018, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(2025, 83, false);
#line 73 "C:\TesteEstapar\src\WebApplicationEstapar\Views\Home\Manobra.cshtml"
Write(Html.ActionLink("Incluir", "CreateManobra", "Home", new { @class = "btn-default" }));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591