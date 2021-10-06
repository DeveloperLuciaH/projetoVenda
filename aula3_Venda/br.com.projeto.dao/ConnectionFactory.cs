using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3_Venda.br.com.projeto.dao
{
    public class ConnectionFactory
    {
        //Criando o método que conecta no Banco
        public SqlConnection getConnection()
        {
            try
            {
                string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
                return new SqlConnection(conexao);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao conectar: " + erro);
                return null;
            }
        }

    }
}
