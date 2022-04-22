function crearPublicidad() {

    var parametros = {
        "ID_Publicidad": 0,
        "Link": document.getElementById('link').value,
    };

    $.ajax(
        {

            data: parametros,
            url: '/Publicidad/Crear',
            type: "post",
            success: function (response) {
                //$('#tbodyDocumento').html(response);
            }
        }
    );
}

function adjuntarImagen() {

    var input = document.getElementById("imagen");
    var files = input.files;
    var formData = new FormData();

    for (var i = 0; i != files.length; i++) {
        formData.append("files", files[i]);
    }

    $.ajax(
        {
            url: '/Publicidad/Imagen',
            data: formData,
            processData: false,
            contentType: false,
            type: "post",
            success: function (response) {
                $('#imagenCargada').html(response);
            }
        }
    );
}

function adjuntarImagen2() {

    var input = document.getElementById("imagen2");
    var files = input.files;
    var formData = new FormData();

    for (var i = 0; i != files.length; i++) {
        formData.append("files", files[i]);
    }

    $.ajax(
        {
            url: '/Oferta/Imagen',
            data: formData,
            processData: false,
            contentType: false,
            type: "post",
            success: function (response) {
                $('#imagenCargada').html(response);
            }
        }
    );
}

function eliminarPublicidad(id) {
    var ID = id;
    $.ajax(
        {
            data: ID,
            url: '/Publicidad/Eliminar/' + id,
            type: 'get',
            success: function (response) {
                $('#tbodyPublicidad').html(response);
                $('#alertas').html(
                    "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                    "<strong>¡Éxito!</strong> Publicidad eliminada con éxito." +
                    "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                    "<span aria-hidden='true'>&times;</span></button></div>"
                );
            }
        });
}

function modificarPublicidad(id) {
    document.location.href = '/Publicidad/ModificarPublicidad/' + id;
}

function crearOferta() {

    var parametros = {
        "ID_Oferta": 0,
        "Oferta": document.getElementById('oferta').value,
        "Fecha_Inicio": document.getElementById('fechaInicio').value,
        "Fecha_Fin": document.getElementById('fechaFin').value,
    };

    $.ajax(
        {

            data: parametros,
            url: '/Oferta/Crear',
            type: "post",
            success: function (response) {
                //$('#tbodyDocumento').html(response);
            }
        }
    );
}