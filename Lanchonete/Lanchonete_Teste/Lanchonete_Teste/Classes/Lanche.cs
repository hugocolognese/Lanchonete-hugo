using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class Lanche : ItemCardapio
    {
        List<string> ingredientesExtras = new List<string>();

        public Lanche(int codigo, string descricao, decimal precoBase) :
            base(codigo, descricao, precoBase)
        {
            ingredientesExtras = new List<string>();
        }

        public void MenuLanches()
        {
            Console.WriteLine("1- X-Bacon");
            Console.WriteLine("2- x-ovo");
            Console.WriteLine("3- hamburguer");
            string inputOpcao = Console.ReadLine();

            int.TryParse(inputOpcao, out int opcao);


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
                default:
                    Console.WriteLine("Opção inválida!");
                    this.Descricao = "Hambúrguer";
                    this.PrecoBase = 12.00m;
                    break;
            }

            Console.Write("Deseja adicionar algum ingrediente extra por R$ 3,50 cada? (sim/nao): ");
            string querExtra = Console.ReadLine();

            while (querExtra == "sim")
            {
                Console.Write("Digite o nome do ingrediente extra: ");
                string ingrediente = Console.ReadLine();

                // Chamamos o método que criaste
                AdicionarExtra(ingrediente);

                Console.Write("Deseja adicionar mais algum extra? (sim/nao): ");
                querExtra = Console.ReadLine();
            }
        }


        public void AdicionarExtra(string ingreditente)
        {
            ingredientesExtras.Add(ingreditente);

        }



        public override decimal CalcularPrecoFinal()
        {
            decimal valorExtra = ingredientesExtras.Count * 3.50m;
            Console.WriteLine($"preco lanche:{PrecoBase} || preco total extras: {valorExtra}");
            return PrecoBase + valorExtra;
        }
    }
}


