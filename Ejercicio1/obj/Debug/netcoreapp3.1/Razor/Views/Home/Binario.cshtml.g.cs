#pragma checksum "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "039cb00a32c9088e21170a15c92cbc44f19ada94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Binario), @"mvc.1.0.view", @"/Views/Home/Binario.cshtml")]
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
#line 1 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\_ViewImports.cshtml"
using Ejercicio1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\_ViewImports.cshtml"
using Ejercicio1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"039cb00a32c9088e21170a15c92cbc44f19ada94", @"/Views/Home/Binario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4208cf12cc68e8567e72877a21b2ffbbd3bf49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Binario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NumsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
  
    ViewData["Title"] = "Binario";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""col-xs-12 mt-xl-5"">
        <div class=""center-block align-items-center "">
            <h1 class=""display-3"">Números Desplegados</h1>
            <table class=""table mt-xl-5"" cellpadding=""5"">
                <tr>
                    <th><h4>Números Ingresados en Decimal</h4></th>
");
#nullable restore
#line 12 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
                     foreach (var item in Model.NumerosDecimales)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 14 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
                       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 15 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr class=\"mt-xl-5\">\r\n                    <th><h4>Números Ingresados en Binario</h4></th>\r\n");
#nullable restore
#line 19 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
                     foreach (var item in Model.NumerosBinarios)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 21 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
                       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "D:\Documents\_ITLA\PROGRAMACION\PROGRAMACION 3\Módulo 5\Ejercicio1\Ejercicio1\Views\Home\Binario.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NumsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
