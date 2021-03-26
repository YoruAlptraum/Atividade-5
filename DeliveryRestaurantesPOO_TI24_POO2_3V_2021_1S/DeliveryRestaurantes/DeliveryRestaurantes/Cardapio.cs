using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryRestaurantes
{
    class Cardapio
    {
        public List<Produto> produtos;
        public Cardapio()
        {
            this.produtos = new List<Produto>();
        }
        public void adicionarProduto(Produto p)
        {
            produtos.Add(p);
        }
        public bool removerProduto(Produto p)
        {
            return produtos.Remove(p);
        }
    }
}
