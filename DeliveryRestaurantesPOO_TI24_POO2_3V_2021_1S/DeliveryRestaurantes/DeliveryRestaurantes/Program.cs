using System;
using System.Collections.Generic;

namespace DeliveryRestaurantes
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantesRegiao regLondrina = new RestaurantesRegiao("Londrina");

            Restaurante r1 = new Restaurante("Comida Mineirinha", "Rua Belém", "123456");
            Produto p1 = new Produto("PF de feijoada", "500g de pura feijoada", 15f);
            Produto p2 = new Produto("Marmita Média", "Marmita de 400g variada", 12.50f);
            r1.cardapio.adicionarProduto(p1);
            r1.cardapio.adicionarProduto(p2);
            regLondrina.adicionarRestaurante(r1);

            Restaurante r2 = new Restaurante("Comida Japonesa", "Rua Amapá", "23456789");
            Produto p3 = new Produto("Temaki", "Temaki de salmão", 12f);
            Produto p4 = new Produto("Sushi", "12 peças de sushi variados", 15.50f);
            r2.cardapio.adicionarProduto(p3);
            r2.cardapio.adicionarProduto(p4);
            regLondrina.adicionarRestaurante(r2);

            RestaurantesRegiao regMaringa = new RestaurantesRegiao("Maringa");

            Restaurante r3 = new Restaurante("Casa da jeleia", "Rua amapa", "75456564");
            Produto p5 = new Produto("jeleia de morango", "geleia de morango meio kilo", 25f);
            Produto p6 = new Produto("jeleia de uva", "geleia de uva meio kilo", 20f);
            r3.cardapio.adicionarProduto(p5);
            r3.cardapio.adicionarProduto(p6);
            regMaringa.adicionarRestaurante(r3);

            Restaurante r4 = new Restaurante("granja ovos frescos", "Alameda dos perdidos", "6454654");
            Produto p7 = new Produto("ovo vermelho duzia", "12 ovos qualidade vermelha", 5f);
            Produto p8 = new Produto("ovo de codorna duzia", "12 ovos de tipo codorna", 10f);
            r4.cardapio.adicionarProduto(p7);
            r4.cardapio.adicionarProduto(p8);
            regMaringa.adicionarRestaurante(r4);

            regLondrina.mostrarRestaurantes();
            r1.mostrarCardapio();
            regMaringa.mostrarRestaurantes();
            r3.mostrarCardapio();
            r4.mostrarCardapio();
        }
    }
}
