using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class Lanche : ItemCardapio
    {
        List<string> ingredientesExtras = new List<string>();
        List<string> listaLanches = new List<string>();
        public Lanche(int codigo, string descricao, decimal precoBase) :
            base(codigo, descricao, precoBase)
        {
            ingredientesExtras = new List<string>();
            listaLanches = new List<string> ();
        }

        public void MenuLanches()
        {
            Console.WriteLine("1- X-Bacon");
            Console.WriteLine("2- x-ovo");
            Console.WriteLine("3- hamburguer");
            Console.WriteLine("4- bebida");
            string inputOpcao = Console.ReadLine();

            int.TryParse(inputOpcao, out int opcao);

            listaLanches.Add(inputOpcao);

            switch (opcao)
            {
                case 1:
                    this.Descricao = "X-Bacon";
                    this.PrecoBase = 18.00m;
                    break;
                case 2:
                    this.Descricao = "X-Ovo";
                    this.PrecoBase = 15.00m;
                    break;
                case 3:
                    this.Descricao = "Hambúrguer";
                    this.PrecoBase = 12.00m;
                    break;
                case 4:
                    Bebida bebida = new Bebida(02, "bebida", 15m);
                    bebida.MenuBebida();
                    break;
                case 5:
                    Console.WriteLine("Saindo do menu de lanches...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    this.Descricao = "Hambúrguer";
                    this.PrecoBase = 12.00m;
                    break;
            }

            Console.Write("Deseja adicionar algum ingrediente extra ou bebida?(extra/sair) ");
            string resposta = Console.ReadLine();

            

            while(resposta == "extra")
            {
                Console.Write("Digite o ingrediente extra: ");
                string ingredienteExtra = Console.ReadLine();
                AdicionarExtra(ingredienteExtra);

                

                Console.Write("Deseja adicionar mais algum ingrediente extra? (extra/sair) ");
                resposta = Console.ReadLine();

                }

            if (resposta == "sair")
            {
                Program.MenuPrincipal();
            }

        }


        public void AdicionarExtra(string ingreditente)
        {
            ingredientesExtras.Add(ingreditente);

        }



        public override decimal CalcularPrecoFinal()
        {
            decimal valorExtra = ingredientesExtras.Count * 3.50m;
            Console.WriteLine($"pedidos:");
            Console.WriteLine($"preco lanche:{PrecoBase} || preco total extras: {valorExtra}");
            return PrecoBase + valorExtra;
        }
    }
}


