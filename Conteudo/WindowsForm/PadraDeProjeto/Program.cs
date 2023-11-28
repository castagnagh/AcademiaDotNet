using PadraDeProjeto.FactoryMethod;
using PadraDeProjeto.PPMediator;

namespace PadraDeProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Testando a classe configuração usando o padrão singleton;");

            //    ConfiguracaoSingleton config = ConfiguracaoSingleton.getInstance();
            //    config.ExibirDados();

            //    ConfiguracaoSingleton config2 = ConfiguracaoSingleton.getInstance();

            //    if(config == config2)
            //        Console.WriteLine("Mesma instância -1 e 2");

            //    //na linha abaio, estou chamando o construtor no cliente
            //    //isso não podemos, pois criamos uma outra instancia.
            //    //o construtor deve ser provado ou protegido!
            //    //ConfiguracaoSingleton config3 =new ConfiguracaoSingleton();

            //    ConfiguracaoSingleton config3 = ConfiguracaoSingleton.getInstance();

            //    if(config == config3 )
            //        Console.WriteLine("Mesma instancia -1 e 3");
            //    else
            //        Console.WriteLine("Diferente instancia -1 e 3");

            //    Console.WriteLine("Testando o padrão de projeto Factry Method");
            //    //eu quero adiar a decisão de qual classe instanciar
            //    //Cachorro c = new Cachorro();
            //    //c.emitirSom();
            //    //agora, podemos adiar a decisao de qual objeto vamos instanciar uma

            //    IAnimalFactory cFactory = new CachorroFactory();

            //    IAnimal c = cFactory.CriarAnimal();
            //    c.emitirSom();


            /*
            Console.WriteLine("Testando o padrão de projeto Factory Method");
            //eu quero a adiar a decisão de qual classe instanciar
            //Cachorro c = new Cachorro();
            //c.FazerSom();
            //agora, podemos adiar  a decisao de qual objetovamos instanciar uma

            IAnimalFactory cFactory = new CachorroFactory();


            Cliente cli1 = new Cliente(cFactory);

            cli1.InteragirComAnimal();


            IAnimalFactory gFactory = new GatoFactory();
            Cliente cli2 = new Cliente(gFactory);

            cli2.InteragirComAnimal();

            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes.Add(cli1);
            listaClientes.Add(cli2);
            listaClientes.Add(new Cliente(cFactory)); // to adicionando outro cachorro
            listaClientes.Add(new Cliente(gFactory));
            */
            /*
            MediatorConcreto mediador = new MediatorConcreto();

            Colega1 c1 = new Colega1(mediador);
            Colega2 c2 = new Colega2(mediador);

            mediador.colega1 = c1;
            mediador.colega2 = c2;

            c1.Enviar("Mensagem enviada pra 1");
            c2.Enviar("Mensagem enviada pra 2");
            */

            Console.WriteLine("Testando o padrão Observer");
            Sujeito s = new Sujeito(); //seria a loja que tem o produto


            //agora vamos adicionar os interessados no assunto ou produto
            Observador o1 = new Observador("Ricardo");
            Observador o2 = new Observador("Fabrício");
            Observador o3 = new Observador("Alexandre");
            Observador o4 = new Observador("Guilherme");


            s.RegistrarObservador(o1);
            s.RegistrarObservador(o2);
            s.RegistrarObservador(o3);
            s.RegistrarObservador(o4);
            s.RegistrarObservador(new Observador("Ana Paula"));

            s.NotificarObservadores("A aula de hoje não está legal!");

            s.RemoverObservador(o4);

            s.NotificarObservadores("O Guilherme foi embora pois está chato pra caramba!!");
            Console.WriteLine("Final do teste do padrão Observer");
        }
    }
}