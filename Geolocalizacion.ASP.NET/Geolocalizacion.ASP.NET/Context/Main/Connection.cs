using Geolocalizacion.ASP.NET.Context.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Geolocalizacion.ASP.NET.Context.Main
{
    public class Connection : IConnection
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<Connection> _logger;

        public Connection(IConfiguration configuration, ILogger<Connection> logger)
        {
            _configuration = configuration;
            _logger = logger;   
        }

        public IDbConnection GetConnectionUbicaciones
        {
            get { return GetConnection(_configuration.GetConnectionString("BDUbicaciones")); }
        }

        public IDbConnection GetConnection(string pDataBase)
        {
            var connection = new SqlConnection();

            try
            {
                if (connection == null) return null;

                connection.ConnectionString = pDataBase;
                connection.Open();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error: " + ex.Message.ToString());
            }
            return connection;
        }
    }
}
