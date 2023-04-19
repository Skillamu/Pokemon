using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class WildPokemons
    {
        private Random _random;
        private List<IPokemon> _wildPokemons;

        public WildPokemons()
        {
            _random = new Random();
            _wildPokemons = new List<IPokemon>
            {
                new Regirock(),
                new Lucario(),
            };
        }

        public IPokemon GetWildPokemon()
        {
            var randomIndex = _random.Next(0, _wildPokemons.Count);
            var pokemon = _wildPokemons[randomIndex];
            return pokemon;
        }
    }
}
