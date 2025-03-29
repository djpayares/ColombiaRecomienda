// Variables para el mapa y los marcadores
var map;
var markers = {};
var dotNetHelper;

// Función para inicializar el mapa
window.initializeMap = function (helper, cities) {
    dotNetHelper = helper;

    // Crear el mapa centrado en Colombia con un estilo visual más atractivo
    map = L.map('mapid', {
        center: [4.570868, -74.297333],
        zoom: 6,
        zoomControl: true,
        attributionControl: false
    });

    // Añadir capa de mapa con un estilo más elegante
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    // Crear un estilo de marcador más distintivo
    cities.forEach(function (city) {
        var cityIcon = L.divIcon({
            html: `
                <div class="custom-city-marker">
                    <div class="marker-pulse"></div>
                    <div class="marker-core">${city.name}</div>
                </div>
            `,
            className: 'custom-marker-container',
            iconSize: [60, 60],
            iconAnchor: [30, 30]
        });

        // Crear y añadir marcador con transiciones suaves
        var marker = L.marker([city.latitude, city.longitude], {
            icon: cityIcon,
            cityId: city.id
        }).addTo(map);

        // Popup con diseño mejorado
        marker.bindPopup(`
            <div class="custom-popup">
                <h3>${city.name}</h3>
                <p>${city.description}</p>
                <img src="${city.imagePath}" alt="${city.name}" class="popup-image">
            </div>
        `, {
            maxWidth: 300,
            minWidth: 250,
            className: 'custom-leaflet-popup'
        });

        // Añadir evento click con efecto visual
        marker.on('click', function () {
            // Efecto de resaltado
            Object.values(markers).forEach(function (m) {
                m._icon.classList.remove('marker-selected');
            });

            this._icon.classList.add('marker-selected');

            // Llamar al método de Blazor
            dotNetHelper.invokeMethodAsync('SelectCityFromJS', city.id);
        });

        // Guardar referencia al marcador
        markers[city.id] = marker;
    });

    // Polígono de Colombia con un estilo más suave
    var colombiaCoords = [
        [[4.6097, -74.0817], [6.2476, -75.5658], [3.4516, -76.5320], [10.3932, -75.4832], [4.6097, -74.0817]]
    ];

    L.polygon(colombiaCoords, {
        color: '#2ecc71',
        fillColor: '#2ecc71',
        fillOpacity: 0.1,
        weight: 2,
        dashArray: '5, 5'  // Línea punteada
    }).addTo(map);
};

// Función para resaltar una ciudad con mejor animación
window.highlightCity = function (cityId) {
    // Resetear todos los marcadores
    Object.values(markers).forEach(function (marker) {
        marker._icon.classList.remove('marker-selected');
    });

    // Resaltar el marcador seleccionado
    if (markers[cityId]) {
        markers[cityId]._icon.classList.add('marker-selected');
        markers[cityId].openPopup();

        // Centrar el mapa en la ciudad seleccionada
        map.setView(markers[cityId].getLatLng(), 8, {
            animate: true,
            duration: 1 // duración de la animación en segundos
        });
    }
};