using System;
namespace Mago
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago gand = new Mago("Gandalf", 100);
            Mago harry = new Mago("Harry Potter", 80);

            Console.WriteLine(gand.GetNome()); //Gandalf

            gand.setNome("Saruman");
            Console.WriteLine(gand.GetNome()); //Saruman    

            gand.idade = 300;

            harry.idade = 39;

            gand.Atacar();
            harry.Defender();
            harry.Atacar();
            gand.Defender();
        }
    }
} 