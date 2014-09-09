$(document).ready(function () {
    $('#li_tab1').click(function () {

        // $('#tab1').attr('style', 'display:block');
        $('#tab1').fadeIn();

        $('#tab2, #tab3, #tab4').attr('style', 'display:none');

        $('#li_tab1').addClass("current");
        $('#li_tab2, #li_tab3, #li_tab4').removeClass("current");

    });

    $('#li_tab2').click(function () {
        //$('#tab2').attr('style', 'display:block');
        $('#tab2').fadeIn();
        $('#tab1, #tab3, #tab4').attr('style', 'display:none');

        $('#li_tab2').addClass("current");
        $('#li_tab1, #li_tab3, #li_tab4').removeClass("current");
    });


    $('#li_tab3').click(function () {
        //$('#tab3').attr('style', 'display:block');
        $('#tab3').fadeIn();
        $('#tab1, #tab2, #tab4').attr('style', 'display:none');

        $('#li_tab3').addClass("current");
        $('#li_tab1, #li_tab2, #li_tab4').removeClass("current");
    });

    $('#li_tab4').click(function () {
        //$('#tab4').attr('style', 'display:block');
        $('#tab4').fadeIn();
        $('#tab1, #tab3, #tab2').attr('style', 'display:none');

        $('#li_tab4').addClass("current");
        $('#li_tab1, #li_tab3, #li_tab2').removeClass("current");
    });
});