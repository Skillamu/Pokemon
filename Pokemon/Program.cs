namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var magikarp = new Magikarp();
            var wildPokemons = new WildPokemons();
            
            while (magikarp.Health > 0)
            {
                var pokemon = wildPokemons.GetWildPokemon();

                pokemon.Attack(magikarp);

                if (magikarp.Health <= 0) break;
                magikarp.Attack(pokemon);
            }

            Console.WriteLine("Magikarp is dead... x(");
            Console.ReadKey(true);
        }
    }
}