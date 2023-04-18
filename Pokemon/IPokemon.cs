using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal interface IPokemon
    {
        int Health { get; set; }

        void Attack(IPokemon otherPokemon);
        void LooseHealth(int attackDmg);

    }
}
