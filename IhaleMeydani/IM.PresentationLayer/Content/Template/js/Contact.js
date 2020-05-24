$("#btnContactAdd").on("click", function () {
    $("#ContactAddModal").modal("show");
});

function FormPost(FormId) {
    $(document).find("#" + FormId).submit();
}

function FormClear(FormId) {
    $(document).find("#" + FormId).trigger("reset");
    $("#" + FormId).find('.error-validate').html("");
}

function GeneralSweet(Title, Description, Icon) {
    swal(Title, Description, Icon);
}


function returnPostJson(data) {

    if (data.Modal != null) {
        $("#" + data.Modal).modal("hide");
    }

    GeneralSweet(data.Title, data.Description, data.Icon);
}

function ContactList() {
    $.post("/Contact/ContactList", null, function (result) {
        $(".contact-list").html(result);
    });
}

$(document).on("click", ".ContactRemove", function () {
    debugger;
    var _id = $(this).data("id");
    var _removeItem = $(this).parent().parent();
    var _contactname = $(_removeItem).children(":nth-child(1)").html();

    swal({
        title: "Emin misiniz?",
        text: _contactname + "<strong> Adlı İletişim Silinsin mi ? </strong>",
        type: "warning",
        html: true,
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Evet",
        cancelButtonText: "Hayır",
    },
        function (isConfirm) {
            if (isConfirm) {
                $.post("/RemoveContact", { id: _id }, function (data) {
                    debugger;

                    if (data.Description.includes("Başarıyla")) {
                        _removeItem.remove();
                        GeneralSweet("Başarılı", _contactname + "adlı iletişim başarıyla silindi", data.Icon);

                    }
                    else {
                        GeneralSweet("Hata", "Bir hata Meydana Geldi", "Warning");
                    }
                });
            }
        });
});

