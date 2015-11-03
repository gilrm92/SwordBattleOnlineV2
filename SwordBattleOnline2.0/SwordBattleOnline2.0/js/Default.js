var user = {};

$(document).ready(function () {
    $('#btnCadastrar').click(function () {
        getUserForm();
        signUp();
    });
});

function getUserForm() {
    user.Nome = $('#txtNome').val();
    user.Email = $('#txtEmail').val();
    user.Senha = $('#txtSenha').val();
}

function signUp() {
    if (isUserValid()) {
        $.ajax({
            url: "/asmx/Login.asmx/CreateUser",
            type: 'post',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify({ userJSON: JSON.stringify(user) }),
            dataType: 'JSON',
            success: function (data) {
                alert("Parabéns " + user.Nome + "! Você agora só precisa entrar no e-mail cadastrado e confirmar seu cadastro! :D");
            },
            error: function (error) {
                console.log(error);
            }
        });
    }
}

function isUserValid() {
    if (user.Nome == "") {
        alert("Digite o nome.")
        return false;
    }
    
    if (user.Email == ""){
        alert("Digite o e-mail.");
        return false;
    }

    if (user.Email != $('#txtRepetirEmail').val()) {
        alert("Os e-mails estão diferentes.");
        return false;
    }
    
    if (user.Senha == ""){
        alert("Digite a senha.");
        return false;
    }

    if (user.Senha != $('#txtRepetirSenha').val()) {
        alert('As senhas estão diferentes.');
        return false;
    }

    return true;
}












