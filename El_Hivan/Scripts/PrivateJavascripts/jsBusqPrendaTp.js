$("#BusqPrendT").keydown(function () {
    var dato = $(this).val();

    var id = $("#drpOpciones").val();
    switch (id) {
        case "1":
            $.post("/Prenda/BusqPrenda/" + dato).done(Success)
            break;
        case "2":
            $.post("/Prenda/BusqArreglo/" + dato).done(Success)
            break;
    }

})


function Success(r) {
    console.log(r);
    $("#tblPrenda tbody").empty();
    var TabPr = "";
    for (var i = 0; i < r.length; i++)
    {
        TabPr += "<tr>"
        TabPr += "<td>"
        TabPr += r[i].Cantidad
        TabPr += "</td>"
        TabPr += "<td>"
        TabPr += r[i].Arreglo
        TabPr += "</td>"
        TabPr += "<td>"
        TabPr += r[i].Prenda
        TabPr += "</td>"
        TabPr += "<td>"
        TabPr += "<a href=\"/Prenda/Edit/" + r[i].idPrenda + "\">Editar</a>"
        TabPr += "|"
        TabPr += "<a href=\"/Prenda/Delete/" + r[i].idPrenda + "\">Eliminar</a>"
        TabPr += "</td>"
        TabPr += "</tr>"
    }
    console.log(TabPr);
    $("#tblPrenda tbody").append(TabPr);
}
$("#drpOpciones").change(function () {
    var id = $("#drpOpciones").val();
    if (id >0) {
        $("#BusqPrendT").removeAttr("readonly");

    }
    else {

        $("#BusqPrendT").attr("readonly", "readonly");
        location.reload();
    }
   

})