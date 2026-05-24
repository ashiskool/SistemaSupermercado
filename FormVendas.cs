using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaSupermercado
{
    public partial class FormVendas : Form
    {
        // Variavel responsavel por armazenar o valor total da compra 

        double totalCompra = 0;

        public FormVendas()
        {
            InitializeComponent();

            CarregarProdutos();
        }

        // CARREGAR PRODUTOS NO COMBOBOX AO ABRIR O FORMULARIO

        public void CarregarProdutos()
        {
            try
            {
                string sql = "SELECT * FROM produtos";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, Conexao.Abrir());

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbProdutos.DataSource = dt;

                cmbProdutos.DisplayMember = "nome";

                cmbProdutos.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // ADICIONAR PRODUTO NO CARRINHO

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Nome do produto selecionado

                string produto =
                    cmbProdutos.Text;

                // Quantidade escolhida

                int quantidade =
                    Convert.ToInt32(numQuantidade.Value);

                // Busca o preco do produto no banco

                string sql =
                    "SELECT preco FROM produtos WHERE codigo=@codigo";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao.Abrir());

                cmd.Parameters.AddWithValue(
                    "@codigo",
                    cmbProdutos.SelectedValue);

                double preco =
                    Convert.ToDouble(cmd.ExecuteScalar());

                // Calcular subtotal da compra

                double subtotal =
                    preco * quantidade;

                // Adicionar linha no DGV

                dgvCarrinho.Rows.Add(
                    produto,
                    quantidade,
                    preco,
                    subtotal);

                // Atualizar valor total da compra

                totalCompra += subtotal;

                lblTotal.Text =
                    "Total: R$ " +
                    totalCompra.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nota = "";

                nota += "SUPERMERCADO";
                nota += Environment.NewLine;

                nota +=
                    "Data: " +
                    DateTime.Now.ToString();

                nota += Environment.NewLine;
                nota += Environment.NewLine;

                // Percorre todas as linhas do carrinho

                for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                {
                    if (dgvCarrinho.Rows[i].Cells[0].Value != null)
                    {
                        string produto =
                            dgvCarrinho.Rows[i].Cells[0].Value.ToString();

                        string quantidade =
                            dgvCarrinho.Rows[i].Cells[1].Value.ToString();

                        string subtotal =
                            dgvCarrinho.Rows[i].Cells[3].Value.ToString();

                        // Adiciona item na nota

                        nota +=
                        produto +
                        " | Qtd: " +
                        quantidade +
                        " | Subtotal: R$ " +
                        subtotal +
                        Environment.NewLine;

                        // DIMINUIR ESTOQUE NO BANCO

                        string sqlEstoque =
                            "UPDATE produtos " +
                            "SET quantidade = quantidade - @quantidade " +
                            "WHERE nome = @nome";

                        MySqlCommand cmdEstoque =
                            new MySqlCommand(sqlEstoque, Conexao.Abrir());

                        cmdEstoque.Parameters.AddWithValue(
                            "@quantidade",
                            Convert.ToInt32(quantidade));

                        cmdEstoque.Parameters.AddWithValue(
                            "@nome",
                            produto);

                        cmdEstoque.ExecuteNonQuery();
                    }
                }

                nota += Environment.NewLine;

                nota +=
                    "TOTAL DA COMPRA: R$ " +
                    totalCompra.ToString("F2");

                // ABRIR TELA DA NOTA

                FormNota telaNota =
                    new FormNota(nota);

                telaNota.ShowDialog();

                MessageBox.Show(
                    "Compra finalizada com sucesso!");

                // Limpa carrinho

                dgvCarrinho.Rows.Clear();

                totalCompra = 0;

                lblTotal.Text = "Total: R$ 0,00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao finalizar compra: " +
                    ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvCarrinho.Rows.Clear();

            lblTotal.Text = "0,00";

            txtNota.Clear();

            totalCompra = 0;
        }
    }
}