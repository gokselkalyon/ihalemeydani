 
$("#frmUserCreate").submit(function (e) { 
    $("#snackbar").empty();
    e.preventDefault();
    var formData = new FormData(this);
    $.ajax({
        url: "/Login/UserCreate",
        type: "POST",
        data: formData,
        mimeType: "multipart/form-data",
        contentType: false,
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == 1) {  
                $("#snackbar").append('Kayıt Başarılı.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
                window.location.href = "/Login";
            } else if (data == 2) {
                $("#snackbar").append('Şifreler Birbirine Uymuyor.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
            } else if (data == 3) {
                $("#snackbar").append('Bu Kullanıcı Adı Kullanılıyor.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
            } else if (data == 4) {
                $("#snackbar").append('Bu Email Kullanılıyor.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
            }
        }
    });
});

