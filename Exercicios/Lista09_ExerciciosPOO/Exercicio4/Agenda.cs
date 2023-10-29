using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Agenda
    {
        private List<Agenda> agendaLista = new List<Agenda>();
        public string nome;
        public string telefone;
        public string email;

        public Agenda(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }



        //adicionar
        public void AdicionarContato(Agenda agenda)
        {
            agendaLista.Add(agenda);
            Console.WriteLine("Contato adicionado!");
        }

        //remover
        public void RemoverContatoPorNome(string nome)
        {
            bool contatoEncontrado = false;

            for (int i = agendaLista.Count - 1; i >= 0; i--)
            {
                if (agendaLista[i].nome == nome)
                {
                    agendaLista.RemoveAt(i);
                    i--;
                    contatoEncontrado = true;
                    Console.WriteLine("Contato removido com sucesso!");
                }
            }

            if (!contatoEncontrado)
            {
                Console.WriteLine("Contato não encontrado");
            }
        }

        //buscar
        public void BuscarContatoPorNome(string nome)
        {
            foreach (Agenda a in agendaLista)
            {
                if (a.nome.Equals(nome))
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome encontrado: " + a.nome + " \nNumero encontrado: " + a.telefone + "\n E-mail encontrado: " + a.email);
                }
                else
                {
                    Console.WriteLine("Nome não encontrado");
                }
            }
        }

        //listar
        public void ExibirContatos()
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
                    Console.WriteLine("Telefone: " + a.telefone);
                    Console.WriteLine("E-mail: " + a.email);
                }
            }
        }

    }
}
