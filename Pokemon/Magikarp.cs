using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public int Health { get; set; }
        public bool IsUseless { get; set; }

        public Magikarp()
        {
            Health = 30;
            IsUseless = true; // literally useless
        }

        public void Splash(IPokemon otherPokemon)
        {
            otherPokemon.LooseHealth(5);
        }

        public void Attack(IPokemon otherPokemon)
        {
            Splash(otherPokemon);
        }

        public void LooseHealth(int attackDmg)
        {
            Health -= attackDmg;
        }
    }
}
