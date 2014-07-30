var temp = ['1100 Rue Notre-Dame Ouest, Montréal, QC, H3C 1K3'];
var map;
function initialize() {
    var mapOptions = {
        center: new google.maps.LatLng(45.545793, -73.622818),
        zoom: 11
    };
    map = new google.maps.Map(document.getElementById("map_canvas"),
        mapOptions);
    createMarkers();
}

google.maps.event.addDomListener(window, 'load', initialize);

var geocoder = new google.maps.Geocoder();

function createMarkers() {
    for (var i = 0; i < temp.length; ++i) {
        (function (address) {
            geocoder.geocode({
                'address': address
            }, function (results) {
                var marker = new google.maps.Marker({
                    map: map,
                    position: results[0].geometry.location,
                    title: address
                });

                google.maps.event.addListener(marker, 'click', function () {
                    alert(address);
                    //window.open('infomonde.php?icao=' + address + '&language=fr', 'Informations météo', config = 'height=400, width=850, toolbar=no, menubar=no, scrollbars=no, resizable=no, location=no, directories=no, status=no')
                });
            });
        })(temp[i]);
    }
}