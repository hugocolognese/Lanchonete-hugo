using Lanchonete_Teste.Classes;
using Lanchonete_Teste.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lanchonete_Teste
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("             LANCHONETE DO HUGO              ");
            Console.WriteLine("=============================================");
            Console.WriteLine(" 1- Cardápio de Lanches");
            Console.WriteLine(" 2- Cardápio de Bebidas");
            Console.WriteLine(" 3- Fechar Pedido");
            Console.WriteLine("4- Pagar");
            Console.WriteLine("=============================================");
            Console.Write("Escolha uma opção: ");

            string inputOpcao = Console.ReadLine();
            int.TryParse(inputOpcao, out int opcao);

            switch (opcao)
            {
                case 1:
                    Lanche lanche = new Lanche(01, "lanche", 15m);
                    ControlePedido controlePedidoLanche = new ControlePedido();
                    lanche.MenuLanches();
                    controlePedidoLanche.AdicionarPedido(lanche);
                    controlePedidoLanche.FecharPedido();
                    lanche.CalcularPrecoFinal();
                    break;
                case 2:
                    Bebida bebida = new Bebida(02, "bebida", 15m);
                    ControlePedido controlePedidoBebida = new ControlePedido();
                    bebida.MenuBebida();
                    controlePedidoBebida.AdicionarPedido(bebida);
                    controlePedidoBebida.FecharPedido();
                    bebida.CalcularPrecoFinal();
                    break;

                case 3:
                    Pagamento pagamento = new Pagamento(0m);
                    pagamento.ProcessarPagamento();
                    MenuPrincipal();
                    
                    break;

            }

        }
    }
}

