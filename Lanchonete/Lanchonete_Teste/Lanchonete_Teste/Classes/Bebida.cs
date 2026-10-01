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
            this.Descricao = Console.ReadLine();


            int.TryParse(this.Descricao, out int opcao);


            switch (opcao)
            {
                case 1:
                    this.Descricao = "Morango";
                    Console.WriteLine("qual o tamanho? (1l, 500ml, 300ml)");
                    this.Tamanho = Console.ReadLine();
                    this.Tamanho = "500ml";
                    this.Tamanho = "1L";
                    this.Tamanho = "300ml";
                    this.PrecoBase = 18.00m;
                    break;

                case 2:
                    Console.WriteLine("qual o tamanho? (1l, 500ml, 300ml)");
                    this.Tamanho = Console.ReadLine();
                    this.Tamanho = "500ml";
                    this.Tamanho = "1L";
                    this.Tamanho = "300ml";
                    this.Descricao = "Manga";
                    this.PrecoBase = 15.00m;
                    break;

                case 3:
                    Console.WriteLine("qual o tamanho? (1l, 500ml, 300ml)");
                    this.Tamanho = Console.ReadLine();
                    this.Tamanho = "500ml";
                    this.Tamanho = "1L";
                    this.Tamanho = "300ml";
                    this.Descricao = "Uva";
                    this.PrecoBase = 12.00m;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    this.Descricao = "Uva";
                    this.PrecoBase = 12.00m;
                    break;
            }

            Console.WriteLine("mais bebida?(sim/sair)");
            string resposta = Console.ReadLine();

            while(resposta == "sim")
            {
                Console.WriteLine("1- Morango (1l, 500ml, 300ml)");
                Console.WriteLine("2- Manga (1l, 500ml, 300ml)");
                Console.WriteLine("3- Uva (1l, 500ml, 300ml)");

                this.Descricao = Console.ReadLine();
                int.TryParse(this.Descricao, out opcao);
                switch (opcao)
                {
                    case 1:
                        this.Descricao = "Morango (1l, 500ml, 300ml)";
                        this.PrecoBase += 18.00m;
                        break;
                    case 2:
                        this.Descricao = "Manga (1l, 500ml, 300ml)";
                        this.PrecoBase += 15.00m;
                        this.Tamanho = "500ml";
                        this.Tamanho = "1L";
                        break;
                    case 3:
                        this.Descricao = "Uva (1l, 500ml, 300ml)";
                        this.PrecoBase += 12.00m;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        this.Descricao = "Uva";
                        this.PrecoBase += 12.00m;
                        break;
                }
                Console.WriteLine("mais bebida?(sim/sair)");
                resposta = Console.ReadLine();

                Console.WriteLine("1- Morango");
                Console.WriteLine("2- Manga");
                Console.WriteLine("3- Uva");
                this.Descricao = Console.ReadLine();

                Console.WriteLine("qual o tamanho? (1l, 500ml, 300ml)");
                this.Tamanho = Console.ReadLine();
                this.Tamanho = "500ml";
                this.Tamanho = "1L";
                this.Tamanho = "300ml";
            }

            if(resposta == "sair")
            {
                Program.MenuPrincipal();
            }

        }

        public override decimal CalcularPrecoFinal()
        {
            if (Tamanho == "300ml") return PrecoBase;
            if (Tamanho == "500ml") return PrecoBase + 3.00m;
            if (Tamanho == "1L") return PrecoBase + 6.00m;
            return PrecoBase;
        }
    }
}
