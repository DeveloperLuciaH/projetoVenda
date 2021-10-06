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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto p = new FrmProduto();
            p.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor f = new FrmFornecedor();
            f.Show();
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanoConta pc = new FrmPlanoConta();
            pc.Show();
        }
    }
}
