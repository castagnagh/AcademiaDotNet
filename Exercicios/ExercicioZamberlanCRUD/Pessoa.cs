using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioZamberlanCRUD
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }

        public Pessoa(string nome, string email, DateOnly dataNascimento)
        {
            this.nome = nome;
            this.email = email;
            this.dataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
