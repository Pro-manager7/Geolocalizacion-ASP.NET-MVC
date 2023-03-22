ns('Geolocalizacion.ASP.NET.Home.Index.Controller');

Geolocalizacion.ASP.NET.Home.Index.Controller = function () {

    var base = this;

    base.Ini = function (opts) {
        'use strict';
        debugger;
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
            debugger;

            var map = L.map('map').setView([-12.04619962493953, -77.04353134031399], 13);

            //Agregar tilelAyer mapa base desde openstreetmap
            L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
                maxZoom: 19,
                attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
            }).addTo(map);

            var marker = L.marker([-12.04619962493953, -77.04353134031399]).addTo(map);
            var marker2 = L.marker([-09.04619962493953, -70.04353134031399]).addTo(map);
        },

    };

    base.Validation = {

    };
}