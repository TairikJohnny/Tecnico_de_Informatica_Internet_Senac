#pragma checksum "C:\Users\tairi\Desktop\a\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9cf4727e9ce1de1fb0836be86ad2d8e8d307efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tairi\Desktop\a\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\_ViewImports.cshtml"
using Atividade04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tairi\Desktop\a\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\_ViewImports.cshtml"
using Atividade04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cf4727e9ce1de1fb0836be86ad2d8e8d307efd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e52704b92e05d86a94274ffe0bdd44e187b693", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tairi\Desktop\a\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css"" rel=""stylesheet""
    integrity=""sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0"" crossorigin=""anonymous"">

<img src=""img/banner.jpg"" class=""img-fluid"" alt=""Banner"" max-width: 100% height: auto>

<div id=""nome-loja"" class=""text-center"">
    <h1 class=""display-4"">NujuStore</h1>
</div>

<br>
<br>
<br>
<br>
<div id=""frase"">
    <div style=""text-align:left"">
        <h3>Somos uma loja de roupas femininas</h3>
        <h3>Venha nos conhecer!</h3>
    </div>
    <div>
        <img src=""img/feminino.jpg"" alt=""Moda Feminina"" width=400 height=458>
    </div>
</div>
<br>
<br>
<br>
<br>
<div id=""contato"" style=""text-align:right"">
    <p>Aberto de segunda-feira a sexta-feira das 09:00h até 18:00h</p>
    <p>Sabado das 09:00h até 12:00h</p>
    <p>Endereço: Avenida Fulano de Tal, 200</p>
    <p>Telefone para contato: (12)999999999</p>
    <p>E-mail para contato: najustore@email.com</");
            WriteLiteral("p>\r\n</div>\r\n\r\n<style>\r\n    #contato {\r\n        font-size: 15px;\r\n    }\r\n\r\n    #nome-loja {\r\n        margin-top: 30px;\r\n    }\r\n\r\n    #frase{\r\n        display: flex;\r\n        justify-content: space-around;\r\n    }\r\n</style>");
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
