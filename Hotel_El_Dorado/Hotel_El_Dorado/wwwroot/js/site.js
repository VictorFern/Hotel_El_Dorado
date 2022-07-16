function verificarFecha() {

    if (document.getElementById('fechaEntrada').value != "" && document.getElementById('fechaSalida').value != "" && document.getElementById('tipoHabitacion').value != 0) {

        var parametros = {
            "fechaEntrada2": document.getElementById('fechaEntrada').value,
            "fechaSalida2": document.getElementById('fechaSalida').value,
            "tipoHabitacion": parseInt(document.getElementById('tipoHabitacion').value, 10)
        };

        $.ajax(
            {

                data: parametros,
                url: '/Reservacion/Verificar',
                type: "post",
                success: function (response) {
                    if (response != 0) {
                        $('#alertas').html("<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                            "<strong>¡Perfecto!</strong> Las fechas ingresadas para el tipo de habitación están disponibles." +
                            "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span></button></div>");
                        $('#boton').html("<button type='submit' class='btn btn-primary mt-2'>Siguiente</button>");
                        $('input#idHabitacion').val(parseInt(response));
                    } else {
                        $('#alertas').html("<div class='alert alert-danger alert-dismissible fade show' role='alert'>" +
                            "<strong>¡Lo sentimos!</strong> En ese rango de fechas no tenemos habitaciones disponibles." +
                            "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span></button></div>");
                        $('#boton').html("<button type='submit' class='btn btn-primary mt-2' disabled>Siguiente</button>");
                    }

                }
            }
        );

    } else {
        if (document.getElementById('tipoHabitacion').value == 0) {
            $('#boton').html("<button type='submit' class='btn btn-primary mt-2' disabled>Siguiente</button>");
        }
    }
        
}

function cancelarReservacion() {
    console.log("entra");
    document.location.href = '/Reservacion/Reservar';
}

function BuscarClienteCedula() {
    console.log('entra');
        var parametros = {
            "cedula": parseInt(document.getElementById('cedula').value, 10)
        };

        $.ajax(
            {

                data: parametros,
                url: '/Cliente/BuscarCedula',
                type: "post",
                success: function (response) {
                    $('input#nombre').val(parseInt(response.Nombre));
                    $('input#apellidos').val(parseInt(response.Apellidos));
                    $('input#email').val(parseInt(response.Email));
                    console.log('retorna');
                }
            }
        );

}