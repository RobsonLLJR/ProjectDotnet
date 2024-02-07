//#region Loading

function AlterMessageLoading(mensagem) {
    $('#MessageLoading').text(mensagem);
}

function HideLoading() {
    $('#Loading').modal('hide');
}

function ShowLoading() {
    ShowLoadingMessage('Carregando...');
}

function ShowLoadingMessage(mensagem) {
    AlterMessageLoading(mensagem);
    $('#Loading').modal('show');
}


//#endregion