using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryRestaurantes
{
    class RestaurantesRegiao
    {
        public string nomeRegiao;
        public List<Restaurante> restaurantes;

        public RestaurantesRegiao(string nomeRegiao)
        {
            this.nomeRegiao = nomeRegiao;
            this.restaurantes = new List<Restaurante>();
        }
        public void mostrarRestaurantes()
        {
            Console.WriteLine($"-----Restaurantes da região de {nomeRegiao}------");
            foreach (Restaurante r in restaurantes)
            {
                Console.WriteLine($"{r.nome} {r.endereco} {r.cnpj}");
            }
            Console.WriteLine();
        }
        public void adicionarRestaurante(Restaurante r)
        {
            this.restaurantes.Add(r);
        }
        public void removerRestaurante(Restaurante r){
            this.restaurantes.Remove(r);
        }            
            
    }
}
