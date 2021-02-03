using System;

namespace ListaDeContatosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contatos = new string[5];

            contatos[0] = "Maria";
            contatos[1] = "João";
            contatos[2] = "Arthur";
            contatos[3] = "Fernando";
            contatos[4] = "Júlia";
            
            for(int i = 0; i < contatos.Length; i++)
            {
                Console.WriteLine("Contato " + (i+1) + ": " + contatos[i]);
            }
        }
    }
}
