using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class ControlePedido
    {
        public List<ItemCardapio> itensLanche = new List<ItemCardapio>();

        public ControlePedido()
        {
            itensLanche = new List<ItemCardapio>();
        }

        public void AdicionarPedido(ItemCardapio item)
        {
            itensLanche.Add(item);
            Console.WriteLine("item adicionado no carrinho");
        }

        public void FecharPedido()
        {
            decimal total = 0;
            Console.WriteLine("PEDIDO");

            foreach(var item in itensLanche)
            {
                if (item is Lanche lanche)
                {
                    Console.WriteLine($"lanche: {lanche.Descricao} preco: {lanche.CalcularPrecoFinal()}");
                }
                else if (item is Bebida bebida)
                {
                    Console.WriteLine($"bebida: {bebida.Descricao} preco: {bebida.CalcularPrecoFinal()}");
                }
            }

    }
}
}
