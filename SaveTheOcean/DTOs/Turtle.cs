using System;


namespace SaveTheOcean.DTOs
{
    public class Turtle : AAnimal
    {

        // Constructor de major càrrega lògica
        public Turtle(string name, string superFamily, string species, double weight) : base(name, superFamily, species, weight) { }

        // Constructor sense paràmetres 
        public Turtle() : base("Valpa", "Tortuga marina", "Tortuga Careta", 7) { }

        /// <summary>
        /// Métode que retorna el grau d'afectació després de l'aplicació del tractament
        /// </summary>
        /// <returns>Retorna el grau d'afectació amb la fórmula de la tortuga depenent si es cura en la localització o es trasllada al CRAM</returns>
        public override int ApplyTreatment(bool onLocation, int GA)
        {
            const int Cure = 15, Three = 3, Two = 2, Twenty = 20;

            return (Two*GA + Three) - ((GA - Twenty)*Two) - Cure;
        }

    }
}