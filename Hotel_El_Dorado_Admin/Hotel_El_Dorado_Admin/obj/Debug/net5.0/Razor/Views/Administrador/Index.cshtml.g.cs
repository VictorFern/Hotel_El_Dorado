#pragma checksum "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa61b97b1ad084f7c6613b0bf3c39cddcfe627f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa61b97b1ad084f7c6613b0bf3c39cddcfe627f", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373aeb46c1213724a66f5c77caa546aa2e28b136", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\Index.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Valor desde Session: ");
#nullable restore
#line 5 "D:\Usuarios\Faigda\Documentos\Informática\Ingeniería\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado_Admin\Hotel_El_Dorado_Admin\Views\Administrador\Index.cshtml"
                    Write(ViewBag.Session);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
