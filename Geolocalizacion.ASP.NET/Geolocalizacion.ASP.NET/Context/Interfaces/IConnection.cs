using System.Data;

namespace Geolocalizacion.ASP.NET.Context.Interfaces
{
    public interface IConnection
    {
        IDbConnection GetConnectionUbicaciones { get; }
    }
}
