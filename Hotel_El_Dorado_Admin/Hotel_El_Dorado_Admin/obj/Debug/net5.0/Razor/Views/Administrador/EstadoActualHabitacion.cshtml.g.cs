#pragma checksum "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31668d3dfcc4dea46ba16d0cbb698fc3fdce5fe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_EstadoActualHabitacion), @"mvc.1.0.view", @"/Views/Administrador/EstadoActualHabitacion.cshtml")]
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
#line 1 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\_ViewImports.cshtml"
using Hotel_El_Dorado_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\_ViewImports.cshtml"
using Hotel_El_Dorado_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31668d3dfcc4dea46ba16d0cbb698fc3fdce5fe8", @"/Views/Administrador/EstadoActualHabitacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373aeb46c1213724a66f5c77caa546aa2e28b136", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Administrador_EstadoActualHabitacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
  
    ViewData["Title"] = "Estado Actual";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""sobreNosotrosTexto mb-3"">
    <h2 class=""sobreNosotrosTitulo"">Estado actual de las habitaciones</h2>
</div>
<div class=""row tabla"">
    <div class=""col-md-4 justify-content-center"">
        <div class=""container"">
            
            <table class=""table table-responsive-sm table-bordered table-hover table-condensed"" id=""tablaPDF"">
                <thead>
                    <tr>
                        <th class=""text-center""># Habitaci??n</th>
                        <th class=""text-center"">Tipo</th>
                        <th class=""text-center""># Reservaci??n</th>
                        <th class=""text-center"">Fecha Reservaci??n</th>
                        <th class=""text-center"">Fecha Entrada</th>
                        <th class=""text-center"">Fecha Salida</th>
                        <th class=""text-center"">Estado</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 26 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                     foreach (EstadoDiarioModel estado in ViewBag.ListaEstadoDiario)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                         if (estado.Estado.Equals("Ocupado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 32 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Habitacion.Numero_Habitacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 33 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Habitacion.Nombre_Tipo_Habitacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 34 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.ID_Reservacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 35 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Fecha_Reservacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 36 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Fecha_Entrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 37 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Fecha_Salida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\"><input type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 1879, "\"", 1901, 1);
#nullable restore
#line 38 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
WriteAttributeValue("", 1887, estado.Estado, 1887, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" disabled style=\"width: 75%;\"/></td>\r\n                           \r\n                            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 45 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Habitacion.Numero_Habitacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 46 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Habitacion.Nombre_Tipo_Habitacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 47 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.ID_Reservacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 48 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Fecha_Reservacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 49 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Fecha_Entrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 50 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                                                   Write(estado.Fecha_Salida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\"><input type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 2764, "\"", 2786, 1);
#nullable restore
#line 51 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
WriteAttributeValue("", 2772, estado.Estado, 2772, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" disabled style=\"width: 75%;\"/></td>\r\n                            \r\n                            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\EstadoActualHabitacion.cshtml"
                         


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>

        </div>
        <div class=""botonesReporte"">
               <button onclick=""printTabla()"" class=""btn btn-light iconos""><i class=""bi bi-printer"" style=""font-size:30px""></i></button>
          </div>
    </div>

</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
