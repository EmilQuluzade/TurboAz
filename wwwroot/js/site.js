$(document).ready(function () {
    $(".veen .rgstr-btn button").click(function () {
        $('.veen .wrapper').addClass('move');
        $('.body').css('background', '#e0b722');
        $(".veen .login-btn button").removeClass('active');
        $(this).addClass('active');

    });
    $(".veen .login-btn button").click(function () {
        $('.veen .wrapper').removeClass('move');
        $('.body').css('background', '#ff4931');
        $(".veen .rgstr-btn button").removeClass('active');
        $(this).addClass('active');
    });
});

document.addEventListener('DOMContentLoaded', function () {
    // Find the button element by its id
    var loginButton = document.getElementById('loginButton');

    // Add click event listener to the button
    loginButton.addEventListener('click', function (event) {
        // Redirect to login-register.html
        window.location.href = 'login-register.html';
    });
});
