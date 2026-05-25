namespace SistemaSupermercado
{
    partial class FormHome
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
            panelLogo = new Panel();
            btnCadastro = new FontAwesome.Sharp.IconButton();
            btnCompras = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            panelConteudo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogo.BackgroundImage = Properties.Resources._5766127_supermercado_loja_logo_vetor;
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ForeColor = Color.Transparent;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(143, 140);
            panelLogo.TabIndex = 1;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // btnCadastro
            // 
            btnCadastro.Dock = DockStyle.Top;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCadastro.ForeColor = Color.WhiteSmoke;
            btnCadastro.IconChar = FontAwesome.Sharp.IconChar.Marker;
            btnCadastro.IconColor = Color.White;
            btnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastro.IconSize = 32;
            btnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastro.Location = new Point(0, 140);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(143, 45);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastro";
            btnCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCompras.ForeColor = Color.WhiteSmoke;
            btnCompras.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnCompras.IconColor = Color.White;
            btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompras.IconSize = 32;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 185);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(143, 45);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(255, 128, 0);
            panelMenu.Controls.Add(btnSair);
            panelMenu.Controls.Add(btnCompras);
            panelMenu.Controls.Add(btnCadastro);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(143, 514);
            panelMenu.TabIndex = 21;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Top;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.WhiteSmoke;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.X;
            btnSair.IconColor = Color.White;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 32;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 230);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(143, 45);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.AutoSize = true;
            panelConteudo.BackColor = Color.FromArgb(255, 224, 192);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(143, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(702, 514);
            panelConteudo.TabIndex = 22;
            panelConteudo.Paint += panelConteudo_Paint;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 514);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Name = "FormHome";
            Text = "Home";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCadastro;
        private FontAwesome.Sharp.IconButton btnCompras;
        private Panel panelMenu;
        private Panel panelConteudo;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}
