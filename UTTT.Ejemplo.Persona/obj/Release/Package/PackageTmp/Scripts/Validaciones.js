$document.ready(() => {
    $('#form1').submit(function (evento) {
        let sexo = $('#ddlSexo').val().trim();
        let clave = $('#txtClaveUnica').val().trim();
        let nombre = $('#txtNombre').val().trim();
        let apaterno = $('#txtAPaterno').val().trim();
        let amaterno = $('#txtAMaterno').val().trim();
        let fecha = $('#txtFnacim').val().trim();
    })
});