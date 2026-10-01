using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class ControlePedido
    {
        public List<ItemCardapio> itensLanche = new List<ItemCardapio>();
        public List<ItemCardapio> itensBebida = new List<ItemCardapio>();

        public ControlePedido()
        {
            itensLanche = new List<ItemCardapio>();
            itensBebida = new List<ItemCardapio>();
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
                              
                    Console.WriteLine($"lanche: {item.Descricao} preco: {item.CalcularPrecoFinal()}");
                
            }
            foreach (var item in itensBebida)
            {
                Console.WriteLine($"bebida: {item.Descricao} preco: {item.CalcularPrecoFinal()}");
            }


        }
}
}
