using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_Venda.br.com.projeto.model
{
    public class Produto
    {

        public int id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal Margem { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal Quantidade { get; set; }
        public int id_fornecedor { get; set; }
        //public string RazaoSocial_Fornecedor { get; set; }

              
        

    }
}
