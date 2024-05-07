using System;

namespace SaveTheOcean.DTOs
{
    public class Player
    {

        const int Zero = 0, Technical = 1, Vet = 2, TecXP = 45, VetXP = 80;

        public string Name { get; set; }
        public int RewardXP { get; set; }
        public int XP { get; set; }


        public Player(string name, int rewardXP, int xp) 
        { 
            Name = name;
            RewardXP = rewardXP;
            XP = xp;
        }

        public Player(string name, int roleType)
        {
            Name = name;

            // El roletype ens indica si es técnic o veterinari i s'assignen les recompenses d'XP depenent del rol
            if (roleType == Technical) RewardXP = TecXP;
            else if (roleType == Vet) RewardXP = VetXP; 

            XP = Zero;
        }

        public Player()
        {
            Name = "Jugador";
            RewardXP = Zero;
            XP = Zero;
        }

    }
}
