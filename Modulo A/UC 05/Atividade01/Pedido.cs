using System.Collections.Generic;

namespace Atividade1
{
    public class Pedido
    {
        private List<ItemPedido> lista = new List<ItemPedido>();

        public void adicionar(ItemPedido pedido){
            lista.Add(pedido);
        }

        public double totalizar(){
            double total = 0;
            for(int i = 0; i < lista.Count; i++){
                total = total + lista[i].valor_unitario * lista[i].quantidade;
            }
            
            return total;
        }
    }
}