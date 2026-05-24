namespace SistemaSupermercado
{
    partial class FormVendas
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
            components = new System.ComponentModel.Container();
            cmbProdutos = new ComboBox();
            gboxAddCarrinho = new GroupBox();
            btnLimpar = new Button();
            btnAdicionar = new Button();
            numQuantidade = new NumericUpDown();
            label1 = new Label();
            lblProduto = new Label();
            conexaoBindingSource = new BindingSource(components);
            dgvCarrinho = new DataGridView();
            conexaoBindingSource1 = new BindingSource(components);
            lblTotal = new Label();
            btnFinalizar = new Button();
            txtNota = new TextBox();
            lblTituloVenda = new Label();
            colProduto = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            gboxAddCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(8, 52);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(281, 28);
            cmbProdutos.TabIndex = 0;
            // 
            // gboxAddCarrinho
            // 
            gboxAddCarrinho.BackColor = Color.Transparent;
            gboxAddCarrinho.Controls.Add(btnLimpar);
            gboxAddCarrinho.Controls.Add(btnAdicionar);
            gboxAddCarrinho.Controls.Add(numQuantidade);
            gboxAddCarrinho.Controls.Add(label1);
            gboxAddCarrinho.Controls.Add(lblProduto);
            gboxAddCarrinho.Controls.Add(cmbProdutos);
            gboxAddCarrinho.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxAddCarrinho.ForeColor = Color.Blue;
            gboxAddCarrinho.Location = new Point(11, 272);
            gboxAddCarrinho.Name = "gboxAddCarrinho";
            gboxAddCarrinho.RightToLeft = RightToLeft.No;
            gboxAddCarrinho.Size = new Size(297, 197);
            gboxAddCarrinho.TabIndex = 1;
            gboxAddCarrinho.TabStop = false;
            gboxAddCarrinho.Text = "Adicionar Ao Carrinho";
            gboxAddCarrinho.Enter += groupBox1_Enter;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.SlateGray;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(8, 154);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(88, 34);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.RoyalBlue;
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(102, 154);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(187, 33);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(8, 109);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(88, 27);
            numQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 86);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Produto:";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.ForeColor = Color.Black;
            lblProduto.Location = new Point(8, 29);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(70, 20);
            lblProduto.TabIndex = 1;
            lblProduto.Text = "Produto:";
            // 
            // conexaoBindingSource
            // 
            conexaoBindingSource.DataSource = typeof(Conexao);
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.BackgroundColor = SystemColors.ButtonFace;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Columns.AddRange(new DataGridViewColumn[] { colProduto, colQuantidade, colValor, colSubtotal });
            dgvCarrinho.Location = new Point(11, 48);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.Size = new Size(307, 205);
            dgvCarrinho.TabIndex = 2;
            dgvCarrinho.CellContentClick += dataGridView1_CellContentClick;
            // 
            // conexaoBindingSource1
            // 
            conexaoBindingSource1.DataSource = typeof(Conexao);
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(317, 378);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(321, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:                                       R$ 0,00";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.YellowGreen;
            btnFinalizar.FlatStyle = FlatStyle.Popup;
            btnFinalizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(317, 426);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(330, 33);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(324, 48);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(323, 320);
            txtNota.TabIndex = 6;
            // 
            // lblTituloVenda
            // 
            lblTituloVenda.AutoSize = true;
            lblTituloVenda.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVenda.Location = new Point(11, 9);
            lblTituloVenda.Name = "lblTituloVenda";
            lblTituloVenda.Size = new Size(178, 30);
            lblTituloVenda.TabIndex = 27;
            lblTituloVenda.Text = "Pedido de Venda";
            // 
            // colProduto
            // 
            colProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colProduto.Frozen = true;
            colProduto.HeaderText = "Produto";
            colProduto.Name = "colProduto";
            colProduto.ReadOnly = true;
            colProduto.Resizable = DataGridViewTriState.True;
            colProduto.Width = 53;
            // 
            // colQuantidade
            // 
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.Name = "colQuantidade";
            colQuantidade.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 472);
            Controls.Add(lblTituloVenda);
            Controls.Add(txtNota);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotal);
            Controls.Add(dgvCarrinho);
            Controls.Add(gboxAddCarrinho);
            Name = "FormVendas";
            Text = "FormVendas";
            Load += FormVendas_Load;
            gboxAddCarrinho.ResumeLayout(false);
            gboxAddCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProdutos;
        private GroupBox gboxAddCarrinho;
        private Button btnAdicionar;
        private NumericUpDown numQuantidade;
        private Label label1;
        private Label lblProduto;
        private BindingSource conexaoBindingSource;
        private DataGridView dgvCarrinho;
        private Label lblTotal;
        private Button btnFinalizar;
        private TextBox txtNota;
        private Label lblTituloVenda;
        private Button btnLimpar;
        private BindingSource conexaoBindingSource1;
        private DataGridViewImageColumn colmagem;
        private DataGridViewTextBoxColumn colProduto;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colSubtotal;
    }
}