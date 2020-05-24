﻿function IconList() {
    $.post("/IconList", null, function (result) {
        $(".icon-list").html(result);
    });
}


$(document).on("click", ".IconRemove", function () {
    var id = $(this).data("id");

    var _id = $(this).data("id");
    var _removeItem = $(this).parent().parent();
    var _iconname = $(_removeItem).children(":nth-child(1)").html();

    swal({
        title: "Emin misiniz?",
        text: _iconname + "<strong> Adlı İcon Silinsin mi ? </strong>",
        type: "warning",
        html: true,
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Evet",
        cancelButtonText: "Hayır",
    },
        function (isConfirm) {
            if (isConfirm) {
                $.post("/RemoveIcon", { id: _id }, function (data) {
                    debugger;

                    if (data.Description.includes("Başarıyla")) {
                        _removeItem.remove();
                        GeneralSweet("Başarılı", _iconname + "adlı menü başarıyla silindi", data.Icon);

                    }
                    else {
                        GeneralSweet("Hata", "Bir hata Meydana Geldi", "Warning");
                    }
                });
            }
        });
});

$("#btnIconAdd").on("click", function () {
    $("#IconAddModal").modal("show");
});

$("#IconSave").on("click", function () {
    $("#frmIconAdd").submit();
});


function GeneralSweet(Title, Description, Icon) {
    swal(Title, Description, Icon);
}


function FormPost(FormId) {
    $(document).find("#" + FormId).submit();
}

function FormClear(FormId) {
    $(document).find("#" + FormId).trigger("reset");
}

function returnPostJson(data) {

    if (data.Modal != null) {
        $("#" + data.Modal).modal("hide");
    }

    GeneralSweet(data.Title, data.Description, data.Icon);
}