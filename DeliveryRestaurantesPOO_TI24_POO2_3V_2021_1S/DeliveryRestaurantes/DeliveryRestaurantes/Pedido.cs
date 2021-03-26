using System;
using System.Collections.Generic;
using System.Text;
namespace DeliveryRestaurantes
{
    class Pedido
    {
        public List<Pedido> produtos;
        public bool entrege;

        public Pedido()
        {
            this.produtos = new List<Pedido>();
        }
        public void adicionarProdutoPedido(Pedido pe)
        {
            produtos.Add(pe);
        }
        public bool removerProdutoPedido(Pedido pe)
        {
            return produtos.Remove(pe);
        }
        
        public void entregarPedido(){
            entrege = true;
        }



    }
}