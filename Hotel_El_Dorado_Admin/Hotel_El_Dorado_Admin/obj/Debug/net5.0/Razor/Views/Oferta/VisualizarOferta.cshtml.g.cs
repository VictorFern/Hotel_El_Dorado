#pragma checksum "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a79aa0f6cc5212db92495262d507f3f2c6a6eae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oferta_VisualizarOferta), @"mvc.1.0.view", @"/Views/Oferta/VisualizarOferta.cshtml")]
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
#line 1 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\_ViewImports.cshtml"
using Hotel_El_Dorado_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\_ViewImports.cshtml"
using Hotel_El_Dorado_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a79aa0f6cc5212db92495262d507f3f2c6a6eae", @"/Views/Oferta/VisualizarOferta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373aeb46c1213724a66f5c77caa546aa2e28b136", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Oferta_VisualizarOferta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hotel_El_Dorado_Admin.Models.OfertaModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
  
    ViewData["Title"] = "VisualizarOferta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Visualizar Oferta</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayNameFor(model => model.ID_Oferta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayNameFor(model => model.Oferta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha_Inicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha_Fin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo_Habitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID_Oferta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayFor(modelItem => item.Oferta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayFor(modelItem => item.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha_Inicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha_Fin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo_Habitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.ActionLink("Edit", "EditarOferta", new { item.ID_Oferta, item.Oferta, item.Imagen, item.Fecha_Inicio, item.Fecha_Fin, item.Tipo_Habitacion }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
           Write(Html.ActionLink("Delete", "EliminarOferta", new { item.ID_Oferta, item.Oferta, item.Imagen, item.Fecha_Inicio, item.Fecha_Fin, item.Tipo_Habitacion }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Oferta\VisualizarOferta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hotel_El_Dorado_Admin.Models.OfertaModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
