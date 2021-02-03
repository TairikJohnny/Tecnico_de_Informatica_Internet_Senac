using System;

namespace Mago
{
    public class Mago
    {
        private string nome;
        public int idade;
        private int poder;

        public Mago(string nomeMago, int poderMago)
        {
            nome = nomeMago;
            poder = poderMago;
        } 

        public void setNome(string n){
            nome = n;
        }

        public string GetNome()
        {
            return nome;
        }

        public void setPoder(int p){
            poder = p;
        }

        public int GetPoder()
        {
            return poder;
        }
        
        public void Atacar()
        {
            Console.WriteLine($"O mago {nome} está atacando!");
            Console.WriteLine($"Ele tem {poder} de poder");
        }
        public void Defender()
        {
            Console.WriteLine($"O mago {nome} está defendendo!");
        }
    }
}