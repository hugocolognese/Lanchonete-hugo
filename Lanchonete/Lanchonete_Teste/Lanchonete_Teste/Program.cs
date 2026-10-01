using Lanchonete_Teste.Classes;

namespace Lanchonete_Teste
{
    public class Program
    {
        static void Main()
        {
            ControlePedido pedido = new ControlePedido();

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n========= LANCHONETE DO HUGO =========");
                    Console.WriteLine("1 - Adicionar lanche");
                    Console.WriteLine("2 - Adicionar bebida");
                    Console.WriteLine("3 - Ver pedido");
                    Console.WriteLine("4 - Pagar no caixa");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção usando as teclas: ");

                    char opcao = Console.ReadKey(true).KeyChar;

                    if (opcao == '1')
                    {
                        Lanche lanche = new Lanche(1, "Lanche", 0m);
                        lanche.MenuLanches();
                        pedido.AdicionarPedido(lanche);
                        Console.WriteLine("Lanche adicionado ao pedido.");
                        Console.WriteLine("Pressione qualquer tecla para continuar.");
                        Console.ReadKey(true);
                    }
                    else if (opcao == '2')
                    {
                        Bebida bebida = new Bebida(2, "Bebida", 0m);
                        bebida.MenuBebida();
                        pedido.AdicionarPedido(bebida);
                        Console.WriteLine("Bebida adicionada ao pedido.");
                        Console.WriteLine("Pressione qualquer tecla para continuar.");
                        Console.ReadKey(true);
                    }
                    else if (opcao == '3')
                    {
                        Console.Clear();
                        pedido.FecharPedido();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey(true);
                    }
                    else if (opcao == '4')
                    {
                        decimal total = pedido.ObterTotal();
                        if (total == 0m)
                        {
                            Console.WriteLine("Adicione pelo menos um produto antes de pagar.");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            Console.Clear();
                            pedido.FecharPedido();
                            Console.WriteLine("Pressione qualquer tecla para escolher a forma de pagamento.");
                            Console.ReadKey(true);
                            Console.Clear();
                            Pagamento pagamento = new Pagamento(total);
                            pagamento.ProcessarPagamento();
                            pedido.Limpar();
                            Console.WriteLine("Pedido pago. Pressione qualquer tecla para continuar.");
                            Console.ReadKey(true);
                        }
                    }
                    else if (opcao == '0')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey(true);
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("Ocorreu um erro: " + erro.Message);
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
