var selectedViewTabId = "", selectedRoute = "";
function navLinkOnClick(el) {
    console.log(el);
}
function UpdateRauteContent(route, divId) {
    var type = getUrlParameter("type");
    $.ajax({
        type: 'GET',
        url: '/RauteVE/' + route + "?type=" + type,
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
    selectedViewTabId = elementId;
    selectedRoute = route;
}

function SelectedTabUpdater() {
    UpdateRauteContent(selectedRoute, selectedViewTabId);
}

jQuery(document).ready(function ($) {
    $('#tabs').tab();
    $('.raute-tab-link').click(tabLinkOnClick);
    selectedViewTabId = "total";
    selectedRoute = "RauteTotalView";
    UpdateRauteContent(selectedRoute, selectedViewTabId);
    setInterval(SelectedTabUpdater, 1000);
});