using System.Security.Cryptography.X509Certificates;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var element = Elements.Fire;
            if (element == Elements.Fire)
            {
                Console.WriteLine(element.ToString());
            }
            else
            {
                Console.WriteLine("This is not fire");
            }

            var Fire = new FireType();

            Pokemon Charmander = new Pokemon(100, "Charmander", Fire);

            Console.WriteLine(Charmander.ToString());

        }
    }


}
