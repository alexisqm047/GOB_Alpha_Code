#pragma checksum "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b89ed5fc653425d0288b2f00871deb53a87d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GOB.App.Frontend.Pages.Listas.Pages_Listas_DetallesSecretario), @"mvc.1.0.razor-page", @"/Pages/Listas/DetallesSecretario.cshtml")]
namespace GOB.App.Frontend.Pages.Listas
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
#line 1 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\_ViewImports.cshtml"
using GOB.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b89ed5fc653425d0288b2f00871deb53a87d03", @"/Pages/Listas/DetallesSecretario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4ace63975546714e9fe9719c990102cc36bf0f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_DetallesSecretario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
h1 {text-align: center;}
p {text-align: center;}
div {text-align: center;}
</style>
<style>
table, tr, th, td {
  border: 1px solid white;
  border-collapse: collapse;
}
th, td {
  background-color: #96D4D4;
}
</style>
<h1>Detalles Secretario de despacho</h1>
<table style=""width:100%""> 
    <th>Nombre</th>
    <th>Apellido</th>
    <th>Edad</th>
    <th>Identificacion</th>
    <th>Despacho</th>
    <th>Estado de salud</th>
    <tr>
        <td>");
#nullable restore
#line 29 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml"
       Write(Model.secretario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml"
       Write(Model.secretario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml"
       Write(Model.secretario.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml"
       Write(Model.secretario.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml"
       Write(Model.secretario.despacho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Listas\DetallesSecretario.cshtml"
       Write(Model.secretario.estadoSalud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>   \r\n</table>\r\n<input type=\"button\" onclick=\"history.back()\" name=\"volver atrás\" value=\"volver atrás\">");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GOB.AppFrontend.Pages.DetallesSecretarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GOB.AppFrontend.Pages.DetallesSecretarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GOB.AppFrontend.Pages.DetallesSecretarioModel>)PageContext?.ViewData;
        public GOB.AppFrontend.Pages.DetallesSecretarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591