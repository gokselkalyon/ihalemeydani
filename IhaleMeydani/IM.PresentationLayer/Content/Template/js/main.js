function returnPostJson(data) {

    if (!$.null(data.Modal)) {
        $(document).find("#" + data.Modal).modal("hide");
    }

    if (!$.null(data.Function)) {
        Function();
    }

    SweetAlert(data.Icon, data.Title, data.Description);
    if (!$.null(data.Url)) {
        setTimeout(function () {
            window.location.replace(data.Url);
        }, 1500);
    }

}

$.extend({
    null: function (value) {
        if (value == null) {
            return true;
        }
        else {
            return false;
        }
    }
});



function SweetAlert(erroricon, errortitle, errortext) {
    Swal.fire({
        icon: erroricon,
        title: errortitle,
        text: errortext,
        confirmButtonText: "Tamam"
    })
}