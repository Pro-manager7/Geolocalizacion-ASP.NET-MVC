using Dapper;
using Geolocalizacion.ASP.NET.Context.Interfaces;
using Geolocalizacion.ASP.NET.Dto.Home.Response;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Geolocalizacion.ASP.NET.Context.Main
{
    public class HomeContext : IHomeContext
    {
        #region [Properties]
        private readonly IConnection _connection;
        #endregion

        #region [Constructor]
        public HomeContext(IConnection connection)
        {
            _connection = connection;
        }
        #endregion

        #region [Ubicaciones]
        /// <summary>
        /// Metodo que obtiene todas las ubicaciones.
        /// </summary>
        public IList<LocationGeocoordinateResponse> GetAllUbicaciones()
        {
            using (var connection = _connection.GetConnectionUbicaciones)
            {
                const string procedure = @"SELECT Latitude  AS Latitude,
                                                  Longitude AS Longitude

                                           FROM Location";

                var response = connection.Query<LocationGeocoordinateResponse>(procedure, commandType: CommandType.Text);
                return response.ToList();

            }
        }
        #endregion

    }
}
