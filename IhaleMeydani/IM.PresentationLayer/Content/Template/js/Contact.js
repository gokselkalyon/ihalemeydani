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

