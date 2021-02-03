using System;

namespace ClientePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia cliente 1
            Cliente c1 = new Cliente("Fabio", "Rua Y", 30);
            //Chama metodo get idade do cliente 1
            Console.WriteLine("Idade do c1: " + c1.Idade);
            //Set idade - modifica valor da var privada
            c1.Idade = 20;
            //Chama metodo get idade do cliente 1
            Console.WriteLine("Idade do c1: " + c1.Idade);
            c1.MostraDados();
            //Cliente 2
            Cliente c2 = new Cliente("Jonas", "Rua K", 19);
            c2.MostraDados();    
        }
    }
}
