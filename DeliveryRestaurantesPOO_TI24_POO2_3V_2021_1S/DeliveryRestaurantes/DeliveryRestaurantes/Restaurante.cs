using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryRestaurantes
{
    class Restaurante
    {
        public string nome, endereco, cnpj;
        public Cardapio cardapio;
        public Pedido pedido;
        
        public Restaurante(string nome, string endereco, string cnpj)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cnpj = cnpj;
            this.cardapio = new Cardapio();
        }
        public bool aceitaPedido(List<Produto> p)
        {
            if (p.Count > 0 && p.Count <= 5) return true;
            return false;
        }
        public void mostrarCardapio()
        {
            Console.WriteLine($"=====Cardápio do restaurante {nome}=======");
            foreach(Produto p in cardapio.produtos)
            {
                Console.WriteLine($"{p.nome} {p.descricao} {p.valor}");
            }
            Console.WriteLine();
        }
        public void adicionarProduto(Produto p)
        {
            this.cardapio.adicionarProduto(p);
        }
        public void removerProduto(Produto p){
            this.cardapio.removerProduto(p);
        }
        public void adicionarProdutoPedido(Pedido pe)
        {
            this.pedido.adicionarProdutoPedido(pe);
        }
        public void removerPedido(Pedido pe){
            this.pedido.removerProdutoPedido(pe);
        }

        public void status(Pedido pe){
            if(pe.entrege)Console.WriteLine("produto entrege");
            else Console.WriteLine("não entrege");
            
        }
    }
}
