#pragma checksum "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929a4b6dcc44467430cd2d4872d96fc72381bc64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Produtos), @"mvc.1.0.view", @"/Views/Produto/Produtos.cshtml")]
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
#line 1 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\_ViewImports.cshtml"
using Atividade04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\_ViewImports.cshtml"
using Atividade04.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929a4b6dcc44467430cd2d4872d96fc72381bc64", @"/Views/Produto/Produtos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e52704b92e05d86a94274ffe0bdd44e187b693", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Produtos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
  
    ViewData["Title"] = "Produto";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Produtos cadastrados</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"item\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
         foreach (Produto p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <style>\r\n                div.box {\r\n                    display: inline-block;\r\n                    width: 300px;\r\n                }\r\n            </style>\r\n");
            WriteLiteral("            <div class=\"box\">\r\n                <img src=\"../img/roupa.jpg\" width=\"300\" height=\"400\" />\r\n            </div>\r\n");
            WriteLiteral("            <h6>ID: ");
#nullable restore
#line 26 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
               Write(p.IdProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Nome: ");
#nullable restore
#line 26 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                                    Write(p.NomeProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p>Marca: ");
#nullable restore
#line 27 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                 Write(p.MarcaProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>Cor: ");
#nullable restore
#line 28 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                    Write(p.CorProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>Tamanho: ");
#nullable restore
#line 29 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                        Write(p.TamanhoProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>Quantidade estoque: ");
#nullable restore
#line 30 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                                   Write(p.QuantidadeEstoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>Preço: R$ ");
#nullable restore
#line 31 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                         Write(p.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>Data de cadastro: ");
#nullable restore
#line 32 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                                 Write(p.DataCadastro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br><i>Usuário: ");
#nullable restore
#line 33 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
                           Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </p>\r\n");
#nullable restore
#line 35 "C:\Users\tairi\Desktop\senac\Tecnico_de_Informatica_Internet_Senac\Modulo A\PROJETO INTEGRADOR\Atividade 04\Atividade04\Views\Produto\Produtos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
</main>

<style>
    .container {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
        align-content: stretch;
        align-items: center;
    }
    .item{
        width: 50%;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591