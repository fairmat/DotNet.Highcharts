$(function () {
    $("#accordion").accordion({ autoHeight: false, navigation: true });

    $(".ui-accordion-content a").button();

    var activeButton = $(".ui-accordion-content a[href='" + window.location.pathname + "']");
    activeButton.addClass("ui-state-active");
    activeButton.hover(
        function () {
            $(this).addClass("ui-state-active");
        },
        function () {
            $(this).addClass("ui-state-active");
        });

    $("#tabs").tabs();
});
