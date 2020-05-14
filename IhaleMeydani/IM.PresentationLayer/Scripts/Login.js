 
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
                window.location.href = "/Login";
                $("#snackbar").append('Kayıt Başarılı.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
              
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

$("#frmUserLogin").submit(function (e) { 
    e.preventDefault();
    $("#snackbar").empty();
    var formData = new FormData(this);
    $.ajax({
        url: "/Login/UserLogin",    
        type: "POST",
        data: formData,
        mimeType: "multipart/form-data",
        contentType: false,
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == 1) {
                window.location.href = "/";
            } else if (data == 2) {
                $("#snackbar").append('Geçersiz şifre veya kullanıcı adı.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
            } else if (data == 3) {
                $("#snackbar").append('Giriş yapmanız Engellendi.');
                var x = document.getElementById("snackbar");
                x.className = "show";
                setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
            }
            else if (data == 4) {
                window.location.href = "Admin";
            }
        }
    });
});

