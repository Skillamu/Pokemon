using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Regirock : IPokemon
    {
        public int Health { get; set; }

        public Regirock()
        {
            Health = 100;
        }

        public void StoneEdge(IPokemon otherPokemon)
        {
            otherPokemon.LooseHealth(15);
        }

        public void Attack(IPokemon otherPokemon)
        {
            StoneEdge(otherPokemon);
        }

        public void LooseHealth(int attackDmg)
        {
            Health -= attackDmg;
        }
    }
}
