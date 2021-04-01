$(document).ready(function()
{
    $("#nomeCartao").on("keyup", function(){
        var valorCampo = $(this).val();
        $(this).val(valorCampo.toUpperCase());
    });
    
    $(".painel").hide();
    
    $("#abaBoleto").on("click", function(e){
        e.preventDefault();
        $("#pagBoleto").show();
        $("#pagCartao").hide();
    });
    
    $("#abaCartao").on("click", function(e){
        e.preventDefault();
        $("#pagCartao").show();
        $("#pagBoleto").hide();
    });
    $("#nroCartao").on("blur", function(e)
    {
        var valorCampo = $(this).val();
        if(valorCampo.length < 16)
        {
            $(this).css("border", "2px solid red");
        }
    });
    $("#nroCartao").on("focus", function(e)
    {
        $(this).css("border", "");
    });
});