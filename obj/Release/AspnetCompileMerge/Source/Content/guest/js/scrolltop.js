$(function () {
    $('#scrlTop').click(function () {
        $('html, body').animate({
            scrollTop: '0px'
        },
        4000);
        return false;
    });
});