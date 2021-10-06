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

namespace aula3_Venda.br.com.projeto.views
{
    public partial class FrmVenda : Form
    {
        double subtotal = 0;
        double total;
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            subtotal = double.Parse(txtQtd.Text) * double.Parse(txtPrecoUnitario.Text);
            DataGridViewRow row = (DataGridViewRow)TabelaVenda.Rows[0].Clone();
            row.Cells[0].Value = txtCodigo.Text;
            row.Cells[1].Value = txtProduto.Text;
            row.Cells[2].Value = txtPrecoUnitario.Text;
            row.Cells[3].Value = txtQtd.Text;
            row.Cells[4].Value = subtotal;
            TabelaVenda.Rows.Add(row);
            total += subtotal;
            txtTotal.Text = total.ToString();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Cliente obj = new Cliente();
                ClienteDAO dao = new ClienteDAO();

                obj = dao.BuscaClientePorCpf(txtCPF.Text);

                if(obj.Nome != null)
                {
                    txtNome.Text = obj.Nome;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Produto obj = new Produto();
                ProdutoDAO dao = new ProdutoDAO();

                obj = dao.buscarProdutoPorId(int.Parse(txtCodigo.Text));

                if(obj.Descricao != null)
                {
                    txtProduto.Text = obj.Descricao;
                    txtPrecoUnitario.Text = obj.ValorVenda.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
