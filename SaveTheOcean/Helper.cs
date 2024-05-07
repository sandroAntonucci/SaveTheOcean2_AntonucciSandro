using SaveTheOcean.DTOs;


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SaveTheOcean
{
    public static class Helper
    {

        const int Zero = 0, One = 1, Two = 2, Three = 3;

        /// <summary>
        /// Mètode que genera un animal aleatori i el retorna
        /// </summary>
        /// <returns>Retorna un animal aleatori (o cetaci, o tortuga, o au marina)</returns>
        public static AAnimal GenerateRandomAnimal()
        {
            AAnimal animalToRescue;
            int randomAnimal = GenerateRandom(One, Three);

            if (randomAnimal == One)
            {
                animalToRescue = new Turtle();
            }
            else if (randomAnimal == Two)
            {
                animalToRescue = new Cetacean();
            }
            else
            {
                animalToRescue = new Seabird();
            }

            return animalToRescue;
        }

        /// <summary>
        /// Mètode que retorna un valor aleatori entre min i max
        /// </summary>
        /// <param name="min">Valor mínim</param>
        /// <param name="max">Valor màxim</param>
        /// <returns>Retorna un valor aleatori entre min i max (inclosos)</returns>
        public static int GenerateRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + One);
        }

        /// <summary>
        /// Mètode que guarda les dades de la partida en un XML
        /// </summary>
        /// <param name="currentPlayer">Jugador</param>
        /// <param name="rescue">Rescat</param>
        /// <param name="animal">Animal</param>

        public static void SavePlayerData(Player currentPlayer, RescueDTO rescue, AAnimal animal)
        {
            string xmlFilePath = "../../../rescues.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            XmlElement rescueElement = doc.CreateElement("rescue");

            rescueElement.AppendChild(doc.CreateElement("playerName")).InnerText = currentPlayer.Name;
            rescueElement.AppendChild(doc.CreateElement("playerXP")).InnerText = currentPlayer.XP.ToString();
            rescueElement.AppendChild(doc.CreateElement("RES")).InnerText = rescue.NRescue;
            rescueElement.AppendChild(doc.CreateElement("rescueDate")).InnerText = rescue.Date.ToString();
            rescueElement.AppendChild(doc.CreateElement("rescueSpecies")).InnerText = rescue.Species;
            rescueElement.AppendChild(doc.CreateElement("rescueGA")).InnerText = rescue.GA.ToString();
            rescueElement.AppendChild(doc.CreateElement("rescueLocation")).InnerText = rescue.Location;
            rescueElement.AppendChild(doc.CreateElement("animalName")).InnerText = animal.Name;
            rescueElement.AppendChild(doc.CreateElement("animalSuperFamily")).InnerText = animal.SuperFamily;
            rescueElement.AppendChild(doc.CreateElement("animalSpecies")).InnerText = animal.Species;
            rescueElement.AppendChild(doc.CreateElement("animalWeight")).InnerText = animal.Weight.ToString();

            doc.DocumentElement.AppendChild(rescueElement);

            doc.Save(xmlFilePath);
        }
    }
}
