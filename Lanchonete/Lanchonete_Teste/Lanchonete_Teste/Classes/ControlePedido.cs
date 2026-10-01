using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class ControlePedido
    {
        public List<ItemCardapio> itensPedido = new List<ItemCardapio>();

        public ControlePedido()
        {
            itensPedido = new List<ItemCardapio>();
        }

        public void AdicionarPedido(ItemCardapio item)
        {
            itensPedido.Add(item);
            Console.WriteLine("item adicionado no carrinho");
        }

        public void FecharPedido()
        {
            Console.Clear();

            Console.WriteLine("=============================================");
            Console.WriteLine("                 NOTA FISCAL                 ");
            Console.WriteLine("=============================================");
            Console.WriteLine(String.Format("{0,-30} | {1}", "PRODUTO", "PREÇO"));
            Console.WriteLine("---------------------------------------------");

            decimal totalGeral = 0;

            
            foreach (var item in itensPedido)
            {
                decimal precoItem = item.CalcularPrecoFinal();
                totalGeral += precoItem;

                string nomeProduto = item.Descricao;

                
                if (item is Bebida bebida)
                {
                    nomeProduto += $" ({bebida.Tamanho})";
                }

                
                Console.WriteLine( $"Nome: {nomeProduto} {precoItem}");

                Console.WriteLine("=============================");
                Console.WriteLine( "TOTAL A PAGAR", totalGeral);
                Console.WriteLine("=============================\n");

                
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Program.MenuPrincipal();
            }


        }
    }
}
