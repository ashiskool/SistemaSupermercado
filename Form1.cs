using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaSupermercado
{
    public partial class FormHome : Form
    {


        public FormHome()
        {
            InitializeComponent();

        }
        private void AbrirFormNoPainel(object formFilho)
        {
            // Se já houver um Form aberto no painel, fecha ele para liberar memória
            if (this.panelConteudo.Controls.Count > 0)
                this.panelConteudo.Controls[0].Dispose();

            Form fh = formFilho as Form;
            if (fh != null)
            {
                fh.TopLevel = false; // Essencial: diz que o form não é uma janela independente
                fh.FormBorderStyle = FormBorderStyle.None; // Remove a barra de título do form filho
                fh.Dock = DockStyle.Fill; // Faz o form preencher todo o painel

                this.panelConteudo.Controls.Add(fh); // Adiciona o form ao painel
                this.panelConteudo.Tag = fh;
                fh.Show(); // Exibe o form
            }
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new FormCadastro());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new FormVendas());
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}