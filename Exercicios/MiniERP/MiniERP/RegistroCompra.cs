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

        //criar uma lista com todos os produtos inseridos no carrinho
        //para quando o cliente resolver finalizar a compra, salvar no banco de dados essa lista
        //pois pensei nessa maneira caso o cliente queira cancelar a compra, nesse caso a lista só é desfeita e nada é gravado no banco
        public List<RegistroCompra> listaItensTemp = new List<RegistroCompra>();


        public void addLista(float preco, int idcliente, int idproduto)
        {
            RegistroCompra rc = new RegistroCompra();
            rc.PrecoTotal = preco;
            //QtdTotal = qtd;
            rc.IdClientes = idcliente;
            rc.IdProdutos = idproduto;
            listaItensTemp.Add(rc);
        }

    }
}
