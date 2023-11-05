using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioZamberlanCRUD
{
    public class Comunicacao
    {
        public static void cadastrarAtleta(List<Atleta> lista)
        {
            string nome;
            string email;
            DateOnly dataNascimento = new DateOnly();
            string posicao;
            string categoria;

            bool emailOK;

            do
            {
                Console.Write("Informe um email válido: ");
                email = Console.ReadLine();
            } while (!Utilidades.EmailIsValid(email));

            //lista de atletas
            //[{nome,email,dataNascimento,posicao,categoria}, {}, {}, {}]
            if (Pessoa.estaContidoAtleta(email, lista))
            {
                Console.WriteLine("Email já utilizado no sistema!!");
            }
            else
            {
                //pedir o restante dos dados
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
                do
                {
                    try
                    {
                        emailOK = true;
                        Console.Write("Data nascimento [dd/mm/aaaa]: ");
                        dataNascimento = DateOnly.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Data inválida!");
                        emailOK = false;
                    }
                } while (emailOK == false);

                Console.Write("Posição na quadra [direita ou esquerda]: ");
                posicao = Console.ReadLine().ToUpper();

                Console.Write("Categoria [1 ou 2 ou 3 ou 4 ou 5]: ");
                categoria = Console.ReadLine();

                //instanciar um objeto atleta
                Atleta atleta = new Atleta(nome, email, dataNascimento, posicao, categoria);

                //adicionar na lista
                lista.Add(atleta);
            }
        }

        public static void ListarAtletas(List<Atleta> lista)
        {
            foreach (var atleta in lista)
            {
                Console.WriteLine("Atleta: " + atleta.sobrenome() + ". Idade: " + atleta.idade() + ". Posição: " + atleta.PosicaoQuadra + ". Categoria: " + atleta.Categoria);
            }
        }

        public static void removerAtleta(List<Atleta> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia!!");
                return;
            }

            string pesquisa;
            Console.Write("Informe parte do nome ou o email: ");
            pesquisa = Console.ReadLine();

            Atleta? atleta = lista.Find(atleta => atleta.Nome.Contains(pesquisa) || atleta.Email.Contains(pesquisa));
            if (atleta != null)
            {
                Console.WriteLine("Atleta localizado...... " + atleta.Nome);
                lista.Remove(atleta);
            }
            else
            {
                Console.WriteLine("Atleta não localizado!!");
            }

            //versão mais simples
            //int posicao = Pessoa.pesquisaNomeEmail(pesquisa, lista);
            //if (posicao != -1)
            //{
            //    Console.WriteLine("Atleta localizado...." + lista[posicao].Nome);
            //    lista.RemoveAt(posicao);
            //}
            //else
            //{
            //    Console.WriteLine("Atleta não localizado!!");
            //}
        }

        public static void CadastrarTreinador(List<Treinador> lista)
        {
            string nome;
            string email;
            DateOnly dataNascimento = new DateOnly();
            string registroConselho;
            string clube;

            bool emailOK;

            do
            {
                Console.Write("Informe um email válido: ");
                email = Console.ReadLine();
            } while (!Utilidades.EmailIsValid(email));

            //lista de treinadores
            if (Pessoa.estaContidoTreinador(email, lista))
            {
                Console.WriteLine("Email já utilizado no sistema!!");
            }
            else
            {
                //pedir o restante dos dados
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
                do
                {
                    try
                    {
                        emailOK = true;
                        Console.Write("Data nascimento [dd/mm/aaaa]: ");
                        dataNascimento = DateOnly.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Data inválida!");
                        emailOK = false;
                    }
                } while (emailOK == false);

                Console.Write("Registro de Conselho: ");
                registroConselho = Console.ReadLine().ToUpper();

                Console.Write("Clube: ");
                clube = Console.ReadLine();

                //instanciar um objeto treinador
                Treinador treinador = new Treinador(nome, email, dataNascimento, registroConselho, clube);

                //adicionar na lista
                lista.Add(treinador);
            }
        }

        public static void ListarTreinador(List<Treinador> lista)
        {
            foreach (var treinador in lista)
            {
                Console.WriteLine("Treinador: " + treinador.sobrenome() + ". Idade: " + treinador.idade() + ". Registro de Conselho: " + treinador.RegistroConselho + ". Clube: " + treinador.Clube);
            }
        }

        public static void RemoverTreinador(List<Treinador> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia!!");
                return;
            }

            string pesquisa;
            Console.Write("Informe parte do nome ou o email: ");
            pesquisa = Console.ReadLine();

            Treinador? treinador = lista.Find(treinador => treinador.Nome.Contains(pesquisa) || treinador.Email.Contains(pesquisa));
            if (treinador != null)
            {
                Console.WriteLine("Treinador localizado...... " + treinador.Nome);
                lista.Remove(treinador);
            }
            else
            {
                Console.WriteLine("Treiandor não localizado!!");
            }
        }
    }
}
