
function OpenPartialView(url) {

    $.ajax({
        url: url,
        type: "POST",
        success: function (data) {
            $("#containerPrincial").html(data);
        },
        error: function (erro) {

        }
    })
}

function MensagemErro(msg) {

}

function MensagemSucesso(msg) {

}