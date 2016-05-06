$(document).ready(function () {

    var url = "http://localhost:1966/ServiceProduct.svc/api/GetAll";
    $.ajax({
        type: "GET",
        url: url,
        contentType: "application/json; charset=utf-8",
        //data: JSON.stringify(postdata),
        dataType: "json",
        success: function (data) {
            $.each(data, function (arrayID, producto) {
                $('#list').append('<li>' + producto.Name + '<input type="text"/><input type="button" value="Comprar" /></li>');

            });
        },
        error: function (a, b, c) { console.log(a); }
    });
});