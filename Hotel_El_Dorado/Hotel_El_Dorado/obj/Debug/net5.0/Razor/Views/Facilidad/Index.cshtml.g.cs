#pragma checksum "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e365c4c2b6eace3f2f1d6c587204e7e5e994cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facilidad_Index), @"mvc.1.0.view", @"/Views/Facilidad/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e365c4c2b6eace3f2f1d6c587204e7e5e994cf", @"/Views/Facilidad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bce2d0a2cbd1aa945e4f1a0cbf3149f943c74c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Facilidad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml"
  
    ViewData["Title"] = "Facilidad";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"facilidadTexto\">\r\n        <h2>Facilidades</h2>\r\n </div>\r\n");
#nullable restore
#line 9 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml"
          
        string[,] data = (string[,]) ViewData["data"];
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        \r\n         <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml"
             for(int i = 0; i < data.GetLength(0); i++)
            {
               

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-md-3\">\r\n                 <div class=\"homeFacilidad\">\r\n                     <img class=\"img-responsive imgFacilidad\"");
            BeginWriteAttribute("src", " src=\"", 505, "\"", 522, 1);
#nullable restore
#line 20 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml"
WriteAttributeValue("", 511, data[i, 0], 511, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 523, "\"", 529, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"94\" height=\"94\">\r\n                 </div>\r\n                 <br />\r\n            </div>\r\n            <div class=\"col-md-8 justify-content-center\">\r\n                <div class=\"facilidadTexto\">\r\n                    <p>");
#nullable restore
#line 26 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml"
                  Write(data[i, 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <br />\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 31 "C:\Users\victo\OneDrive\Escritorio\U\Ingenieria\Proyecto\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Hotel_El_Dorado\Views\Facilidad\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
