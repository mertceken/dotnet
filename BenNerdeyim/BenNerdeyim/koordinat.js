var enlem;
var boylam;
var map;
$(document).ready(function () {
    $("#harita").hide();
})
function bul() {
    enlem = $("#enlem").val();
    boylam = $("#boylam").val();
    $("#harita").show()
    initialize();
   
}

function initialize() {

    map = new google.maps.Map(document.getElementById('harita'), {
        center: new google.maps.LatLng(enlem, boylam),
        zoom: 15
    });


    var request = {
        placeId: 'ChIJN1t_tDeuEmsRUsoyG83frY4'
    };

    var infowindow = new google.maps.InfoWindow();
    var service = new google.maps.places.PlacesService(map);

    service.getDetails(request, function (place, status) {
        if (status == google.maps.places.PlacesServiceStatus.OK) {
            var marker = new google.maps.Marker({
                map: map,
                position: place.geometry.location
            });
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.setContent(place.name);
                infowindow.open(map, this);
            });
        }
    });
}

google.maps.event.addDomListener(window, 'load', initialize);


