$(function () {
    var activeButton = $("#accordion").find("a[href='" + window.location.pathname + "']");
    $("#accordion").accordion({ heightStyle: "content", navigation: true, active: activeButton.parent().data("panel-index") });

    $(".ui-accordion-content a").button();

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
