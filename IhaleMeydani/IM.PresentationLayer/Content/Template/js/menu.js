$(document).on("click", ".MenuRemove", function () {
    debugger;
    var _id = $(this).data("id");
    var _removeItem = $(this).parent().parent();
    var _menuname = $(_removeItem).children(":nth-child(1)").html();

    swal({
        title: "Emin misiniz?",
        text: _menuname + "<strong> Adlı Menü  Silinecek!</strong>",
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


function GeneralSweet(Title, Description, Icon) {
    swal(Title, Description, Icon);
}
