function navLinkOnClick(el) {
    console.log(el);
}
function UpdateRauteContent(route, divId) {
    $.ajax({
        type: 'GET',
        url: '/RauteVE/' + route,
        success: function (resp) {
            $("#"+divId).empty().append(resp);
        },
        error: function (resp) {
            console.log(resp);
        }
    });
}
function tabLinkOnClick(event) {
    var div = event.target;
    var elementId = div.href.split("#")[1];

    var route = "RauteTotalView";
    if (elementId == "churak")
        route = "RauteChurakView"
    else if (elementId == "tables")
        route = "RauteTableView"
    else if (elementId == "shpon")
        route = "RauteShponView"

    UpdateRauteContent(route, elementId);
}
jQuery(document).ready(function ($) {
    $('#tabs').tab();
    $('.raute-tab-link').click(tabLinkOnClick);
    UpdateRauteContent("RauteTotalView", "total");
    //setInterval(UpdateContent, 1000);
});