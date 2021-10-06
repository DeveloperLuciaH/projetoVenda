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
    public class ProdutoDAO
    {
        private SqlConnection conexao;
        
        public ProdutoDAO()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        // MÉTODO CADASTRAR
        public void cadastrarProduto(Produto obj)
        {
            // 1º passo - Comando de Insert no SQL
            string sql = @"insert into produto values (@descricao, @valor_compra, @margem_lucro, @valor_venda, @quantidade, @id_fornecedor)";

            // 2º passo - Organizar o cmd do SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@descricao", obj.Descricao);
            comando.Parameters.AddWithValue("@valor_compra", obj.ValorCompra);
            comando.Parameters.AddWithValue("@margem_lucro", obj.Margem);
            comando.Parameters.AddWithValue("@valor_venda", obj.ValorVenda);
            comando.Parameters.AddWithValue("@quantidade", obj.Quantidade);
            comando.Parameters.AddWithValue("@id_fornecedor", obj.id_fornecedor);
          
            // 3º passo - Abrir a conexão
            conexao.Open();
            // 4º passo - Executar o comando SQL e fechar a conexão
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO ALTERAR
        public void alterarProduto(Produto obj)
        {
            //passo 1 - comando SQL
            string sql = @"update produto set descricao=@descricao, valor_compra=@valor_compra, margem_lucro=@margem_lucro, valor_venda=@valor_venda, quantidade=@quantidade, id_fornecedor=@id_fornecedor where id=@id";
            
            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@descricao", obj.Descricao);
            comando.Parameters.AddWithValue("@valor_compra", obj.ValorCompra);
            comando.Parameters.AddWithValue("@margem_lucro", obj.Margem);
            comando.Parameters.AddWithValue("@valor_venda", obj.ValorVenda);
            comando.Parameters.AddWithValue("@quantidade", obj.Quantidade);
            comando.Parameters.AddWithValue("@id_fornecedor", obj.id_fornecedor);
            comando.Parameters.AddWithValue("@id", obj.id);

            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO DELETAR
        public void deletarProduto(Produto obj)
        {
            // 1º passo - Comando SQL
            string sql = @"delete from produto where id = @id";

            // 2º passo - Organizar o cmd do SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", obj.id);

            // 3º passo - Abrir a conexão
            conexao.Open();
            // 4º passo - Executar o comando SQL e fechar a conexão
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO LISTAR TODOS OS PRODUTOS
        public DataTable ListarTodosProdutos()
        {
            // 1º passo - Comando SQL - Fabricante é o "apelido"
        
            string sql = @"select p.id, p.descricao, f.razaosocial as 'fabricante', p.valor_compra, p.margem_lucro,
                        p.valor_venda, p.quantidade from produto as p inner join fornecedor f on (p.id_fornecedor = f.id)";

            // 2º passo - Organizar o cmd do SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
           
            // 3º passo - Abrir a conexão e executar o comando
            conexao.Open();           
            executacmdsql.ExecuteNonQuery();

            // 4º passo - Criar o SQL Adapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // 5º passo - Criar a DataTable
            DataTable tabelaProduto = new DataTable();
            da.Fill(tabelaProduto);

            // 6º passo - Fechar a conexão
            conexao.Close();

            // 7º passo - Retornar DataTable com os dados
            return tabelaProduto;
        }

        // MÉTODO BUSCAR POR DESCRIÇÃO DO PRODUTO
        public DataTable buscarPorDescricao(string descricao)
        {
            // 1º passo - Comando SQL
            string sql = @"select p.id, p.descricao, f.razaosocial as 'fabricante', p.valor_compra, 
                        p.valor_venda, p.quantidade from produto as p inner join fornecedor f on (p.id_fornecedor = f.id)
                        where p.descricao like @descricao";

            // 2º passo - Organizar o cmd do SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@descricao", descricao);

            // 3º passo - Abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // 4º passo - Criar o SQL Adapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // 5º passo - Criar a DataTable
            DataTable tabelaProduto = new DataTable();
            da.Fill(tabelaProduto);

            // 6º passo - Fechar a conexão
            conexao.Close();

            // 7º passo - Retornar DataTable com os dados
            return tabelaProduto;
        }

        // MÉTODO BUSCAR POR FORNECEDOR
        public DataTable buscarPorFornecedor(string razaosocial)
        {
            // 1º passo - Comando SQL
           
            string sql = @"select p.id, p.descricao, f.razaosocial as 'fabricante', p.valor_compra, 
                        p.valor_venda, p.quantidade from produto as p inner join fornecedor f on (p.id_fornecedor = f.id)
                        where f.razaosocial like @razaosocial";

            // 2º passo - Organizar o cmd do SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@razaosocial", razaosocial);

            // 3º passo - Abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // 4º passo - Criar o SQL Adapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // 5º passo - Criar a DataTable
            DataTable tabelaProduto = new DataTable();
            da.Fill(tabelaProduto);

            // 6º passo - Fechar a conexão
            conexao.Close();

            // 7º passo - Retornar DataTable com os dados
            return tabelaProduto;
        }

        // MÉTODO BUSCAR PRODUTO PELO ID PARA A TELA DE VENDAS
        public Produto buscarProdutoPorId(int id)
        {
            // 1º passo - Comando SQL
            string sql = @"select from produto where id = @id";

            // 2º passo - Organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@id", id);

            // 3º passo - Abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // 4º passo - Criar o SQLDataReader
            SqlDataReader da = executacmdsql.ExecuteReader();
            Produto obj = new Produto();
            if (da.Read())
            {
                obj.id = da.GetInt32(0);
                obj.Descricao = da.GetString(1);
                obj.ValorCompra = da.GetDecimal(2);
                obj.Margem = da.GetDecimal(3);
                obj.ValorVenda = da.GetDecimal(4);
                obj.Quantidade = da.GetDecimal(5);

            }

            return obj;
        }

    }
}
