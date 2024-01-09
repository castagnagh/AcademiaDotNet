using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    public class RegistroCompra
    {
        private int _id;
        private float _precoTotal;
        private int _qtd_total;
        private int _idProdutos;
        private int _idClientes;


        public int Id { get; private set; }
        public float PrecoTotal { get; private set; }
        public int QtdTotal {  get; private set; }
        public int IdProdutos { get; private set; }
        public int IdClientes { get; private set; }

        public RegistroCompra(int qtdTotal, int idProdutos, int idClientes)
        {
            QtdTotal = qtdTotal;
            IdProdutos = idProdutos;
            IdClientes = idClientes;
        } 
    }
}
