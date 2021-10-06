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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // CÓDIGO EVENTO DO TEXTCHANGED DO TXT PESQUISAR (DADOS DE PESQUISA
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // VERIFICA A OPÇÃO DE PESQUISA ESCOLHIDA
            string pesquisa = "%" + txtPesquisar.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();
            if (cbPesquisar.SelectedIndex == 0)
            {
                tabelaProduto.DataSource = dao.buscarPorDescricao(pesquisa);
            }
            else
            {
                tabelaProduto.DataSource = dao.buscarPorFornecedor(pesquisa);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //Carrega  comboboxFornecedor
            FornecedorDAO fdao = new FornecedorDAO();
            cbFornecedor.DataSource = fdao.ListarTodosFornecedores();
            cbFornecedor.DisplayMember = "razaosocial";
            cbFornecedor.ValueMember = "id";

            // tabelaProduto é o nome do DataGridView onde irá listar todos os produtos
            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.ListarTodosProdutos();
        }

        //BOTÃO NOVO
        private void button1_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtValorCompra.Clear();
            txtMargem.Clear();
            txtValorVenda.Clear();
            txtQuantidade.Clear();
            txtDescricao.Focus();
        }

       // BOTÃO CADASTRAR
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                p.Descricao = txtDescricao.Text;
                p.ValorCompra = decimal.Parse(txtValorCompra.Text);
                p.Margem = decimal.Parse(txtMargem.Text);
                p.ValorVenda = decimal.Parse(txtValorVenda.Text);
                p.Quantidade = decimal.Parse(txtQuantidade.Text);
                p.id_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());

                ProdutoDAO dao = new ProdutoDAO();
                dao.cadastrarProduto(p);
                MessageBox.Show("Produto cadastrado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaProduto.DataSource = dao.ListarTodosProdutos();
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
                Produto obj = new Produto();

                obj.Descricao = txtDescricao.Text;                
                obj.ValorCompra = decimal.Parse(txtValorCompra.Text);
                obj.Margem = decimal.Parse(txtMargem.Text);
                obj.ValorVenda = decimal.Parse(txtValorVenda.Text);
                obj.Quantidade = decimal.Parse(txtQuantidade.Text);
                //string teste = cbFornecedor.SelectedValue.ToString();
                obj.id_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString()); ;
                //obj.RazaoSocial_Fornecedor = cbFornecedor.Text;                
                obj.id = int.Parse(txtId.Text);

                // passo 2 - Criar o objeto DAO

                ProdutoDAO dao = new ProdutoDAO();
                dao.alterarProduto(obj);
                MessageBox.Show("Produto alterado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabelaProduto.DataSource = dao.ListarTodosProdutos();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar, tente novamente: " + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtMargem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValorVenda_MouseClick(object sender, MouseEventArgs e)
        {
            txtValorVenda.Text = (double.Parse(txtValorCompra.Text) / 100 * double.Parse(txtMargem.Text) + double.Parse(txtValorCompra.Text)).ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtValorCompra.Clear();
            txtMargem.Clear();
            txtValorVenda.Clear();
            txtQuantidade.Clear();
            //txtIdFornecedor.Clear();
            cbFornecedor.Text = "";
            txtDescricao.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                // passo 1 - pegar os dados da tela
                Produto obj = new Produto();

                obj.id = int.Parse(txtId.Text);

                // passo 2 - Criar o objeto DAO

                ProdutoDAO dao = new ProdutoDAO();
                dao.deletarProduto(obj);
                MessageBox.Show("Produto excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelaProduto.DataSource = dao.ListarTodosProdutos();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir, tente novamente: " + erro, "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void tabelaProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            cbFornecedor.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtValorCompra.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            txtMargem.Text = tabelaProduto.CurrentRow.Cells[4].Value.ToString();
            txtValorVenda.Text = tabelaProduto.CurrentRow.Cells[5].Value.ToString();
            txtQuantidade.Text = tabelaProduto.CurrentRow.Cells[6].Value.ToString();
                 
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabelaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
