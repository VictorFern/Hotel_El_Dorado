
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
            
            $('#divWrapper').empty();
            let html = '';
            if (data.length != 0) {
                html =
                    '<table class="table table-bordered table-hover">' +
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
function activa() {
    let checkBox = $('input#flexCheckDefault').val();
    // Get the output text
    let param = {
        'tipo': checkBox
    };
    $.ajax({
        data: param,
        url: '/Habitacion/Activa/',
        type: "post",
        success: function (response) {

        }
    });

}

function print() {
    var element = document.getElementById("reportePdf");
    var pdf = 'reporte_idReservacion_' + document.getElementById("id").innerHTML + '_cliente_' + document.getElementById("cliente").innerHTML + '.pdf'
    html2pdf().from(element).save(pdf);
}

