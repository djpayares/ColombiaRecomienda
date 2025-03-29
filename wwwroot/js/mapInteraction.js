// wwwroot/js/mapInteraction.js
window.highlightCity = function (cityId) {
    // Resetear todos los puntos a su color original
    document.querySelectorAll('.city-point').forEach(function (element) {
        element.style.fill = '#3498db';
        element.setAttribute('r', '10');
    });

    // Destacar la ciudad seleccionada
    let cityElement;
    switch (cityId) {
        case 1:
            cityElement = document.querySelector('#bogota .city-point');
            break;
        case 2:
            cityElement = document.querySelector('#medellin .city-point');
            break;
        case 3:
            cityElement = document.querySelector('#cali .city-point');
            break;
        case 4:
            cityElement = document.querySelector('#cartagena .city-point');
            break;
    }

    if (cityElement) {
        cityElement.style.fill = '#e74c3c';
        cityElement.setAttribute('r', '15');
    }

    function handleClick(regionName) {
        DotNet.invokeMethodAsync('BlazorMapaColombia', 'HandleClick', regionName);
    }
}