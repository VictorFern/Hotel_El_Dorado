
function consultarDisponibilidad() {
    let fechaEntrada = $('input#fechaEntradaRD').val();
    let fechaSalida = $('input#fechaSalidaRD').val();
    let tipoHabitacion = $('select#selectTipoRD option:selected').val();

    let param = {
        'fechaEntrada': fechaEntrada,
        'fechaSalida': fechaSalida,
        'tipo': parseInt(tipoHabitacion)
    };

    $.ajax({
        data: param,
        url: '/Habitacion/ListarHabDisponibles/',
        type: "post",
        success: function (response) {
            let data = JSON.parse(response);
            
            $('.divWrapper').empty();
            let html = '';

            if (data.length != 0) {
                html =
                    '<table class="table table-bordered table-responsive table-hover">' +
                    '<tr>' +
                    '<th>Número de habitación</th>' +
                    '<th>Tipo</th>' +
                    '<th>Costo de estadía</th>' +
                    '</tr>';

                data.forEach(item => {
                    html += '<tr>' +
                        '<td>' + item['Numero_Habitacion'] + '</td>' +
                        '<td>' + item['Tipo_HabitacionT'] + '</td>' +
                        '<td>₡' + item['Costo'] + '</td>' +
                        '</tr>';
                });
                html += '</table>';
            }
            else
            {
                html = '<h3>No se encontraron resultados</h3>';
            }

            $('#divWrapper').append(html);
      
        }
    });
}