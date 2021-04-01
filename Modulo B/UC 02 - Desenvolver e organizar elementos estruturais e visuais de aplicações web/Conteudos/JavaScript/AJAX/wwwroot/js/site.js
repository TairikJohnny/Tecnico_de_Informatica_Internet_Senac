// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Usando somente AJAX
/* function realizaGet()
{
    var xhr = new XMLHttpRequest();
    xhr.open('GET', '/Home/DataHora');
    xhr.onload = function() {
        if (xhr.status === 200) {
            alert("Data e hora do servidor: " + xhr.responseText);
        
            var textNode = document.createTextNode(xhr.responseText);
            var novoLi = document.createElement("li");
            novoLi.appendChild(textNode);
            document.getElementById("horarios").appendChild(novoLi); 
        }
        else {
            alert('Falha na requisição. Status: ' + xhr.status);
        }
    };
    xhr.send();
}
document.getElementById("btnAcao").onclick = realizaGet; */

// Usando jQuery

function realizaGet()
{
    $.get('/Home/DataHora', function(data){
        alert("!Data e hora do servidor: " + data);
        
        var textNode = document.createTextNode(data);
        var novoLi = document.createElement("li");
        novoLi.appendChild(textNode);
        document.getElementById("horarios").appendChild(novoLi); 
    })
    .fail(function()
    {
        alert('Falha na requisição. Status: ' + xhr.status);
    });
}
document.getElementById("btnAcao").onclick = realizaGet;

// Ajax usando jQuery
function realizaPost(e)
{
    e.preventDefault();
    var informacoes = $("#login").serialize(); //nsforma em texto de parametros post
    $.post('/Home/Login', informacoes, function(data){
        if(data == "OK")
        {
            $("#mensagem").html("Login Realizado com sucesso!");
            $("#login").hide();
        }
        else
        {
            $("#mensagem").html("Login Incorreto!");
        }
    });
}
$("#login").on("submit", realizaPost);