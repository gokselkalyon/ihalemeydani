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