#pragma checksum "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db55f6279a917e351401fcd693cdab15c8dadbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoHabitacion_Index), @"mvc.1.0.view", @"/Views/TipoHabitacion/Index.cshtml")]
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
#line 1 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\_ViewImports.cshtml"
using Hotel_El_Dorado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\_ViewImports.cshtml"
using Hotel_El_Dorado.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db55f6279a917e351401fcd693cdab15c8dadbb", @"/Views/TipoHabitacion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bce2d0a2cbd1aa945e4f1a0cbf3149f943c74c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TipoHabitacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive imgTarifas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
  
    ViewData["Title"] = "Tarifas";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tarifasTexto\">\r\n    <h2>Tarifas</h2>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
     if (ViewBag.DescuentoTemporada != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
         foreach (TipoHabitacionModel temp in ViewBag.tipoHabitacion)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
             if (temp.oferta == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"homeTarifas\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5db55f6279a917e351401fcd693cdab15c8dadbb6236", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 486, "~/img/", 486, 6, true);
#nullable restore
#line 17 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
AddHtmlAttributeValue("", 492, temp.imagen, 492, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-8 justify-content-center\">\r\n                    <div class=\"tarifasTexto\">\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 23 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 24 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Precio: $");
#nullable restore
#line 25 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                               Write(temp.costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Porcentaje por Temporada: ");
#nullable restore
#line 26 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                                                Write(ViewBag.DescuentoTemporada);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                    </div>\r\n                    <br />\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"homeTarifas\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5db55f6279a917e351401fcd693cdab15c8dadbb10634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1273, "~/img/", 1273, 6, true);
#nullable restore
#line 35 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
AddHtmlAttributeValue("", 1279, temp.imagen, 1279, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-8 justify-content-center\">\r\n                    <div class=\"tarifasTexto\">\r\n                        <p>");
#nullable restore
#line 40 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 41 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 42 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Precio: $");
#nullable restore
#line 43 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                               Write(temp.costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Porcentaje por Temporada: ");
#nullable restore
#line 44 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                                                Write(ViewBag.DescuentoTemporada);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                        <p>Porcentaje por Oferta: ");
#nullable restore
#line 45 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                                             Write(temp.oferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                    </div>\r\n                    <br />\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
         

    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
         foreach (TipoHabitacionModel temp in ViewBag.tipoHabitacion)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
             if (temp.oferta == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"homeTarifas\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5db55f6279a917e351401fcd693cdab15c8dadbb16562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2268, "~/img/", 2268, 6, true);
#nullable restore
#line 62 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
AddHtmlAttributeValue("", 2274, temp.imagen, 2274, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-8 justify-content-center\">\r\n                    <div class=\"tarifasTexto\">\r\n                        <p>");
#nullable restore
#line 67 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 68 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 69 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Precio: $");
#nullable restore
#line 70 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                               Write(temp.costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Porcentaje por Temporada: ");
#nullable restore
#line 71 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                                                Write(ViewBag.DescuentoTemporada);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                    </div>\r\n                    <br />\r\n                </div>\r\n");
#nullable restore
#line 75 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"homeTarifas\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5db55f6279a917e351401fcd693cdab15c8dadbb20965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3055, "~/img/", 3055, 6, true);
#nullable restore
#line 80 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
AddHtmlAttributeValue("", 3061, temp.imagen, 3061, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-8 justify-content-center\">\r\n                    <div class=\"tarifasTexto\">\r\n                        <p>");
#nullable restore
#line 85 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 86 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 87 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                      Write(temp.caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Precio: $");
#nullable restore
#line 88 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                               Write(temp.costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Porcentaje por Temporada: ");
#nullable restore
#line 89 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                                                Write(ViewBag.DescuentoTemporada);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                        <p>Porcentaje por Oferta: ");
#nullable restore
#line 90 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
                                             Write(temp.oferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                    </div>\r\n                    <br />\r\n                </div>\r\n");
#nullable restore
#line 94 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\TipoHabitacion\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
