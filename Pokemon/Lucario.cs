using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Lucario : IPokemon
    {
        public int Health { get; private set; }

        public Lucario()
        {
            Health = 80;
        }

        private void ForcePalm(IPokemon otherPokemon)
        {
            otherPokemon.LooseHealth(20);
        }

        public void Attack(IPokemon otherPokemon)
        {
            ForcePalm(otherPokemon);
            Console.WriteLine("Lucario used it's force palm attack");
        }

        public void LooseHealth(int attackDmg)
        {
            Health -= attackDmg;
        }
    }
}
