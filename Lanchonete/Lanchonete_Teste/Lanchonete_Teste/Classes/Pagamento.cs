using Lanchonete_Teste.Interface;
using System;

namespace Lanchonete_Teste.Classes
{
    public class Pagamento : Ipagamento
    {
        public string FormaPagamento { get; private set; } = string.Empty;
        public decimal ValorTotal { get; set; }

        public Pagamento(decimal valorTotal)
        {
            ValorTotal = valorTotal;
        }

        public void ProcessarPagamento()
        {
            bool pagamentoAprovado = false;

            while (!pagamentoAprovado)
            {
                Console.Clear();
                Console.WriteLine("============== PAGAMENTO ==============");
                Console.WriteLine("Valor total: " + ValorTotal.ToString("C2"));
                Console.WriteLine("1 - Débito");
                Console.WriteLine("2 - Crédito");
                Console.Write("Escolha uma tecla: ");

                char opcao = Console.ReadKey(true).KeyChar;
                if (opcao == '1')
                {
                    FormaPagamento = "Débito";
                }
                else if (opcao == '2')
                {
                    FormaPagamento = "Crédito";
                }
                else
                {
                    Console.WriteLine("Aperte qualquer tecla para tentar novamente.");
                    Console.ReadKey(true);
                    continue;
                }

                if (ValidarPagamento())
                {
                    Console.WriteLine("Pagamento de " + ValorTotal.ToString("C2") + " aprovado.");
                    Console.WriteLine(ObterDescricaoPagamento());
                    pagamentoAprovado = true; 
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
                    Console.ReadKey(true);
                }
            }
        }

        private bool ValidarPagamento()
        {
            if (FormaPagamento == "Débito" || FormaPagamento == "Crédito")
            {
                return true;
            }

            return false;
        }

        public string ObterDescricaoPagamento()
        {
            return "Pagamento finalizado na modalidade: " + FormaPagamento + ".";
        }
    }
}





