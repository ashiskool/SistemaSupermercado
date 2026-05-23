using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaSupermercado
{
    public partial class Form1 : Form
    {
        // Variavel utilizada para armazenar o codigo do produto selecionado

        int codigoSelecionado = 0;

        public Form1()
        {
            InitializeComponent();

            // EVENTOS DO DATAGRIDVIEW E DOS BOTOES

            dgvProdutos.CellClick += dgvProdutos_CellClick;

            btnExcluir.Click += btnExcluir_Click;

            btnAtualizar.Click += btnAtualizar_Click;

            btnCadastrar.Click += btnCadastrar_Click;

            // Itens adicionados manualmente no ComboBox de categorias

            cmbCategoria.Items.Add("Alimentos");
            cmbCategoria.Items.Add("Bebidas");
            cmbCategoria.Items.Add("Limpeza");
            cmbCategoria.Items.Add("Higiene");

            // Campo codigo somente leitura

            txtCodigo.ReadOnly = true;

            //  listar os produtos ao abrir o sistema

            ListarProdutos();
        }

        // LISTAR PRODUTOS CADASTRADOS NO BANCO

        public void ListarProdutos()
        {
            try
            {
                string sql = "SELECT * FROM produtos";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, Conexao.Abrir());

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvProdutos.DataSource = dt;

                // Ajusta automaticamente as colunas

                dgvProdutos.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvProdutos.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos: " + ex.Message);
            }
        }

        // EVENTO DO COMBOBOX

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // CADASTRAR PRODUTO

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO produtos " +
                             "(nome, categoria, quantidade, preco, dataCadastro) " +
                             "VALUES (@nome, @categoria, @quantidade, @preco, @data)";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao.Abrir());

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);
                cmd.Parameters.AddWithValue("@quantidade", numQuantidade.Value);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
                cmd.Parameters.AddWithValue("@data", dtpCadastro.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");

                ListarProdutos();

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
        }

        // AO CLICAR EM UMA LINHA DO DATAGRIDVIEW

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProdutos.CurrentRow != null)
                {
                    codigoSelecionado =
                        Convert.ToInt32(
                        dgvProdutos.CurrentRow.Cells["codigo"].Value);

                    // Preenche o codigo automaticamente

                    txtCodigo.Text =
                        codigoSelecionado.ToString();

                    txtNome.Text =
                        dgvProdutos.CurrentRow.Cells["nome"].Value.ToString();

                    cmbCategoria.Text =
                        dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();

                    numQuantidade.Value =
                        Convert.ToDecimal(
                        dgvProdutos.CurrentRow.Cells["quantidade"].Value);

                    txtPreco.Text =
                        dgvProdutos.CurrentRow.Cells["preco"].Value.ToString();

                    dtpCadastro.Value =
                        Convert.ToDateTime(
                        dgvProdutos.CurrentRow.Cells["dataCadastro"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar produto: " + ex.Message);
            }
        }

        // ATUALIZAR PRODUTO

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoSelecionado == 0)
                {
                    MessageBox.Show("Selecione um produto para atualizar.");
                    return;
                }

                string sql = "UPDATE produtos SET " +
                             "nome=@nome, " +
                             "categoria=@categoria, " +
                             "quantidade=@quantidade, " +
                             "preco=@preco, " +
                             "dataCadastro=@data " +
                             "WHERE codigo=@codigo";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao.Abrir());

                cmd.Parameters.AddWithValue("@codigo", codigoSelecionado);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);
                cmd.Parameters.AddWithValue("@quantidade", numQuantidade.Value);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
                cmd.Parameters.AddWithValue("@data", dtpCadastro.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto atualizado com sucesso!");

                ListarProdutos();

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }

        // EXCLUIR PRODUTO

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoSelecionado == 0)
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                    return;
                }

                DialogResult resposta =
                    MessageBox.Show(
                        "Deseja realmente excluir este produto?",
                        "Confirmacao",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    string sql =
                        "DELETE FROM produtos WHERE codigo=@codigo";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, Conexao.Abrir());

                    cmd.Parameters.AddWithValue("@codigo", codigoSelecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto excluido com sucesso!");

                    ListarProdutos();

                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
        }

        // LIMPAR CAMPOS

        public void LimparCampos()
        {
            txtCodigo.Clear();

            txtNome.Clear();

            cmbCategoria.SelectedIndex = -1;

            numQuantidade.Value = 0;

            txtPreco.Clear();

            codigoSelecionado = 0;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        // ABRIR TELA DE VENDAS

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVendas tela = new FormVendas();

            tela.Show();
        }

        // TESTE DA CONEXAO COM O BANCO - Pode ser excluido
        // apenas para teste do banco antes de demais alterações

        private void btnTeste_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao.Abrir();

                MessageBox.Show(
                    "Conexao com o banco OK!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro na conexao: " + ex.Message);
            }
        }

        // botão limpar no form1 para cadastro de novo produto
        // pode ser utilizado para limpar os campos caso queira cadastrar um novo produto sem atualizar ou excluir o selecionado
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}