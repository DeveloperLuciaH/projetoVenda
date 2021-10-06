using aula3_Venda.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_Venda.br.com.projeto.dao
{
    public class FornecedorDAO
    {

        private SqlConnection conexao;

        //Construtor
        public FornecedorDAO()
        {
            conexao = new ConnectionFactory().getConnection();
        }


        //MÉTODOS SQL
        //MÉTODO CADASTRAR
        public void cadastrar(Fornecedor obj)
        {
            // passo 1 - comando SQL
            string sql = @"insert into fornecedor(razaosocial,cnpj, endereco, bairro, cidade, estado, cep, telefone, email) values (@razaosocial, @cnpj, @endereco, @bairro, @cidade, @estado, @cep, @telefone, @email)";

            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@razaosocial", obj.RazaoSocial);
            comando.Parameters.AddWithValue("@cnpj", obj.Cnpj);
            comando.Parameters.AddWithValue("@endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@bairro", obj.Bairro);
            comando.Parameters.AddWithValue("@cidade", obj.Cidade);
            comando.Parameters.AddWithValue("@estado", obj.UF);
            comando.Parameters.AddWithValue("@cep", obj.Cep);
            comando.Parameters.AddWithValue("@telefone", obj.Telefone);
            comando.Parameters.AddWithValue("@email", obj.Email);

            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar 
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO ALTERAR
        public void alterar(Fornecedor obj)
        {
            //passo 1 - comando SQL
            string sql = @"update fornecedor set razaosocial=@razaosocial, cnpj=@cnpj, endereco=@endereco, bairro=@bairro, cidade=@cidade, estado=@estado, cep=@cep, telefone=@telefone, email=@email where id=@id";

            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@razaosocial", obj.RazaoSocial);
            comando.Parameters.AddWithValue("@cnpj", obj.Cnpj);
            comando.Parameters.AddWithValue("@endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@bairro", obj.Bairro);
            comando.Parameters.AddWithValue("@cidade", obj.Cidade);
            comando.Parameters.AddWithValue("@estado", obj.UF);
            comando.Parameters.AddWithValue("@cep", obj.Cep);
            comando.Parameters.AddWithValue("@telefone", obj.Telefone);
            comando.Parameters.AddWithValue("@email", obj.Email);
            comando.Parameters.AddWithValue("@id", obj.id);

            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar 
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO EXCLUIR

        public void excluir(Fornecedor obj)
        {
            // passo 1 - comando SQL
            string sql = @"delete from fornecedor where id=@id";

            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", obj.id);

            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO LISTAR TODOS OS FORNECEDORES

        public DataTable ListarTodosFornecedores()
        {
            // passo 1 - comando SQL
            string sql = @"select * from fornecedor";

            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // passo 5 - criar o DataTable
            DataTable tabelaFornecedor = new DataTable();
            da.Fill(tabelaFornecedor);

            // passo 6 - fechar a conexão
            conexao.Close();

            // passo 7 - retornar DataTable com dados
            return tabelaFornecedor;
        }

        // MÉTODO BUSCAR POR RAZÃO SOCIAL

        public DataTable buscarPorRazaoSocial(Fornecedor obj)
        {
            // passo 1 - comando SQL
            string sql = @"select * from fornecedor where razaosocial like '%' + @razaosocial + '%'";
                    

            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@razaosocial", obj.RazaoSocial);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // passo 5 - criar o DataTable
            DataTable tabelaFornecedor = new DataTable();
            da.Fill(tabelaFornecedor);

            // passo 6 - fechar a conexão
            conexao.Close();

            // passo 7 - retornar DataTable com dados
            return tabelaFornecedor;
        }

        // MÉTODO DE BUSCAR FORNECEDOR POR CNPJ

        public DataTable BuscaFornecedorPorCnpj(Fornecedor obj)
        {
            // passo 1 - comando SQL
            string sql = @"select * from fornecedor where cnpj like '%' + @cnpj + '%'";


            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@cnpj", obj.Cnpj);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // passo 5 - criar o DataTable
            DataTable tabelaFornecedor = new DataTable();
            da.Fill(tabelaFornecedor);

            // passo 6 - fechar a conexão
            conexao.Close();

            // passo 7 - retornar DataTable com dados
            return tabelaFornecedor;
        }
    }

}


