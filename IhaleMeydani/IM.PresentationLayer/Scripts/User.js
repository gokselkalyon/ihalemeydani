$(document).ready(function () {
    $(document).on("click", ".block-user", function () { 
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
                        $.ajax({
                            url: '/User/UserBlock/',
                            data: { "id": id },
                            type: "POST",
                            dataType: 'json',
                            success: function (result) {
                                if (result == 1) {
                                    debugger;
                                    $("#" + id).empty();
                                    $("#" + id).append(
                                        'Engelle'
                                    );
                                    $("." + id).empty();
                                    $("." + id).append(
                                        'Hayır'
                                    );
                                    $("#" + id).removeAttr("data-bind");
                                    $("#" + id).attr("data-bind", "False");
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
                                    );
                                    $("." + id).empty();
                                    $("." + id).append(
                                        'Evet'
                                    );
                                    $("#" + id).removeAttr("data-bind");
                                    $("#" + id).attr("data-bind", "True");
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

$(function () {
    $('#datetimepicker1').datetimepicker({ 
    })
});