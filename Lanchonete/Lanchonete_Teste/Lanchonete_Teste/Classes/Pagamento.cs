using Lanchonete_Teste.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_Teste.Classes
{
    public class Pagamento : Ipagamento
    {
        public string FormaPagamento { get; set; }
        public decimal ValorTotal { get; set; }

        public Pagamento(decimal valorTotal)
        {
            ValorTotal = valorTotal;
        }

        public void ProcessarPagamento()
        {
            Console.WriteLine("\n===========================");
            Console.WriteLine("        PAGAMENTO");
            Console.WriteLine("===========================");
            Console.WriteLine($"Valor total da conta: {ValorTotal}");
            Console.WriteLine("Aviso: Só aceitamos Débito ou Crédito.");

            bool pagamentoAprovado = false;

            while (!pagamentoAprovado)
            {
                Console.Write("\nDigite a forma de pagamento (debito / credito): ");
                FormaPagamento = Console.ReadLine();
                if (ValidarPagamento())
                {
                    Console.WriteLine($"\n> Sucesso! Pagamento de {ValorTotal:F2} aprovado.");
                    Console.WriteLine(ObbterDescricaoPagamento());
                    pagamentoAprovado = true; 
                }
                else
                {
                    Console.WriteLine("> ERRO: Forma de pagamento recusada. Tente novamente.");
                }
            }
        }

        public bool ValidarPagamento()
        {

            
            if (FormaPagamento == "debito" || FormaPagamento == "débito" ||
                FormaPagamento == "credito" || FormaPagamento == "crédito")
            {
                return true;
            }

            return false;
        }


        public string ObbterDescricaoPagamento()
        {
            return $"Pagamento finalizado na modalidade: {FormaPagamento.ToUpper()}.";
        }
    }
}





