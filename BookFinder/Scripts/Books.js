﻿$(function () {

});


/*
function viewBook(isbn) {
    var paramObject = {};
    paramObject.isbn = isbn;

    $.ajax({
        url: "/Books/GetBook",
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(paramObject),
        success: function (data) {
            console.log(data.Title);
            $("#title").text(data.Title);
            $("#description").text(data.Description);
        },
        failure: function (errMsg) {
            console.log(errMsg);
        }
    });
}
*/

function viewBookUsingCache(isbn) {
    var model = JSON.parse($('#books-model').val());

    $.each(model.Books, function (i, v) {
        if (v.ISBN == isbn) {
            $("#title").html(v.Title);
            $("#description").html(v.Description);
            return;
        }
    });
}