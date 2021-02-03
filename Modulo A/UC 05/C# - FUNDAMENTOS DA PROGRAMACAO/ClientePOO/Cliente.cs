using System;

namespace ClientePOO
{
    public class Cliente
    {
        //Atributos da classe cliente
        private string nome;
        private string endereco;
        private int idade; 
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public int Idade
        {
            get{ return idade; }
            set
            { 
                if(value > 0)
                    idade = value;
            }
        }
        //Construtor - chamado quando objeto e instanciado
        public Cliente(string novoNome, string novoEndereco, int novaIdade)
        {
            nome = novoNome;
            endereco = novoEndereco;
            Idade = novaIdade; //usando propriedade que faz validação
        }
        //Mostra dados do cliente
        public void MostraDados()
        {
            Console.WriteLine("Nome : " + nome);
            Console.WriteLine("Endereco : " + endereco);
            Console.WriteLine("Idade : " + idade);
        }
    }
}