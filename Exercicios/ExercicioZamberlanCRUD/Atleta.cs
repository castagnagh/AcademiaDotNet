using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioZamberlanCRUD
{
    internal class Atleta : Pessoa
    {
        public string PosicaoQuadra {  get; set; }
        public string Categoria { get; set; }

        public Atleta(string posicaoQuadra, string categoria) : base(nome, email, dataNascimento)
        {
            PosicaoQuadra = posicaoQuadra;
            Categoria = categoria;
        }

    }
}
