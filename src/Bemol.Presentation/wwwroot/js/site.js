// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$("#Cep").blur(function () {

    var cep = $(this).val().replace(/\D/g, '');

    if (cep != "") {
        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep)) {


            $("#Salvar").prop('disabled', true);

            $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                if (!("erro" in dados)) {

                    $("#Rua").val(dados.logradouro);

                }
                else {
                    LimparConsulta();
                    alert("CEP não encontrado.");
                }
            });

            $("#Salvar").prop('disabled', false);

        }
        else {
            LimparConsulta();
            alert("Formato de CEP inválido.");
        }
    }
    else {
        LimparConsulta();
    }
});

function LimparConsulta() {
    $("#Rua").val('');
}