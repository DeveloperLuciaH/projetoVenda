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
    public class ClienteDAO
    {
        private SqlConnection conexao;

        //Construtor
        public ClienteDAO()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        //MÉTODOS SQL
        //MÉTODO CADASTRAR
        public void cadastrar (Cliente obj)
        {
            // passo 1 - comando SQL
            string sql = @"insert into cliente(nome,email,telefone,sexo,cpf,endereco, cidade, bairro, cep, uf) values (@nome, @email, @telefone, @sexo, @cpf, @endereco,@cidade, @bairro, @cep, @uf)";

            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", obj.Nome);
            comando.Parameters.AddWithValue("@email", obj.Email);
            comando.Parameters.AddWithValue("@telefone", obj.Telefone);
            comando.Parameters.AddWithValue("@sexo", obj.Sexo);
            comando.Parameters.AddWithValue("@cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@cidade", obj.Cidade);
            comando.Parameters.AddWithValue("@bairro", obj.Bairro);
            comando.Parameters.AddWithValue("@cep", obj.Cep);
            comando.Parameters.AddWithValue("@uf", obj.UF);


            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar 
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO ALTERAR
        public void alterar (Cliente obj)
        {
            //passo 1 - comando SQL
            string sql = @"update cliente set nome=@nome, email=@email, telefone=@telefone, sexo=@sexo, cpf=@cpf, endereco=@endereco, cidade=@cidade, bairro=@bairro, cep=@cep, uf=@uf where id=@id";

            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", obj.Nome);
            comando.Parameters.AddWithValue("@email", obj.Email);
            comando.Parameters.AddWithValue("@telefone", obj.Telefone);
            comando.Parameters.AddWithValue("@sexo", obj.Sexo);
            comando.Parameters.AddWithValue("@cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@cidade", obj.Cidade);
            comando.Parameters.AddWithValue("@bairro", obj.Bairro);
            comando.Parameters.AddWithValue("@cep", obj.Cep);
            comando.Parameters.AddWithValue("@uf", obj.UF);
            comando.Parameters.AddWithValue("@id", obj.id);

            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar
            comando.ExecuteNonQuery();
            conexao.Close();
        }
         
        // MÉTODO EXCLUIR

        public void excluir (Cliente obj)
        {
            // passo 1 - comando SQL
            string sql = @"delete from cliente where id=@id";

            // passo 2 - organizar o cmd SQL
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", obj.id);

            // passo 3 - abrir a conexão
            conexao.Open();

            // passo 4 - executar o comando SQL e fechar
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        // MÉTODO LISTAR TODOS OS CLIENTES

        public DataTable ListarTodosClientes()
        {
            // passo 1 - comando SQL
            string sql = @"select * from cliente";

            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // passo 5 - criar o DataTable
            DataTable tabelaCliente = new DataTable();
            da.Fill(tabelaCliente);

            // passo 6 - fechar a conexão
            conexao.Close();

            // passo 7 - retornar DataTable com dados
            return tabelaCliente;
        }

        // MÉTODO BUSCAR POR NOME

        public DataTable buscarPorNome(Cliente obj)
        {
            // passo 1 - comando SQL
            string sql = @"select * from cliente where nome like '%' + @nome + '%'";

            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@nome", obj.Nome);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // passo 5 - criar o DataTable
            DataTable tabelaCliente = new DataTable();
            da.Fill(tabelaCliente);

            // passo 6 - fechar a conexão
            conexao.Close();

            // passo 7 - retornar DataTable com dados
            return tabelaCliente;
        }

        // MÉTODO BUSCAR CLIENTE POR CPF NA TELA DE CLIENTES
        public DataTable buscarPorCpf(Cliente obj)
        {
            // passo 1 - comando SQL
            string sql = @"select * from cliente where cpf like '%' + @cpf + '%'";

            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@cpf", obj.Cpf);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            // passo 5 - criar o DataTable
            DataTable tabelaCliente = new DataTable();
            da.Fill(tabelaCliente);

            // passo 6 - fechar a conexão
            conexao.Close();

            // passo 7 - retornar DataTable com dados
            return tabelaCliente;
        }

        // MÉTODO DE BUSCAR CLIENTE POR CPF PARA TELA DE VENDAS EXCLUSIVAMENTE

        public Cliente BuscaClientePorCpf(string cpf)
        {
            // passo 1 - comando SQL
            string sql = @"select * from cliente where cpf = @cpf";

            // passo 2 - organizar o SQL
            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@cpf", cpf);

            // passo 3 - abrir a conexão e executar o comando
            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            // passo 4 - criar o SqlDataReader
            SqlDataReader da = executacmdsql.ExecuteReader();
            Cliente obj = new Cliente();

            if (da.Read())
            {
                obj.id = da.GetInt32(0);
                obj.Nome = da.GetString(1);
                obj.Email = da.GetString(2);
                obj.Telefone = da.GetString(3);
                obj.Sexo = da.GetString(4);
                obj.Cpf = da.GetString(5);

            }

            return obj;
           

        }
    }
}
