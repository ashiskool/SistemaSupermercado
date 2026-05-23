namespace SistemaSupermercado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCodigo = new Label();
            lblNome = new Label();
            lblCategoria = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            cmbCategoria = new ComboBox();
            numQuantidade = new NumericUpDown();
            txtPreco = new TextBox();
            lblData = new Label();
            dtpCadastro = new DateTimePicker();
            dgvProdutos = new DataGridView();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnVendas = new Button();
            btnTeste = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(308, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Produtos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(224, 39);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(361, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Cadastre, edite ou remova produtos do seu estoque";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(22, 85);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(140, 20);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código do Produto";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(22, 113);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(133, 20);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome do Produto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(23, 138);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(75, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(23, 164);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(172, 20);
            lblQuantidade.TabIndex = 5;
            lblQuantidade.Text = "Quantidade em Estoque";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(23, 191);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(79, 20);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço (R$)";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(200, 79);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(148, 23);
            txtCodigo.TabIndex = 7;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(200, 107);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(148, 23);
            txtNome.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(200, 135);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(148, 23);
            cmbCategoria.TabIndex = 9;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(201, 161);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(148, 23);
            numQuantidade.TabIndex = 10;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(201, 188);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(148, 23);
            txtPreco.TabIndex = 11;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(23, 220);
            lblData.Name = "lblData";
            lblData.Size = new Size(105, 20);
            lblData.TabIndex = 12;
            lblData.Text = "Data Cadastro";
            // 
            // dtpCadastro
            // 
            dtpCadastro.Location = new Point(149, 217);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(200, 23);
            dtpCadastro.TabIndex = 13;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(22, 293);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(629, 158);
            dgvProdutos.TabIndex = 14;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(22, 253);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(326, 34);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(255, 192, 128);
            btnAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(349, 253);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(100, 34);
            btnAtualizar.TabIndex = 16;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(451, 253);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 34);
            btnExcluir.TabIndex = 17;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.CornflowerBlue;
            btnVendas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(670, 388);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(157, 34);
            btnVendas.TabIndex = 18;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(670, 428);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(157, 23);
            btnTeste.TabIndex = 19;
            btnTeste.Text = "Teste Conexão Banco";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click_1;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(551, 253);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 34);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 466);
            Controls.Add(btnLimpar);
            Controls.Add(btnTeste);
            Controls.Add(btnVendas);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvProdutos);
            Controls.Add(dtpCadastro);
            Controls.Add(lblData);
            Controls.Add(txtPreco);
            Controls.Add(numQuantidade);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblCategoria);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblCategoria;
        private Label lblQuantidade;
        private Label lblPreco;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private ComboBox cmbCategoria;
        private NumericUpDown numQuantidade;
        private TextBox txtPreco;
        private Label lblData;
        private DateTimePicker dtpCadastro;
        private DataGridView dgvProdutos;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnVendas;
        private Button btnTeste;
        private Button btnLimpar;
    }
}
