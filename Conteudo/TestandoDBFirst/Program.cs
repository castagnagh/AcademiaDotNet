namespace TestandoDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Sistema de pedidos: ");

            while (true)
            {
                Console.WriteLine("Digite: \n1 - Cadastrar clientes\n2 - Visualizar todos clientes\n3 - Cadastrar pedidos\n4 - Visualizar todos pedidos");
                Console.WriteLine("Caso deseje, digite 0 para sair do sistema!");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        InserirCliente();
                        break;
                    case 2:
                        MostrarTodosClientes();
                        break;
                    case 3:
                        InserirPedidos();
                        break;
                    case 4:
                        MostrarTodosPedidos();
                        break;
                    default:
                        Console.WriteLine("Digite uma operação válida!");
                        break;
                }

            }

        }

        private static void InserirPedidos()
        {
            using (var contexto = new bancodContext())
            {
                Pedido p = new Pedido();
                Console.WriteLine("Digite o ID do cliente: ");
                p.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a data do medido - Formato AAAA-MM-DD");
                p.Datapedido = DateTime.Parse(Console.ReadLine());
                //p.Datapedido = DateTime.Now;
                Console.WriteLine("Digite o valor do pedido: ");
                p.Valor = (decimal?)double.Parse(Console.ReadLine());
                contexto.Pedidos.Add(p);
                contexto.SaveChanges();
                Console.WriteLine("Pedido adicionado!");
            }
        }

        private static void MostrarTodosPedidos()
        {
            using (var contexto = new bancodContext())
            {
                var pedidos = contexto.Pedidos.ToList(); //buscando todos os pedidos cadastrados

                foreach (var pedido in pedidos)
                {
                    Console.WriteLine("Pedido: " + pedido.Id + " Valor: " + pedido.Valor + " Data: " + pedido.Datapedido);
                }
            }
        }

        private static void InserirCliente()
        {
            using (var contexto = new bancodContext())
            {
                Cliente c = new Cliente();
                Console.WriteLine("Digite o nome do cliente: ");
                c.Nome = Console.ReadLine();
                Console.WriteLine("Digite o e-mail do cliente: ");
                c.Email = Console.ReadLine();

                contexto.Clientes.Add(c);
                contexto.SaveChanges();

                Console.WriteLine("Cliente adicionado!");
            }

        }

        private static void MostrarTodosClientes()
        {
            using (var contexto = new bancodContext())
            {
                var clientes = contexto.Clientes.ToList(); //buscando todos os clientes cadastrados

                foreach (var cliente in clientes)
                {
                    Console.WriteLine("Cliente: " + cliente.Id + " Nome: " + cliente.Nome + " E-mail: " + cliente.Email);
                }
            }
        }
    }
}