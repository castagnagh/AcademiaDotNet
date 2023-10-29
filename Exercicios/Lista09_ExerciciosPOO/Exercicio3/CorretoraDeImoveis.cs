using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class CorretoraDeImoveis
    {
        private List<CorretoraDeImoveis> corretoraDeImoveis = new List<CorretoraDeImoveis>();

        public string endereco;
        private double preco;
        public string tipo;

        public double Preco { get => preco; set => preco = value; }

        public CorretoraDeImoveis(string endereco, double preco, string tipo)
        {
            this.endereco = endereco;
            this.Preco = preco;
            this.tipo = tipo;
        }

        public CorretoraDeImoveis() { }
        public void InserirImovel(CorretoraDeImoveis corretora)
        {
            corretoraDeImoveis.Add(corretora);
        }

        public void ListarImovel()
        {
            foreach(CorretoraDeImoveis cr in corretoraDeImoveis)
            {
                Console.WriteLine("Endereço: " + cr.endereco + "\nPreço: " + cr.Preco + "\nTipo: " + cr.tipo + "----------------------------");
            }
        }

        public void ExibirPrecoMedioImovel()
        {
            int count = 0;
            double media = 0;
            foreach (CorretoraDeImoveis cr in corretoraDeImoveis)
            {
                
                media += cr.preco;
                count++;
            }
            Console.WriteLine("Preço médio dos imóveis: " + media / count);
        }
    }
}
