using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    internal class Pessoa
    {
        public string nome;
        public string cpf;
        public string rg;
        public string dataNascimento;

        public void CadastrarPessoa()
        {
            Console.WriteLine("Cadastro de Pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("RG: ");
            rg = Console.ReadLine();
            Console.Write("Data de Nascimento (dd/mm/yyyy): ");
            dataNascimento = Console.ReadLine();
        }

        public void ApresentarDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("RG: " + rg);
            Console.WriteLine("Data de Nascimento (dd/mm/yyyy): " + dataNascimento);
        }
    }


}
