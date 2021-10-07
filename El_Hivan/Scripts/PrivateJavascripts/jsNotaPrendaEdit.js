function Edicion(id) {
    console.log(id);
    $(".EditBody").empty();
    $.post("/Nota/GetNotaPrenda/" + id).done(SuccessNtPr);
}

function SuccessNtPr(r) {
    console.log(r);
    
    var Mod = "";
    Mod += "<h2>Editar Prenda</h2>"
    Mod += "<div class=\"form-horizontal\">"
    Mod +=      "<hr/>"

    Mod +=      "<div class=\"form-group\">"
    Mod +=          "<label class=\"control-label col-md-2\" for=\"Prendas\">Prendas</label>"
    Mod +=          "<div class=\"col-md-10\">"
    Mod +=              "<select class=\"form-control\" id=\"idTipoPrendaEdit\" name=\"idTipoPrendaEdit\" onchange=\"Arreglo();\">"
    Mod +=                 DropdownList(r.Pr,r.Edit[0].idTipoPrenda);
    Mod +=              "</select>"
    Mod +=              "<span class=\"field-validation-valid text-danger\" data-valmsg-for=\"Prenda.idTipoPrenda\" data-valmsg-replace=\"true\"></span>"
    Mod +=          "</div>"
    Mod +=      "</div>"

    Mod +=      "<div class=\"form-group\">"
    Mod +=          "<label class=\"control-label col-md-2\" for=\"Arreglos\">Arreglos</label>"
    Mod +=          "<div class=\"col-md-10\">"
    Mod +=              "<select class=\"form-control\" id=\"idArregloEdit\" name=\"idArregloEdit\" onchange=\"Precio();\">"
    Mod +=                 DropdownList(r.Ar,r.Edit[0].idArreglo);
    Mod +=              "</select>"
    Mod +=              "<span class=\"field-validation-valid text-danger\" data-valmsg-for=\"Prenda.idArreglo\" data-valmsg-replace=\"true\"></span>"
    Mod +=          "</div>"
    Mod +=      "</div>"

    Mod +=      "<div class=\"form-group\">"
    Mod +=          "<label class=\"control-label col-md-2\" for=\"Descripcion\">Descripción</label>"
    Mod +=          "<div class=\"col-md-10\">"
    Mod +=              "<input class=\"form-control text-box single-line\" id=\"DescripcionEdit\" name=\"DescripcionEdit\" type=\"text\" value=\"" + r.Edit[0].Descripcion + "\" \>"
    Mod +=              "<span class=\"field-validation-valid text-danger\" data-valmsg-for=\"DescripcionEdit\" data-valmsg-replace=\"true\"></span>"
    Mod +=          "</div>"
    Mod +=      "</div>"

    Mod +=      "<div class=\"form-group\">"
    Mod +=          "<label class=\"control-label col-md-2\" for=\"Prenda_Cantidad\">Precio</label>"
    Mod +=          "<div class=\"col-md-10\"><input class=\"form-control text-box single-line\" data-val=\"true\" data-val-number=\"El campo Cantidad debe ser un número.\" data-val-required=\"El campo Cantidad es obligatorio.\" id=\"PrendaCantidadEdit\" name=\"PrendaCantidadEdit\" readonly=\"True\" type=\"text\" value=\"" + r.Edit[0].Precio + "\" \>"
    Mod +=          "</div>"
    Mod +=      "</div>"

    Mod +=      "<div class=\"form-group\">"
    Mod +=          "<label class=\"control-label col-md-2\" for=\"CantidadPrendas\">Cantidad</label>"
    Mod +=          "<div class=\"col-md-10\">"
    Mod +=              "<input class=\"form-control text-box single-line\" data-val=\"true\" data-val-number=\"El campo CantidadPrendas debe ser un número.\" data-val-required=\"El campo CantidadPrendas es obligatorio.\" id=\"CantidadPrendasEdit\" name=\"CantidadPrendasEdit\" type=\"number\" value=\"" + r.Edit[0].CantidadPrendas + "\" \>"
    Mod +=              "<span class=\"field-validation-valid text-danger\" data-valmsg-for=\"CantidadPrendas\" data-valmsg-replace=\"true\"></span>"
    Mod +=          "</div>"
    Mod +=      "</div>"

    Mod += "</div>"
    $(".EditBody").append(Mod);
}

function DropdownList(Lista,Selected) {
    var OpPr = "";
    OpPr += "<option value=\"0\">Seleccionar Opción</option>"

    for (var i = 0; i < Lista.length; i++) {
        if ((i+1) == Selected) {
            OpPr += "<option value=\"" + Lista[i].Value + "\" selected=\"selected\">" + Lista[i].Text + "</option>";
        }
        else {
            OpPr += "<option value=\"" + Lista[i].Value + "\">" + Lista[i].Text + "</option>";
        }
    }

    return OpPr;
}

function Arreglo() {
    var id = $("#idTipoPrendaEdit").val();
    $.post("/NotaPrenda/GetArreglo/" + id).done(SuccessTipoPrendaEdit);
}

function SuccessTipoPrendaEdit(r) {
    console.log(r);
    $("#idArregloEdit").empty();
    var text = "";
    text = "<option value=\"0\">Seleccionar Opción</option>";
    for (var i = 0; i < r.length; i++) {
        text += "<option value=\"" + r[i].Id + "\">" + r[i].TipoArreglo + "</option>";
    }
    $("#idArregloEdit").append(text);
}

function Precio() {
    var id = $("#idTipoPrendaEdit").val();
    var dato = $("#idArregloEdit").val();
    $.post("/NotaPrenda/GetPrecio/" + id + "/" + dato).done(SuccessPrecioEdit);
}

function SuccessPrecioEdit(r) {
    console.log(r);
    console.log(r.length);
    var lista = "";
    if (r.length == 1) {
        $("#PrendaCantidadEdit").empty();
        lista = "";
        lista += "<input class=\"form-control text-box single-line\" data-val=\"true\" data-val-number=\"El campo Cantidad debe ser un número.\" data-val-required=\"El campo Cantidad es obligatorio.\" id=\"Prenda_Cantidad\" name=\"Prenda.Cantidad\" readonly=\"True\" type=\"text\" value=\"\">"
        $("#PrendaCantidadEdit").append(lista);
        $("#PrendaCantidadEdit").val(r[0].Cantidad);
        $("#PrendaCantidadEdit").val(r[0].id);
    }
    else {
        $("#PrendaCantidadEdit").empty();
        lista = "";
        lista = "<select class=\"form-control\" id=\"idPrecio\" name=\"idPrecio\">"
        lista += "<option value=\"0\">Seleccionar Opción</option>";
        for (var i = 0; i < r.length; i++) {
            lista += "<option value=\"" + r[i].id + "\">" + r[i].Cantidad + "</option>";
        }
        lista += "</select>"
        $("#PrendaCantidadEdit").append(lista);
    }
}

$("#PrendaCantidadEdit").change(function () {
    var id = $("#idPrecio").val();
    $("#idPrenda").val(id);
})