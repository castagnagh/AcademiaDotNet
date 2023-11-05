using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioZamberlanCRUD
{
    public class Treinador : Pessoa
    {
        public string RegistroConselho { get; set; }
        public string Clube { get; set; }

        public Treinador(string nome, string email, DateOnly data, string registroConselho, string clube) : base(nome, email, data)
        {
            RegistroConselho = registroConselho;
            Clube = clube;
        }
    }
}
