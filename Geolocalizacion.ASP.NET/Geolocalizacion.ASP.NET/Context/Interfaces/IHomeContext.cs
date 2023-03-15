using Geolocalizacion.ASP.NET.Dto.Home.Response;
using System.Collections.Generic;

namespace Geolocalizacion.ASP.NET.Context.Interfaces
{
    public interface IHomeContext
    {
        public IList<LocationGeocoordinateResponse> GetAllUbicaciones();
    }
}
