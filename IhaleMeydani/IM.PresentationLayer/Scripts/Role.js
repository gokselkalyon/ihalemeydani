$(document).ready(function () {







    $(document).on("click", ".delete-row-menu", function () {
        debugger;
        var id = $(this).attr("data-id");
        var deleteTr = $(this).closest("tr");
        swal({
            title: "Emin misiniz?",
            text: "<strong>menu  Silinecek!</strong>",
            type: "warning",
            html: true,
            showCancelButton: true,
            confirmButtonColor: "#DD6B55",
            confirmButtonText: "Evet, silinsin!",
            cancelButtonText: "Hayır, vazgeç!",
        },
            function (isConfirm) {
                if (isConfirm) {
                    debugger;
                    $.ajax({
                        url: '/RemoveMenu/',
                        data: { "id": id },
                        type: "POST",
                        dataType: 'json',
                        success: function (result) {
                            if (result == 1) {
                                deleteTr.remove();
                            }
                            else {
                                deleteTr.remove();
                                swal("Başarısız!", "silme İşlemi Gerçekleşmedi!");
                            }
                        }
                    });
                }
            });
    });

















    $(document).on("click", ".delete-row-role", function () {
        debugger;
        var id = $(this).attr("data-id");
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
                    debugger;
                    $.ajax({ 
                        url: '/Roles/RoleDelete/',
                        data: { "id": id },
                        type: "POST",
                        dataType: 'json',
                        success: function (result) { 
                            if (result == 1) {
                                deleteTr.remove(); 
                            }
                            else {

                                swal("Başarısız!", "silme İşlemi Gerçekleşmedi!");
                            }
                        }
                    });
                }
            });
    });





});



    