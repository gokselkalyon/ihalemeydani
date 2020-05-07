$(document).on("click", ".delete-row-role", function () {
    debugger;
    var Id = $(this).attr("data-id");
    var deleteTr = $(this).closest("tr"); 
    swal({
        title: "Emin misiniz?",
        text: "<strong>Rol Silinecek!</strong>",
        type: "warning",
        html: true,
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Evet, silinsin!",
        cancelButtonText: "Hayır, vazgeç!",
    },
        function (isConfirm) {
            if (isConfirm) {
                $.ajax({
                    url: "/Mesai/Delete/" + Id,
                    type: "POST",
                    success: function (result) {

                        if (result == 1) {
                            deleteTr.remove();
                            table.draw();
                        }
                        else {
                            alert("İşlem sırasında hata oluştu");
                        }
                    }
                });
            }
        });
});