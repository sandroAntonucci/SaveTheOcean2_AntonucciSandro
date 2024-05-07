using Npgsql;
using SaveTheOcean.DTOs;
using Microsoft.Extensions.Configuration;

namespace SaveTheOcean.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

    }
}
