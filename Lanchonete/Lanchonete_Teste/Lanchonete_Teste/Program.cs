using Lanchonete_Teste.Classes;
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
            string inputOpcao;
            Console.WriteLine("1- Cardapio Lanches");
            Console.WriteLine("2- Cardapio Bebidas");
            Console.WriteLine("3- Pagamento");
            inputOpcao = Console.ReadLine();

            int.TryParse(inputOpcao, out int opcao);

            switch (opcao)
            {
                case 1:
                    Lanche lanche = new Lanche(01, "lanche", 15m);
                    lanche.MenuLanches();
                    lanche.CalcularPrecoFinal();
                    ControlePedido controlePedidoLanche = new ControlePedido();
                    controlePedidoLanche.AdicionarPedido(lanche);
                    controlePedidoLanche.FecharPedido();
                    break;
                case 2:
                    Bebida bebida = new Bebida(02, "bebida", 15m);
                    bebida.MenuBebida();
                    bebida.CalcularPrecoFinal();
                    ControlePedido controlePedidoBebida = new ControlePedido();
                    controlePedidoBebida.AdicionarPedido(bebida);
                    controlePedidoBebida.FecharPedido();
                    break;

                case 3:

                    break;
            }

        }
    }
}

