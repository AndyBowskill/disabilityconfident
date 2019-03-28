// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function loadAndDrawImage(url) {

    var image = new Image();

    image.onload = function () {
        var c = document.getElementById("employers-that-have-signed-up");
        var ctx = c.getContext("2d");
        ctx.drawImage(image, 0, 0, 628, 741);
    };

    image.src = url;
}
loadAndDrawImage("images/employers_that_have_signed_up.png");
