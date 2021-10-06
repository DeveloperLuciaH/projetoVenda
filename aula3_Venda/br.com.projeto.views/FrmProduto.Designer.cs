
namespace aula3_Venda
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDadosProduto = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.tabelaProduto = new System.Windows.Forms.DataGridView();
            this.gbDadosProduto.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.gbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosProduto
            // 
            this.gbDadosProduto.Controls.Add(this.txtQuantidade);
            this.gbDadosProduto.Controls.Add(this.txtMargem);
            this.gbDadosProduto.Controls.Add(this.label10);
            this.gbDadosProduto.Controls.Add(this.cbFornecedor);
            this.gbDadosProduto.Controls.Add(this.label8);
            this.gbDadosProduto.Controls.Add(this.txtValorVenda);
            this.gbDadosProduto.Controls.Add(this.txtValorCompra);
            this.gbDadosProduto.Controls.Add(this.txtDescricao);
            this.gbDadosProduto.Controls.Add(this.txtId);
            this.gbDadosProduto.Controls.Add(this.label5);
            this.gbDadosProduto.Controls.Add(this.label4);
            this.gbDadosProduto.Controls.Add(this.label3);
            this.gbDadosProduto.Controls.Add(this.label2);
            this.gbDadosProduto.Controls.Add(this.label1);
            this.gbDadosProduto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosProduto.Location = new System.Drawing.Point(28, 42);
            this.gbDadosProduto.Name = "gbDadosProduto";
            this.gbDadosProduto.Size = new System.Drawing.Size(600, 247);
            this.gbDadosProduto.TabIndex = 2;
            this.gbDadosProduto.TabStop = false;
            this.gbDadosProduto.Text = "Dados do Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(440, 127);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(136, 22);
            this.txtQuantidade.TabIndex = 22;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // txtMargem
            // 
            this.txtMargem.Location = new System.Drawing.Point(144, 127);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(119, 22);
            this.txtMargem.TabIndex = 21;
            this.txtMargem.TextChanged += new System.EventHandler(this.txtMargem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(15, 195);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(248, 24);
            this.cbFornecedor.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quantidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(283, 127);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(130, 22);
            this.txtValorVenda.TabIndex = 9;
            this.txtValorVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValorVenda_MouseClick);
            this.txtValorVenda.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(15, 127);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(103, 22);
            this.txtValorCompra.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(90, 52);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(486, 22);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(15, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 22);
            this.txtId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor da Venda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Margem de Lucro %";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor da Compra";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Salvar.Location = new System.Drawing.Point(21, 64);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 37);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "SALVAR";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(398, 28);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(381, 22);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(315, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cadastro de Produtos";
            // 
            // gbAcoes
            // 
            this.gbAcoes.Controls.Add(this.btnNovo);
            this.gbAcoes.Controls.Add(this.btn_Limpar);
            this.gbAcoes.Controls.Add(this.btn_Salvar);
            this.gbAcoes.Controls.Add(this.btn_Excluir);
            this.gbAcoes.Controls.Add(this.btn_Alterar);
            this.gbAcoes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcoes.Location = new System.Drawing.Point(646, 42);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(180, 247);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovo.Location = new System.Drawing.Point(21, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 37);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "NOVO ";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Limpar.Location = new System.Drawing.Point(21, 195);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(140, 37);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Excluir.Location = new System.Drawing.Point(21, 151);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(140, 38);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Alterar.Location = new System.Drawing.Point(21, 107);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(140, 38);
            this.btn_Alterar.TabIndex = 0;
            this.btn_Alterar.Text = "ALTERAR";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.label6);
            this.gbPesquisar.Controls.Add(this.cbPesquisar);
            this.gbPesquisar.Controls.Add(this.tabelaProduto);
            this.gbPesquisar.Controls.Add(this.txtPesquisar);
            this.gbPesquisar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisar.Location = new System.Drawing.Point(28, 295);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(798, 187);
            this.gbPesquisar.TabIndex = 5;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Dados da Pesquisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Filtro";
            // 
            // cbPesquisar
            // 
            this.cbPesquisar.FormattingEnabled = true;
            this.cbPesquisar.Items.AddRange(new object[] {
            "buscarPorDescricao",
            "buscarPorFornecedor",
            "          "});
            this.cbPesquisar.Location = new System.Drawing.Point(66, 25);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(301, 24);
            this.cbPesquisar.TabIndex = 20;
            // 
            // tabelaProduto
            // 
            this.tabelaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProduto.Location = new System.Drawing.Point(6, 72);
            this.tabelaProduto.Name = "tabelaProduto";
            this.tabelaProduto.Size = new System.Drawing.Size(773, 140);
            this.tabelaProduto.TabIndex = 1;
            this.tabelaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProduto_CellContentClick);
            this.tabelaProduto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProduto_CellContentDoubleClick);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 519);
            this.Controls.Add(this.gbPesquisar);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbDadosProduto);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.gbDadosProduto.ResumeLayout(false);
            this.gbDadosProduto.PerformLayout();
            this.gbAcoes.ResumeLayout(false);
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDadosProduto;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.DataGridView tabelaProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}