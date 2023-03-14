ns('Geolocalizacion.ASP.NET.Home.Index');

try {    
   
    $(document).ready(function () {

        'use strict';
        Geolocalizacion.ASP.NET.Home.Index.Page = new Geolocalizacion.ASP.NET.Home.Index.Controller();
        Geolocalizacion.ASP.NET.Home.Index.Page.Ini();
    });

} catch (ex) {
    alert(ex.message);
}