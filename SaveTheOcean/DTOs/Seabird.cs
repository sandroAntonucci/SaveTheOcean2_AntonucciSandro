using System;


namespace SaveTheOcean.DTOs
{
    public class Seabird : AAnimal
    {

        // Constructor de major càrrega lògica
        public Seabird(string name, string superFamily, string species, double weight) : base(name, superFamily, species, weight) { }

        // Constructor sense paràmetres 
        public Seabird() : base("Pingu", "Ave Marina", "Pingüino", 20) { }

        /// <summary>
        /// Métode que retorna el grau d'afectació després de l'aplicació del tractament
        /// </summary>
        /// <returns>Retorna el grau d'afectació amb la fórmula de la au marina0 depenent si es cura en la localització o es trasllada al CRAM</returns>
        public override int ApplyTreatment(bool onLocation, int GA)
        {
            const int CureOnLocation = 5, Five = 5;

            // Es cambia la fórmula del càlcul respecte a la pràctica ja que dona valors negatius
            return onLocation ? (GA - CureOnLocation)/Five : GA / Five;
        }

    }
}
