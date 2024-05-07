using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SaveTheOcean.DTOs;
using SaveTheOcean.Persistence.DAO;

namespace SaveTheOcean.Persistence.Mapping
{
    public class RescueDAO : IRescueDAO
    {

        private readonly string connectionString;

        public RescueDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public RescueDTO GetRescueById(int id)
        {

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM rescues WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var dateValue = (DateTime)reader["date"];
                            var dateOnly = dateValue.Date; // Extraer solo la parte de la fecha

                            return new RescueDTO
                            {
                                ID = (int)reader["id"],
                                NRescue = reader["nrescue"].ToString(),
                                Date = new DateOnly(dateOnly.Year, dateOnly.Month, dateOnly.Day), // Convertir a DateOnly
                                Species = reader["species"].ToString(),
                                GA = (int)reader["ga"],
                                Location = reader["location"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public IEnumerable<RescueDTO> GetAllRescues()
        {
            List<RescueDTO> rescues = new List<RescueDTO>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM rescues", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dateValue = (DateTime)reader["date"];
                            var dateOnly = dateValue.Date; // Extraer solo la parte de la fecha

                            rescues.Add(new RescueDTO
                            {
                                ID = (int)reader["id"],
                                NRescue = reader["nrescue"].ToString(),
                                Date = new DateOnly(dateOnly.Year, dateOnly.Month, dateOnly.Day), // Convertir a DateOnly
                                Species = reader["species"].ToString(),
                                GA = (int)reader["ga"],
                                Location = reader["location"].ToString()
                            });
                        }
                    }
                }
            }

            return rescues;
        }

        public void InsertRescue(RescueDTO rescue)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("INSERT INTO rescues (nrescue, date, species, ga, location) VALUES (@nrescue, @date, @species, @ga, @location)", connection))
                {
                    command.Parameters.AddWithValue("NRescue", rescue.NRescue);
                    command.Parameters.AddWithValue("Date", rescue.Date);
                    command.Parameters.AddWithValue("Species", rescue.Species);
                    command.Parameters.AddWithValue("GA", rescue.GA);
                    command.Parameters.AddWithValue("Location", rescue.Location);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
