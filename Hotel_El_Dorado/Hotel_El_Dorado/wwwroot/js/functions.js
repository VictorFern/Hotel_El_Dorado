function cambiarImg(a) {
    let srcNuevo = $("#" + a).attr("src");
    $("#imgBig").attr("src", srcNuevo);
}