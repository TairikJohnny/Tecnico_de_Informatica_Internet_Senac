using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido lista = new Pedido();

            string resposta = "s";
            do{
                ItemPedido pedido = new ItemPedido();

                Console.WriteLine("Informe a descrição do pedido: ");
                pedido.descricao = Console.ReadLine();

                Console.WriteLine("Informe o valor unitario do pedido: ");
                pedido.valor_unitario = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do pedido: ");
                pedido.quantidade = Int32.Parse(Console.ReadLine());

                lista.adicionar(pedido);

                Console.WriteLine("Deseja inserir outro pedido? [s/n] ");
                resposta = Console.ReadLine();

                if(resposta == "n"){
                    Console.WriteLine("O total do pedido foi: R$ " + lista.totalizar());
                }

            } while(resposta == "s");
            
        }
    }
}
