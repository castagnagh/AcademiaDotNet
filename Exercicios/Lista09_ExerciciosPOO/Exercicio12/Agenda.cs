using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{

    internal class Agenda
    {
        private List<Agenda> agendaLista = new List<Agenda>();
        public string nome;
        public int idade;
        public double altura;

        public Agenda(string nome, int idade, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public Agenda() { }

        //adicionar
        public void AdicionarPessoa(Agenda agenda)
        {
            agendaLista.Add(agenda);
            Console.WriteLine("Pessoa adicionada!");
        }

        //remover
        public void RemoverPorNome(string nome)
        {
            bool pessoaEncontrada = false;

            for (int i = agendaLista.Count - 1; i >= 0; i--)
            {
                if (agendaLista[i].nome == nome)
                {
                    agendaLista.RemoveAt(i);
                    i--;
                    pessoaEncontrada = true;
                    Console.WriteLine("Pessoa removida com sucesso!");
                }
            }

            if (!pessoaEncontrada)
            {
                Console.WriteLine("Contato não encontrado");
            }
        }

        //buscar
        public void BuscarPorNome(string nome)
        {
            foreach (Agenda a in agendaLista)
            {
                if (a.nome.Equals(nome))
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome encontrado: " + a.nome + " \nIdade encontrado: " + a.idade + "\n Altura encontrada: " + a.altura);
                }
                else
                {
                    Console.WriteLine("Nome não encontrado");
                }
            }
        }

        //listar
        public void ExibirPessoa()
        {
            if (agendaLista.Count == 0)
            {
                Console.WriteLine("A agenda está vazia.");
            }
            else
            {
                foreach (Agenda a in agendaLista)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Nome: " + a.nome);
                    Console.WriteLine("Idade: " + a.idade);
                    Console.WriteLine("Altura: " + a.altura);
                }
            }
        }

    }
}
