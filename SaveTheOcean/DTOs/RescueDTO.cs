using System;

namespace SaveTheOcean.DTOs
{
    public class RescueDTO
    {
        public int ID { get; set; }
        public string NRescue { get; set; }

        public DateOnly Date { get; set; }

        public string Species { get; set; }

        public int GA { get; set; }

        public string Location { get; set; }

        // Si només s'introdueix la superfamília, es generen els altres camps aleatòriament
        public RescueDTO(string species)
        {
            NRescue = GenerateResNum();
            Date = DateOnly.FromDateTime(DateTime.Now);
            Species = species;
            GA = GenerateGA();
            Location = GenerateLocation();
        }

        // Constructor sense paràmetres

        public RescueDTO()
        {
            NRescue = GenerateResNum();
            Date = DateOnly.FromDateTime(DateTime.Now);
            Species = "Tortuga Careta";
            GA = GenerateGA();
            Location = GenerateLocation();
        }


        /// <summary>
        /// Mètode que retorna un número de rescat aleatori entre 0 i 999 (inclosos)
        /// </summary>
        /// <returns>Retorna el número de rescat generat</returns>
        public string GenerateResNum()
        {
            Random random = new Random();
            return "RES" + random.Next(0, 1000);
        }

        /// <summary>
        /// Mètode que retorna un grau d'afectació aleatori entre 1 i 100 (inclosos)
        /// </summary>
        /// <returns>Retorna el grau d'afectació generat</returns>
        public int GenerateGA()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }

        /// <summary>
        /// Mètode que retorna una localització aleatòria entre Barcelona, Girona, Lleida i Tarragona
        /// </summary>
        /// <returns>Retorna una localització aleatòria</returns>
        public string GenerateLocation()
        {
            string[] Cities = { "Barcelona", "Girona", "Lleida", "Tarragona" };
            Random random = new Random();
            return Cities[random.Next(0, 4)];
        }
    }
}
