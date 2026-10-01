using System;
using System.Collections.Generic;

namespace Lanchonete_Teste.Classes
{
    public class ControlePedido
    {
        private List<ItemCardapio> itens = new List<ItemCardapio>();

        public void AdicionarPedido(ItemCardapio item)
        {
            if (item == null)
            {
                throw new Exception("O campo não pode estar vazio.");
            }

            itens.Add(item);
        }

        public decimal ObterTotal()
        {
            decimal total = 0m;
            foreach (ItemCardapio item in itens)
            {
                total = total + item.CalcularPrecoFinal();
            }

            return total;
        }

        public void FecharPedido()
        {
            decimal total = 0m;

            Console.WriteLine("\n============== RESUMO DO PEDIDO ==============");
            if (itens.Count == 0)
            {
                Console.WriteLine("Nenhum item no pedido.");
            }

            foreach (ItemCardapio item in itens)
            {
                string descricao = item.Descricao;
                if (item is Bebida)
                {
                    Bebida bebida = (Bebida)item;
                    descricao = descricao + " (" + bebida.Tamanho + ")";
                }

                decimal preco = item.CalcularPrecoFinal();
                Console.WriteLine(descricao + ": " + preco.ToString("C2"));
                total = total + preco;
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("TOTAL A PAGAR: " + total.ToString("C2"));
            Console.WriteLine("==============================================\n");
        }

        public void Limpar()
        {
            itens.Clear();
        }
    }
}