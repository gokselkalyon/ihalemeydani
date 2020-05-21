$(document).on("click", ".MenuRemove", function () {
    var _id = $(this).data("id");
    var _removeItem = $(this).parent().parent();
    var _menuname = $(_removeItem).children(":nth-child(1)").html();

    Swal.fire({
        title: 'Silme İşlemi',
        text: _menuname+ " adlı menü silinsin mi ?",
        icon: 'question',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Evet',
        cancelButtonText: "Kapat"
    }).then((result) => {
        if (result.value) {
            $.post("/RemoveMenu", { id: _id }, function (data) {
                if (data.Description.includes("Başarıyla")) {
                    SweetAlert(data.Icon, "Silme İşlemi", _menuname + " başarıyla silindi");
                }
                else {
                    Message("error", "Bir hata oluştu");
                }
            });
        }
    });
 
});


