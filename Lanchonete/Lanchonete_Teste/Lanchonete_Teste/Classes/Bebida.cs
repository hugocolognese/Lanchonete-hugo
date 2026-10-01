using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class Bebida : ItemCardapio
    {
        public string Tamanho { get; set; }
        public Bebida(int codigo, string descricao, decimal precoBase) : 
            base(codigo, descricao, precoBase)
        {
            Tamanho = Tamanho;
        }

        public void MenuBebida()
        {
            Console.WriteLine("1- Morango");
            Console.WriteLine("2- Manga");
            Console.WriteLine("3- Uva");
            string inputOpcao = Console.ReadLine();

            int.TryParse(inputOpcao, out int opcao);


            switch (opcao)
            {
                case 1:
                    this.Descricao = "Morango";
                    this.PrecoBase = 18.00m;
                    break;
                case 2:
                    this.Descricao = "Manga";
                    this.PrecoBase = 15.00m;
                    break;
                case 3:
                    this.Descricao = "Uva";
                    this.PrecoBase = 12.00m;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    this.Descricao = "Uva";
                    this.PrecoBase = 12.00m;
                    break;
            }

            }

        public override decimal CalcularPrecoFinal()
        {
            if (Tamanho == "500ml") return PrecoBase + 3.00m;
            if (Tamanho == "1L") return PrecoBase + 6.00m;
            return PrecoBase;
        }
    }
}
