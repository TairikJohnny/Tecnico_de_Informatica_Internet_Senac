using System.Collections.Generic;

namespace atividade02.Models
{
    public class Pedido
    {
        public static List<ItemPedido> item;

        static Pedido(){
            item = new List<ItemPedido>();
        }

        public void Cadastrar(ItemPedido pedido){
            item.Add(pedido);
        }

        public List<ItemPedido> Listar(){
            return item;
        }

        public double Totalizar(){
            double total = 0;

            foreach (ItemPedido x in item)
            {
                total = total + (x.Valor_unitario * x.Quantidade);
            }

            return total;
        }
    }
}