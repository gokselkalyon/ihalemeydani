function IconList() {
    $.post("/IconList", null, function (result) {
        $(".icon-list").html(result);
    });
}

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