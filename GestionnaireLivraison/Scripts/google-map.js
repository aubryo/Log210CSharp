var temp = [];
var map;
var selectedAdress;
var directionsDisplay;
var directionsService = new google.maps.DirectionsService();


function initialize() {
    var mapOptions = {
        center: new google.maps.LatLng(45.545793, -73.622818),
        zoom: 11
    };
    map = new google.maps.Map(document.getElementById("map_canvas"),
        mapOptions);

    if (getSelectedAdress() != null) {
        directionsDisplay = new google.maps.DirectionsRenderer();
        directionsDisplay.setMap(map);
        generateRoute();
    }
    else {
        createMarkers();
    }
    //directionsDisplay.setPanel(document.getElementById('directions')); Seulement si on doit afficher le trajet
    //directionsDisplay.suppressMarkers = true;
}

google.maps.event.addDomListener(window, 'load', initialize);

var geocoder = new google.maps.Geocoder();

function generateRoute() {
        var request = {
            origin: getLivreurAdresse(),
            destination: getSelectedAdress(),
            travelMode: google.maps.TravelMode.DRIVING
        };
        directionsService.route(request, function (result, status) {
            if (status == google.maps.DirectionsStatus.OK) {
                directionsDisplay.setDirections(result);
            }
        });
}

function getLivreurAdresse() {
    var lNumRue = document.getElementsByName("lNumRue")[0].innerHTML;
    var lNomRue = document.getElementsByName('lNomRue')[0].innerHTML;
    var lCodePostal = document.getElementsByName('lCodePostal')[0].innerHTML;
    var aLivreur = lNumRue + " " + lNomRue + lCodePostal;
    return aLivreur;
}

function getSelectedAdress() {
    var selectedAdress = document.getElementsByName('selectedAdresse');
    if (selectedAdress.length != 0) {
        return selectedAdress[0].innerHTML;
    }
    else {
        return null;
    }
}

function createMarkers() {
    temp.push(getLivreurAdresse());
    if (getSelectedAdress() != null) {
        temp.push(getSelectedAdress());
    }

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