using System;
using System.Collections.Generic;
using System.Threading;

namespace Lanchonete_Teste.Classes
{
    public class Lanche : ItemCardapio
    {
        private List<string> ingredientesExtras = new List<string>();
        public Lanche(int codigo, string descricao, decimal precoBase) :
            base(codigo, descricao, precoBase)
        {
        }

        public void MenuLanches()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - X-Bacon (R$ 18,00)");
                Console.WriteLine("2 - X-Ovo (R$ 15,00)");
                Console.WriteLine("3 - Hambúrguer (R$ 12,00)");
                Console.Write("Escolha o lanche pelo numero: ");

                char opcao = Console.ReadKey(true).KeyChar;
                switch (opcao)
                {
                    case '1':
                        Descricao = "X-Bacon";
                        PrecoBase = 18m;
                        break;
                    case '2':
                        Descricao = "X-Ovo";
                        PrecoBase = 15m;
                        break;
                    case '3':
                        Descricao = "Hambúrguer";
                        PrecoBase = 12m;
                        break;
                    default:
                        Console.WriteLine("Tente novamente.");
                        continue;
                }

                break;
            }

            bool adicionarMais = true;
            while (adicionarMais)
            {
                Console.Clear();
                Console.WriteLine("Ingrediente extra - R$ 3,50 cada");
                Console.WriteLine("1 - Queijo");
                Console.WriteLine("2 - Bacon");
                Console.WriteLine("3 - Ovo");
                Console.WriteLine("0 - Continuar sem mais extras");
                Console.Write("Escolha uma tecla: ");

                char opcaoExtra = Console.ReadKey(true).KeyChar;
                switch (opcaoExtra)
                {
                    case '1':
                        AdicionarExtra("Queijo");
                        Console.WriteLine("Queijo adicionado.");
                        Thread.Sleep(2000);
                        break;
                    case '2':
                        AdicionarExtra("Bacon");
                        Console.WriteLine("Bacon adicionado.");
                        Thread.Sleep(2000);
                        break;
                    case '3':
                        AdicionarExtra("Ovo");
                        Console.WriteLine("Ovo adicionado.");
                        Thread.Sleep(2000);
                        break;
                    case '0':
                        adicionarMais = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }

        public void AdicionarExtra(string ingrediente)
        {
            ingredientesExtras.Add(ingrediente);
        }

        public override decimal CalcularPrecoFinal()
        {
            return PrecoBase + ingredientesExtras.Count * 3.50m;
        }
    }
}


