#pragma checksum "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a9affbfaacf3db8e8cda3f9f2167da6b9b76e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacote_Pacotes), @"mvc.1.0.view", @"/Views/Pacote/Pacotes.cshtml")]
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
#line 1 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\_ViewImports.cshtml"
using ExemploCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\_ViewImports.cshtml"
using ExemploCRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a9affbfaacf3db8e8cda3f9f2167da6b9b76e0", @"/Views/Pacote/Pacotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bccc5751ed720b49de067d6c07925191f1f5ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacote_Pacotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
  
    ViewData["Title"] = "Pacote";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Pacotes </h3>\r\n\r\n<h5>venha conferir as nossas promoções!</h5>\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
     foreach (Pacote p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <style>\r\n            div.box {\r\n                display: inline-block;\r\n                width: 300px;\r\n            }\r\n        </style>\r\n");
            WriteLiteral("        <div class=\"box\">\r\n            <img src=\"../img/card-default.jpg\" width=\"300\" height=\"300\"/>\r\n        </div>\r\n");
            WriteLiteral("        <h6>");
#nullable restore
#line 27 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
       Write(p.NomePacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p>Saindo de ");
#nullable restore
#line 28 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
                Write(p.OrigemPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>Saída: ");
#nullable restore
#line 28 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
                                           Write(p.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>Retorno: ");
#nullable restore
#line 28 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
                                                                Write(p.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><i>Usuário: ");
#nullable restore
#line 28 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
                                                                                          Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n        </p>\r\n");
#nullable restore
#line 30 "C:\Users\Tairik Johnny\Desktop\ExemploCRUD\Views\Pacote\Pacotes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacote>> Html { get; private set; }
    }
}
#pragma warning restore 1591