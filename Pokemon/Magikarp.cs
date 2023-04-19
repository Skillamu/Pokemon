using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public int Health { get; private set; }
        public bool IsUseless { get; }

        public Magikarp()
        {
            Health = 50;
            IsUseless = true; // literally useless
        }

        public void Splash(IPokemon otherPokemon)
        {
            otherPokemon.LooseHealth(5);
        }

        public void Attack(IPokemon otherPokemon)
        {
            Splash(otherPokemon);
            Console.WriteLine("Magikarp used it's splash attack");
        }

        public void LooseHealth(int attackDmg)
        {
            Health -= attackDmg;
        }
    }
}
