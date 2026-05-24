namespace SistemaSupermercado
{
    partial class FormCadastro
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
            btnAlterarImagem = new Button();
            btnAdicionarImagem = new Button();
            pbProduto = new PictureBox();
            btnLimpar = new Button();
            btnTeste = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            dgvProdutos = new DataGridView();
            dtpCadastro = new DateTimePicker();
            lblData = new Label();
            txtPreco = new TextBox();
            numQuantidade = new NumericUpDown();
            cmbCategoria = new ComboBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            lblCategoria = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // btnAlterarImagem
            // 
            btnAlterarImagem.Location = new Point(500, 224);
            btnAlterarImagem.Name = "btnAlterarImagem";
            btnAlterarImagem.Size = new Size(75, 23);
            btnAlterarImagem.TabIndex = 48;
            btnAlterarImagem.Text = "Alterar";
            btnAlterarImagem.UseVisualStyleBackColor = true;
            btnAlterarImagem.Click += btnAlterarImagem_Click;
            // 
            // btnAdicionarImagem
            // 
            btnAdicionarImagem.Location = new Point(419, 224);
            btnAdicionarImagem.Name = "btnAdicionarImagem";
            btnAdicionarImagem.Size = new Size(75, 23);
            btnAdicionarImagem.TabIndex = 47;
            btnAdicionarImagem.Text = "Adicionar Imagem";
            btnAdicionarImagem.UseVisualStyleBackColor = true;
            btnAdicionarImagem.Click += btnAdicionarImagem_Click;
            // 
            // pbProduto
            // 
            pbProduto.Location = new Point(364, 74);
            pbProduto.Name = "pbProduto";
            pbProduto.Size = new Size(272, 144);
            pbProduto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProduto.TabIndex = 46;
            pbProduto.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(536, 248);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 34);
            btnLimpar.TabIndex = 45;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(479, 19);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(157, 23);
            btnTeste.TabIndex = 44;
            btnTeste.Text = "Teste Conexão Banco";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(436, 248);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 34);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(255, 192, 128);
            btnAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(334, 248);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(100, 34);
            btnAtualizar.TabIndex = 41;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumSeaGreen;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(7, 248);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(326, 34);
            btnCadastrar.TabIndex = 40;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.BackgroundColor = SystemColors.ButtonFace;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(7, 288);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(629, 158);
            dgvProdutos.TabIndex = 39;
            // 
            // dtpCadastro
            // 
            dtpCadastro.Location = new Point(134, 212);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(200, 23);
            dtpCadastro.TabIndex = 38;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(8, 215);
            lblData.Name = "lblData";
            lblData.Size = new Size(105, 20);
            lblData.TabIndex = 37;
            lblData.Text = "Data Cadastro";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(186, 183);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(148, 23);
            txtPreco.TabIndex = 36;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(186, 156);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(148, 23);
            numQuantidade.TabIndex = 35;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(185, 130);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(148, 23);
            cmbCategoria.TabIndex = 34;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(185, 102);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(148, 23);
            txtNome.TabIndex = 33;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(185, 74);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(148, 23);
            txtCodigo.TabIndex = 32;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(8, 186);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(79, 20);
            lblPreco.TabIndex = 31;
            lblPreco.Text = "Preço (R$)";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(8, 159);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(172, 20);
            lblQuantidade.TabIndex = 30;
            lblQuantidade.Text = "Quantidade em Estoque";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(8, 133);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(75, 20);
            lblCategoria.TabIndex = 29;
            lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(7, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(133, 20);
            lblNome.TabIndex = 28;
            lblNome.Text = "Nome do Produto";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(7, 80);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(140, 20);
            lblCodigo.TabIndex = 27;
            lblCodigo.Text = "Código do Produto";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(12, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(361, 20);
            lblSubtitulo.TabIndex = 26;
            lblSubtitulo.Text = "Cadastre, edite ou remova produtos do seu estoque";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 30);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "Cadastro de Produtos";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 451);
            Controls.Add(btnAlterarImagem);
            Controls.Add(btnAdicionarImagem);
            Controls.Add(pbProduto);
            Controls.Add(btnLimpar);
            Controls.Add(btnTeste);
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
            Name = "FormCadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pbProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlterarImagem;
        private Button btnAdicionarImagem;
        private PictureBox pbProduto;
        private Button btnLimpar;
        private Button btnTeste;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private DataGridView dgvProdutos;
        private DateTimePicker dtpCadastro;
        private Label lblData;
        private TextBox txtPreco;
        private NumericUpDown numQuantidade;
        private ComboBox cmbCategoria;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lblPreco;
        private Label lblQuantidade;
        private Label lblCategoria;
        private Label lblNome;
        private Label lblCodigo;
        private Label lblSubtitulo;
        private Label lblTitulo;
    }
}