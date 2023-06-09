﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Regirock : IPokemon
    {
        public int Health { get; private set; }

        public Regirock()
        {
            Health = 120;
        }

        private void StoneEdge(IPokemon otherPokemon)
        {
            otherPokemon.LooseHealth(15);
        }

        public void Attack(IPokemon otherPokemon)
        {
            StoneEdge(otherPokemon);
            Console.WriteLine("Regirock used it's stone edge attack");
        }

        public void LooseHealth(int attackDmg)
        {
            Health -= attackDmg;
        }
    }
}
