$(function () {
    var $loading = $('#loading-background').hide();
    $(document)
        .ajaxStart(function () {
            //ajax request went so show the loading image
            $loading.delay(1500).show();
        })
        .ajaxStop(function () {
            //got response so hide the loading image
            $loading.delay(1500).hide();
            //$("#loading-background").css("background-color", "none");
        });
});