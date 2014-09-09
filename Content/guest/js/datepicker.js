
    $(function () {
        $("#datepicker").datepicker({
            dateFormat: "dd/mm/yy",
            showOn: "both",
            buttonImage: "http://www.khachsan247.com/templates/Hotel/images/icon_calendar.jpg",
            buttonImageOnly: true,
        });
        $("#datepicker2").datepicker({
            dateFormat: "dd/mm/yy",
            showOn: "both",
            buttonImage: "http://www.khachsan247.com/templates/Hotel/images/icon_calendar.jpg",
            buttonImageOnly: true,
        });

        $('#datepicker').datepicker().datepicker('setDate', new Date());
        $('#datepicker2').datepicker().datepicker('setDate', new Date());
    });