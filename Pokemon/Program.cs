namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regirock = new Regirock();
            var magikarp = new Magikarp();

            regirock.Attack(magikarp);
            Console.WriteLine(magikarp.Health);
            magikarp.Attack(regirock);
            Console.WriteLine(regirock.Health);

            Console.ReadKey(true);
        }
    }
}