#pragma checksum "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c23716355f2e644fde7e6108427396cbe4a370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_habitacionJunior), @"mvc.1.0.view", @"/Views/Administrador/habitacionJunior.cshtml")]
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
#line 1 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\_ViewImports.cshtml"
using Hotel_El_Dorado_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\_ViewImports.cshtml"
using Hotel_El_Dorado_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c23716355f2e644fde7e6108427396cbe4a370", @"/Views/Administrador/habitacionJunior.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373aeb46c1213724a66f5c77caa546aa2e28b136", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_habitacionJunior : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "verHabitacionJunior", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
  
    ViewData["Title"] = "Administrar Habitación";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"AdministrarHabitaciónTexto\">\r\n    <h2>Administrar Habitación</h2>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 justify-content-center textoStandard\"><br />\r\n        <span class=\"textoStandard\">Junior ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c23716355f2e644fde7e6108427396cbe4a3704573", async() => {
                WriteLiteral("Ver Tipo Habitación");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span><br /><br />
        <table class=""table table-bordered table-striped table-hover tableStandard"">
            <thead>
              <tr>
                <th>Número de Habitacion</th>
                <th>Estado</th>
              </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                 foreach (HabitacionModel habitacionModel in ViewBag.ListaHabitacion)
                    {
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                       if (habitacionModel.Activa == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\r\n                            <td>");
#nullable restore
#line 24 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                           Write(habitacionModel.Numero_Habitacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1066, "\"", 1104, 1);
#nullable restore
#line 25 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
WriteAttributeValue("", 1074, habitacionModel.ID_Habitacion, 1074, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"flexCheckDefault\" checked onclick=\"activa()\"><label class=\"lbActiva\" for=\"flexCheckDefault\">Activa?</label></td>\r\n                        </tr>\r\n");
#nullable restore
#line 27 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                           Write(habitacionModel.Numero_Habitacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1509, "\"", 1547, 1);
#nullable restore
#line 32 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
WriteAttributeValue("", 1517, habitacionModel.ID_Habitacion, 1517, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"flexCheckDefault\" onclick=\"activa()\"><label class=\"lbActiva\" for=\"flexCheckDefault\">Activa?</label></td>\r\n                          </tr>\r\n");
#nullable restore
#line 34 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\habitacionJunior.cshtml"
                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n         </table>\r\n    </div>\r\n</div>");
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