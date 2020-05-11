$(document).ready(function () {
    $(document).on("click", ".block-user", function () {
        debugger;
        var id = +$(this).attr("data-id");
        var deleted = $(this).attr("data-bind"); 
        if (deleted == "True") {
            swal({
                title: "Emin misiniz?",
                text: "<strong>Kullanıcı Engeli Kaldırılacak!</strong>",
                type: "warning",
                html: true,
                showCancelButton: true,
                confirmButtonColor: "#DD6B55",
                confirmButtonText: "Evet, Kaldır!",
                cancelButtonText: "Hayır, vazgeç!",
            },
                function (isConfirm) {
                    if (isConfirm) {
                        debugger;
                        $.ajax({
                            url: '/User/UserBlock/',
                            data: { "id": id },
                            type: "POST",
                            dataType: 'json',
                            success: function (result) {
                                if (result == 1) {
                                    $("#" + id).empty();
                                    $("#" + id).append(
                                        'Engelle'
                                    )
                                }
                                else {
                                    swal("Başarısız!", "Engel Kaldırma İşlemi Gerçekleşmedi!");
                                }
                            }
                        });
                    }
                });
        } else {
            swal({
                title: "Emin misiniz?",
                text: "<strong>Kullanıcı Engellenecek!</strong>",
                type: "warning",
                html: true,
                showCancelButton: true,
                confirmButtonColor: "#DD6B55",
                confirmButtonText: "Evet, Engelle!",
                cancelButtonText: "Hayır, vazgeç!",
            },
                function (isConfirm) {
                    if (isConfirm) {
                        debugger;
                        $.ajax({
                            url: '/User/UserBlock/',
                            data: { "id": id },
                            type: "POST",
                            dataType: 'json',
                            success: function (result) {
                                if (result == 1) {
                                    $("#" + id).empty();
                                    $("#" + id).append(
                                        'Engeli Kaldır'
                                    )
                                }
                                else {
                                    swal("Başarısız!", "Engelleme İşlemi Gerçekleşmedi!");
                                }
                            }
                        });
                    }
                });
        }
        
    });
});