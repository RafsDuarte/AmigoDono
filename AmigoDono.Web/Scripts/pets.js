function verificarProtocolo() {
    if (window.location.protocol == 'https:')
        window.location = 'http://www.esteio.rs.gov.br/catioro';
}
function confirmarCaptura(catioroId, localId) {
    if (confirm("Deseja realmente adotar o catioro selecionado?")) {
        //Checa conexÃ£o para realizar a captura
        FB.login(function (response) {
            if (response.status === 'connected') {
                //Indica usuÃ¡rio como candidato Ã  adoÃ§Ã£o
                capturar(catioroId, localId);
            } else if (response.status === 'not_authorized') {
                //O usuÃ¡rio nÃ£o permitiu acesso
                alert('VocÃª precisa permitir acesso pelo aplicativo para capturar o Catioro!');
            }
        }, { scope: 'public_profile,email' });
    }
}

function capturar(catioroId, localId) {
    //Verifica se a ID do catioro Ã© vÃ¡lida
    if (isNaN(catioroId) || catioroId == 0) {
        alert('Amigo nÃ£o localizado. Tente mais tarde.');
        return false;
    }
    //Verifica se a ID do local Ã© vÃ¡lida
    if (isNaN(localId) || localId == 0) {
        alert('Local invÃ¡lido. Tente mais tarde.');
        return false;
    }

    //Busca dados do usuÃ¡rio
    FB.api('/me?fields=id,name,email,picture', function (response) {
        var retorno = verificarDiponibilidade(catioroId, localId, response);
        if (retorno != undefined) alert(retorno);
    });
}

function verificarDiponibilidade(catioroId, localId, response) {
    //Valida dados
    if (isNaN(catioroId) || catioroId == 0) return 'Amigo nÃ£o localizado';
    if (isNaN(localId) || localId == 0) return 'Local nÃ£o localizado';
    if (response.id == undefined) return 'NÃ£o conseguimos te identificar';
    if (response.name == undefined) return 'Teu nome nÃ£o foi recebido';
    if (response.email == undefined) return 'Teu e-mail nÃ£o foi encontrado';
    if (response.picture == undefined) return 'Sua imagem nÃ£o foi encontrada';

    //Solicita telefone de contato
    var contato = prompt("Por favor, informe um nÃºmero de telefone / celular para contato");

    //Monta dados
    var catioro =
        '{"catioro_id":"' + catioroId +
        '","usuario_id":"' + response.id +
        '","usuario_nome":"' + response.name +
        '","usuario_email":"' + response.email +
        '","usuario_imagem":"' + response.picture.data.url +
        '","usuario_contato":"' + contato +
        '"}';

    //Prepara dados
    var cadastro = $.parseJSON(catioro);

    //Envia dados
    $.post("capturar.php", cadastro,
        function (data) {
            var retorno = informarResultado(data);
            if (retorno != undefined) {
                alert(retorno);
                window.location.href = 'index.php?sobre&local=' + localId + '#onde';
            }
        },
        'json'
    );
}

function informarResultado(data) {
    if (typeof data != 'object') return 'NÃ£o foi possÃ­vel capturar o amigo';
    if (data.erro != undefined) return data.erro;
    if (data.capturado != undefined) return 'Amigo capturado! VocÃª terÃ¡ um prazo de sete dias para buscar o animal. ApÃ³s esse tempo, o bicho voltarÃ¡ a ficar disponÃ­vel.';
}

window.fbAsyncInit = function () {
    FB.init({
        appId: '1816157981937958',
        xfbml: true,
        version: 'v2.5'
    });
};

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "http://connect.facebook.net/pt_BR/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));

function selecionaLocal(div) {
    //A primeira chamada, automÃ¡tica, nÃ£o alterada a marcaÃ§Ã£o
    if (div.tagName == 'DIV') {
        //Remove marcaÃ§Ã£o de todos as divs
        $('.atual').removeClass('atual');
        //Adiciona marcaÃ§Ã£o na div clicada
        $(div).addClass('atual');
    }
}