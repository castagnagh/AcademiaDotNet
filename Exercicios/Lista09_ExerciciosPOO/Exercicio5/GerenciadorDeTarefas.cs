using System;
using System.Collections.Generic;

namespace Exercicio5
{
    internal class GerenciadorDeTarefas
    {
        List<GerenciadorDeTarefas> tarefas = new List<GerenciadorDeTarefas>();
        public string Descricao { get; set; }
        public DateOnly DataVencimento { get; set; }

        public GerenciadorDeTarefas(string descricao, DateOnly dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
        public GerenciadorDeTarefas()
        {
            
        }

        public void AdicionarTarefa(GerenciadorDeTarefas novaTarefa)
        {
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso");
        }

        public void ListarTarefa()
        {
            int i = 0;
           if(tarefas.Count > 0)
            {
                foreach (var tarefa in tarefas)
                {
                    Console.WriteLine("Tarefa Nr " + i);
                    Console.WriteLine("Descrição da tarefa: " + tarefa.Descricao + "\n Validade da tarefa: " + tarefa.DataVencimento);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não há tarefas para serem exibidas!");
            }
        }

        public void RemoverTarefa(string descr)
        {
            bool tarefaEncontrada = false;

            for (int i = tarefas.Count - 1; i >= 0; i--)
            {
                if (tarefas[i].Descricao == descr)
                {
                    tarefas.RemoveAt(i);
                    tarefaEncontrada = true;
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
            }

            if (!tarefaEncontrada)
            {
                Console.WriteLine("Tarefa não encontrada");
            }
        }

        public void VerificarTarefaHoje()
        {
            DateOnly diaHoje = DateOnly.FromDateTime(DateTime.Now);
            foreach (var tarefa in tarefas)
            {
                if (tarefa.DataVencimento == diaHoje)
                {
                    Console.WriteLine("A tarefa: " + tarefa.Descricao + " vence no dia de hoje!");
                }
            }
        }
    }
}
