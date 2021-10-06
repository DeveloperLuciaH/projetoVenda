using aula3_Venda.br.com.projeto.dao;
using aula3_Venda.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3_Venda
{
    public partial class FrmCliente : Form
    {

       

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // tabelaCliente é o nome do DataGridView onde irá listar todos os clientes
            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.ListarTodosClientes();
        }

        // BOTÃO CADASTRAR
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Cliente obj = new Cliente();

                obj.Nome = txtNome.Text;
                obj.Email = txtEmail.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Sexo = cbSexo.Text;
                obj.Cpf = txtCPF.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Cidade = txtCidade.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cep = txtCEP.Text;
                obj.UF = cbUF.Text;

                // passo 2 - Criar o objeto DAO

                ClienteDAO dao = new ClienteDAO();
                dao.cadastrar(obj);
                MessageBox.Show("Cliente cadastrado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaCliente.DataSource = dao.ListarTodosClientes();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar, tente novamente." + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // BOTÃO ALTERAR
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Cliente obj = new Cliente();

                obj.Nome = txtNome.Text;
                obj.Email = txtEmail.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Sexo = cbSexo.Text;
                obj.Cpf = txtCPF.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Cidade = txtCidade.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cep = txtCEP.Text;
                obj.UF = cbUF.Text;
                obj.id = int.Parse(txtId.Text);

                // passo 2 - Criar o objeto DAO

                ClienteDAO dao = new ClienteDAO();
                dao.alterar(obj);
                MessageBox.Show("Cadastro alterado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabelaCliente.DataSource = dao.ListarTodosClientes();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar, tente novamente: " + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        // BOTÃO EXCLUIR
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Cliente obj = new Cliente();

                obj.Nome = txtNome.Text;
                obj.Email = txtEmail.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Sexo = cbSexo.Text;
                obj.Cpf = txtCPF.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Cidade = txtCidade.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cep = txtCEP.Text;
                obj.UF = cbUF.Text;
                obj.id = int.Parse(txtId.Text);

                // passo 2 - Criar o objeto DAO

                ClienteDAO dao = new ClienteDAO();
                dao.excluir(obj);
                MessageBox.Show("Registro excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaCliente.DataSource = dao.ListarTodosClientes();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir, tente novamente: " + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        // MÉTODO PARA CLICAR NA TABELA CLIENTE (DATA GRID VIEW) E SELECIONAR O NOME PARA MOSTRAR NA TELA E ALTERAR
        private void tabelaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            cbSexo.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtCPF.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            cbUF.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtCEP.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            cbSexo.Text = "";
            txtCPF.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            cbUF.Text = "";
            txtNome.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        public void grid()
        {
            //SqlDataAdapter da = new SqlDataAdapter(sqlConsulta);
            DataSet ds = new DataSet();
            // da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            tabelaCliente.DataSource = dt;
        }

        // BOTÃO OK - PESQUISAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Cliente obj = new Cliente();
                ClienteDAO dao = new ClienteDAO();

                if (cbPesquisar.Text == "Buscar por Nome")
                {
                    obj.Nome = txtNome.Text;
                    tabelaCliente.DataSource = dao.buscarPorNome(obj);
                }

                else if (cbPesquisar.Text == "Buscar por CPF")
                {
                    obj.Cpf = txtCPF.Text;
                    tabelaCliente.DataSource = dao.buscarPorCpf(obj);
                }
                else
                {
                    tabelaCliente.DataSource = dao.ListarTodosClientes();
                }                                  
               

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }


        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void cbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

        // private void button1_Click(object sender, EventArgs e)

        //private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)




    


