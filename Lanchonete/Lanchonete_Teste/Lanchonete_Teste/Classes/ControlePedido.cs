using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class ControlePedido
    {
        public List<ItemCardapio> itens = new List<ItemCardapio>();

        public ControlePedido()
        {
            itens = new List<ItemCardapio>();
        }

        public void AdicionarPedido(ItemCardapio item)
        {
            itens.Add(item);
            Console.WriteLine("item adicionado no carrinho");
        }

        public void FecharPedido()
        {
            decimal total = 0;
            Console.WriteLine("PEDIDO");

            foreach (var item in itens)
            {
                decimal precoFinal = item.CalcularPrecoFinal();
                Console.WriteLine($"item: {item.Descricao}  preco: {precoFinal}");
                total += precoFinal;
            }

    }
}
}
