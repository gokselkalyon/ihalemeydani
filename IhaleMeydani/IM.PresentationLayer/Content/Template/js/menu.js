$(document).on("click", ".MenuRemove", function () {
    debugger;
    var _id = $(this).data("id");
    var _removeItem = $(this).parent().parent();
    var _menuname = $(_removeItem).children(":nth-child(1)").html();

    swal({
        title: "Emin misiniz?",
        text: _menuname + "<strong> Adlı Menü Silinsin mi ? </strong>",
        type: "warning",
        html: true,
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Evet",
        cancelButtonText: "Hayır",
    },
        function (isConfirm) {
            if (isConfirm) {
                $.post("/RemoveMenu", { id: _id }, function (data) {
                    debugger;

                    if (data.Description.includes("Başarıyla")) {
                        _removeItem.remove();
                        GeneralSweet("Başarılı", _menuname + "adlı menü başarıyla silindi", data.Icon);

                    }
                    else {
                        GeneralSweet("Hata", "Bir hata Meydana Geldi", "Warning");
                    }
                });
            }
        });
});


$("#btnMenuAdd").on("click", function () {
    $("#MenuAddModal").modal("show");
});

$(document).on("click", ".MenuUpdate", function () {
    var _id = $(this).data("id");
    $.post("/MenuUpdate", { MenuId: _id }, function (data) {
        $(".menu-update").html(data);
        $(document).find("#MenuUpdateModal").modal("show");
    });
});

function GeneralSweet(Title, Description, Icon) {
    swal(Title, Description, Icon);
}



function MenuList() {
    $.post("/Menu/GetMenus", null, function (data) {
        $(".menu-list").html("");
        $(".menu-list").html(data);
    });
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