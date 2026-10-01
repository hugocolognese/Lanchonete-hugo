using System;

namespace Lanchonete_Teste.Classes
{
    public class Bebida : ItemCardapio
    {
        public string Tamanho { get; set; } = "300ml";

        public Bebida(int codigo, string descricao, decimal precoBase) : 
            base(codigo, descricao, precoBase)
        {
        }

        public void MenuBebida()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Morango (R$ 18,00)");
                Console.WriteLine("2 - Manga (R$ 15,00)");
                Console.WriteLine("3 - Uva (R$ 12,00)");
                Console.Write("Escolha a bebida pela tecla correspondente: ");

                char opcao = Console.ReadKey(true).KeyChar;
                if (opcao == '1')
                {
                    Descricao = "Suco de Morango";
                    PrecoBase = 18m;
                    break;
                }
                else if (opcao == '2')
                {
                    Descricao = "Suco de Manga";
                    PrecoBase = 15m;
                    break;
                }
                else if (opcao == '3')
                {
                    Descricao = "Suco de Uva";
                    PrecoBase = 12m;
                    break;
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tamanho: 1 - 300ml (sem acréscimo), 2 - 500ml (+ R$ 3,00), 3 - 1L (+ R$ 6,00)");
                Console.Write("Escolha o tamanho pela tecla correspondente: ");
                char tamanho = Console.ReadKey(true).KeyChar;
                if (tamanho == '1')
                {
                    Tamanho = "300ml";
                    break;
                }
                else if (tamanho == '2')
                {
                    Tamanho = "500ml";
                    break;
                }
                else if (tamanho == '3')
                {
                    Tamanho = "1L";
                    break;
                }
            }
        }

        public override decimal CalcularPrecoFinal()
        {
            decimal precoFinal = PrecoBase;
            if (Tamanho == "500ml")
            {
                precoFinal = precoFinal + 3m;
            }
            else if (Tamanho == "1L")
            {
                precoFinal = precoFinal + 6m;
            }

            return precoFinal;
        }
    }
}
