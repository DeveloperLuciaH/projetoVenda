using aula3_Venda.br.com.projeto.dao;
using aula3_Venda.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3_Venda
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // BOTÃO CADASTRAR
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
               Fornecedor obj = new Fornecedor();

                obj.RazaoSocial = txtRazaoSocial.Text;               
                obj.Cnpj = txtCnpj.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.UF = cbUF.Text;
                obj.Cep = txtCep.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Email = txtEmail.Text;

                // passo 2 - Criar o objeto DAO

                FornecedorDAO dao = new FornecedorDAO();
                dao.cadastrar(obj);
                MessageBox.Show("Fornecedor cadastrado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaFornecedor.DataSource = dao.ListarTodosFornecedores();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar, tente novamente." + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÃO ALTERAR
        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            try
            {
                // passo 1 - pegar os dados da tela
                Fornecedor obj = new Fornecedor();

                obj.RazaoSocial = txtRazaoSocial.Text;
                obj.Cnpj = txtCnpj.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.UF = cbUF.Text;
                obj.Cep = txtCep.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Email = txtEmail.Text;
                obj.id = int.Parse(txtId.Text);

                // passo 2 - Criar o objeto DAO

                FornecedorDAO dao = new FornecedorDAO();
                dao.alterar(obj);
                MessageBox.Show("Cadastro alterado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaFornecedor.DataSource = dao.ListarTodosFornecedores();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar, tente novamente." + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // BOTÃO EXCLUIR
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Fornecedor obj = new Fornecedor();

                obj.RazaoSocial = txtRazaoSocial.Text;
                obj.Cnpj = txtCnpj.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.UF = cbUF.Text;
                obj.Cep = txtCep.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Email = txtEmail.Text;
                obj.id = int.Parse(txtId.Text);

                // passo 2 - Criar o objeto DAO

                FornecedorDAO dao = new FornecedorDAO();
                dao.excluir(obj);
                MessageBox.Show("Cadastro excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaFornecedor.DataSource = dao.ListarTodosFornecedores();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir, tente novamente." + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // BOTÃO LIMPAR
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbUF.Text = "";
            txtCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtRazaoSocial.Focus();
        }

        // MÉTODO PARA CLICAR NA TABELA FORNECEDOR (DATA GRID VIEW) E SELECIONAR A RAZÃO SOCIAL PARA MOSTRAR NA TELA E ALTERAR
        private void tabelaFornecedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtRazaoSocial.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtBairro.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCidade.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            cbUF.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtEmail.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();



        }
        // BOTÃO OK - PESQUISAR
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Fornecedor obj = new Fornecedor();
                FornecedorDAO dao = new FornecedorDAO();

                if (cbPesquisar.Text == "Buscar por Razao Social")
                {
                    obj.RazaoSocial = txtRazaoSocial.Text;
                    tabelaFornecedor.DataSource = dao.buscarPorRazaoSocial(obj);
                }

                else if (cbPesquisar.Text == "Buscar por CNPJ")
                {
                    obj.Cnpj = txtCnpj.Text;
                    tabelaFornecedor.DataSource = dao.BuscaFornecedorPorCnpj(obj);
                }
                else
                {
                    tabelaFornecedor.DataSource = dao.ListarTodosFornecedores();
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // tabelaCliente é o nome do DataGridView onde irá listar todos os clientes
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedor.DataSource = dao.ListarTodosFornecedores();
        }
    }
}

