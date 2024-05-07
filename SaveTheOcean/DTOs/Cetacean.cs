using System;


namespace SaveTheOcean.DTOs
{
    public class Cetacean : AAnimal
    {

        // Constructor de major càrrega lògica
        public Cetacean(string name, string superFamily, string species, double weight) : base(name, superFamily, species, weight) { }

        // Constructor sense paràmetres 
        public Cetacean() : base("Oumou", "Cetáceo", "Delfín", 20.5) { }

        /// <summary>
        /// Métode que retorna el grau d'afectació després de l'aplicació del tractament
        /// </summary>
        /// <returns>Retorna el grau d'afectació amb la fórmula del cetaci depenent si es cura en la localització o es trasllada al CRAM</returns>
        public override int ApplyTreatment(bool onLocation, int GA)
        {
            const int CureOnLocation = 50, Five = 5;
            return onLocation ? GA - (GA / Five) - CureOnLocation : GA - (GA / Five);
        }
    }
}
