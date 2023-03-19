ns('Geolocalizacion.ASP.NET.Home.Index.Controller');

Geolocalizacion.ASP.NET.Home.Index.Controller = function () {

    var base = this;

    base.Ini = function (opts) {
        'use strict';
      
        base.Function.InicializarMap();
    };

    base.Parameters = {


    };

    base.Variable = {

        Map:"",

        Constante: {

        },
    };

    base.Resource = {

    };

    base.Control = {

    };

    base.Event = {


    };

    base.Ajax = {


    };

    base.Function = {

        InicializarMap: function () {
          
            //base.Variable.Map = L.map('map').setView([-12.088510235296708, -7700491720151199],17);

            ////Agregar tilelAyer mapa base desde openstreetmap
            //L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            //    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
            //}).addTo(base.Variable.Map);


            //Creamos un objeto de tipo LatLng
            //var markerLocation = new L.LatLng(latitud, longitud);

            //Asignamos la imagen del icono
            //var markerIcon = L.icon({
            //    iconUrl: UrlContent + 'Images/Areas/Operaciones/MonitoreoOperativo/UbicacionServicio/CarritoServicio.png',
            //    iconSize: [30, 30],
            //});

            //Agregamos el texto cuando se hace click en el icono del mapa.
            //var fechaUltimaActulizacion = pListaServicioPlaca[servicioPlaca].FechaUltimaActualizacionGps;
            //var nroPlaca = pListaServicioPlaca[servicioPlaca].NroPlaca;
            //var codigoServicio = pListaServicioPlaca[servicioPlaca].CodigoServicioDistribucion;
            //var anioServicio = pListaServicioPlaca[servicioPlaca].AnioServicioDistribucion;
            //var usuarioConductor = pListaServicioPlaca[servicioPlaca].Usuario;

            //var html =
            //    "<strong>Fecha última actualización:</strong>  " + fechaUltimaActulizacion + " </br>" +
            //    "<strong>Número Placa:</strong> " + nroPlaca + " </br >" +
            //    "<strong>Usuario:</strong> " + usuarioConductor + " </br >" +
            //    "<strong>Codigo Servicio:</strong> " + codigoServicio + " </br >" +
            //    "<strong>Año Servicio:</strong> " + anioServicio + " </br >";

            //Agregamos el icono al mapa.
            //var marker = new L.Marker(markerLocation, { icon: markerIcon }).bindPopup(html).addTo(map);
            //var marker = new L.Marker(markerLocation).addTo(base.Variable.Map);

        },

    };

    base.Validation = {


    };
}