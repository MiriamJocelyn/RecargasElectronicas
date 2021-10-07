var $btnOfForm = $("button:submit[data-notaprenda='true']");

$btnOfForm.on('click', function (e) {

    var formTarget = $(this).parents('form:first');

    var formContent = formTarget.serialize();

    formTarget.on('submit', function (e) {
        e.preventDefault();
    });
    console.log(formTarget.attr('action'));
    console.log($btnOfForm.data("notaprenda"))

    $btnOfForm.data("notaprenda") == true ? IrAjax(formTarget.attr('action'), formContent) : false;
});

function IrAjax(actionRoute, formData) {
    console.log(actionRoute);
    $.ajax({
        type: "POST",
        url: actionRoute,
        data: formData,
        dataType: "json",
    }).done(Exito)
        .fail(Fallo);
}

function Exito(r) {

    if (ServerError_General_(r.IsServerError, r)) {
        return;
    }

    var $boxResultado = $(".resultado, .resultado-bad");
    $boxResultado.text(r.Message);

    $boxResultado.fadeIn("slow");

    r.MethodSuccess == false ? $boxResultado.removeClass('resultado').addClass('resultado-bad') : $boxResultado.removeClass('resultado-bad').addClass('resultado');

    HideResultado();

    //Creación de las filas de la nota
    $.post("/NotaPrenda/GetAll/").done(SuccesAll);
}

function SuccesAll(r) {
    console.log(r);
    $(".TableData").empty();
    $(".TableBody").empty();
    $(".TableBody2").empty();
    $(".TableFoot").empty();
    var Tabla = "";
    for (var i = 0; i < r.Lista.length; i++) {
        Tabla += "<div id=\"divTBody\" class=\"row\">"
        Tabla +=    "<div id=\"divTbCantidad\" class=\"col-md-2 TBody\">" + r.Lista[i].CantidadPrendas + "</div>"
        Tabla +=    "<div id =\"divTbPrenda\" class=\"col-md-6 TBody\">" + r.Lista[i].Prenda + "</div>"
        Tabla +=    "<div id =\"divTbPrecio\" class=\"col-md-1 TBody\">" + r.Lista[i].Precio + "</div>"
        Tabla +=    "<div id =\"divTbImporte\" class=\"col-md-1 TBody\">" + r.Lista[i].Importe + "</div>"
        Tabla += "</div>"

        Tabla += "<div id=\"divTBody2\" class=\"row\">"
        Tabla +=    "<div id=\"divTb1\" class=\"col-md-2 TBody\">" + "</div>"
        Tabla +=    "<div id=\"divTb2Descripcion\" class=\"col-md-6 TBody\">" + r.Lista[i].Descripcion + "</div>"
        Tabla +=    "<button type=\"button\" onclick=Edicion(" + r.Lista[i].idNotaPrenda + ") class=\"btn btn-primary nticon col-md-3 divTb3Edit\" data-toggle=\"modal\" data-target=\"#EditPrenda\" value=\"" + r.Lista[i].idNotaPrenda + "\">" + "<i id=\"icoEdit\" class=\"fas fa-pen notaicon fa-2x\">" + "</i>" + "</button>"
        Tabla +=    "<button type=\"button\" id=\"divTb4Delete\" class=\"btn btn-primary nticon col-md-3\">" + "<i id=\"icoDelete\" class=\"fas fa-trash notaicon fa-2x\">" + "</i>" + "</button>"
        Tabla += "</div>"
    }
    Tabla += "<div id=\"divTFoot\" class=\"row\">"
    Tabla += "<div id=\"divTf1\" class=\"col-md-8\">" + "</div>"
    Tabla += "<div id=\"divTfTotal\" class=\"col-md-1\">" + "Total:" + "</div>"
    Tabla += "<div id=\"divTfImpTotal\" class=\"col-md-1\">" + r.Total + "</div>"
    Tabla += "</div>"
    console.log(Tabla);
    $(".TableData").append(Tabla);
    var Total = parseFloat(r.Total);

    $("#Total").val(r.Total);
}


function HideResultado() {
    setTimeout(function () {
        $(".resultado, .resultado-bad").fadeOut('slow');
    }, 2500);
    setTimeout(function () {
        $(".resultado, .resultado-bad").text("");
    }, 3000);
}

function Fallo(r) {
    var $boxResultado = $(".resultado");
    $boxResultado.text(r.Message);
    $boxResultado.show("fade");
}

function ServerError_General_(band, r) {
    if (band === true) {
        window.location = "/Error?url=" + r.UrlError + "&mensaje=" + r.Mensaje + " ";
        return true;
    }
    else {
        return false;
    }
}