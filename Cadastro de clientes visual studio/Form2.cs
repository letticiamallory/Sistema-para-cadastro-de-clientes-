using Npgsql;
using System.Data;

namespace Cadastro_de_clientes_visual_studio
{
    public partial class Form2 : Form
    {
        string constring = "server=localhost;user id=postgres;password=Pudimamassado1@;database=CadastroClientes";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarClientes();
        }

        private void ConfigurarGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.HeaderText = "Código";
            colId.DataPropertyName = "id";
            colId.Width = 60;
            dgvClientes.Columns.Add(colId);

            DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
            colNome.Name = "colNome";
            colNome.HeaderText = "Nome";
            colNome.DataPropertyName = "nome";
            colNome.Width = 200;
            dgvClientes.Columns.Add(colNome);

            DataGridViewTextBoxColumn colDocumento = new DataGridViewTextBoxColumn();
            colDocumento.Name = "colDocumento";
            colDocumento.HeaderText = "CPF/CNPJ";
            colDocumento.DataPropertyName = "documento";
            colDocumento.Width = 140;
            dgvClientes.Columns.Add(colDocumento);

            DataGridViewTextBoxColumn colCelular = new DataGridViewTextBoxColumn();
            colCelular.Name = "colCelular";
            colCelular.HeaderText = "Celular";
            colCelular.DataPropertyName = "celular";
            colCelular.Width = 120;
            dgvClientes.Columns.Add(colCelular);

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "colEmail";
            colEmail.HeaderText = "E-mail";
            colEmail.DataPropertyName = "email";
            colEmail.Width = 180;
            dgvClientes.Columns.Add(colEmail);

            DataGridViewTextBoxColumn colCidade = new DataGridViewTextBoxColumn();
            colCidade.Name = "colCidade";
            colCidade.HeaderText = "Cidade";
            colCidade.DataPropertyName = "cidade";
            colCidade.Width = 130;
            dgvClientes.Columns.Add(colCidade);

            DataGridViewTextBoxColumn colSituacao = new DataGridViewTextBoxColumn();
            colSituacao.Name = "colSituacao";
            colSituacao.HeaderText = "Situação";
            colSituacao.DataPropertyName = "situacao";
            colSituacao.Width = 70;
            dgvClientes.Columns.Add(colSituacao);

            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.BackgroundColor = Color.White;
        }

        private void CarregarClientes()
        {
            string filtro = txtbusca.Text.Trim();

            string sql = "SELECT id, nome, documento, celular, email, cidade, situacao FROM public.\"ClientesInformacoes\"";

            if (filtro != "")
            {
                sql += " WHERE LOWER(nome) LIKE LOWER('%" + filtro + "%') OR documento LIKE '%" + filtro + "%'";
            }

            sql += " ORDER BY nome";

            DataTable dt = Funcoes.BuscaSql(constring, sql);
            dgvClientes.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            CarregarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void txtbusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregarClientes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                Funcoes.MsgAlerta("Selecione um cliente para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["colId"].Value);

            Form1 form1 = new Form1();
            form1.txtid.Text = id.ToString();
            form1.Show();
            this.Hide();

            form1.FormClosed += (s, args) =>
            {
                this.Show();
                CarregarClientes();
            };
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                Funcoes.MsgAlerta("Selecione um cliente para excluir.");
                return;
            }

            string nome = dgvClientes.SelectedRows[0].Cells["colNome"].Value.ToString();
            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["colId"].Value);

            if (Funcoes.Pergunta("Deseja excluir o cliente '" + nome + "'?") == false)
            {
                return;
            }

            using (NpgsqlConnection con = new NpgsqlConnection(constring))
            {
                con.Open();

                using (NpgsqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM public.\"ClientesInformacoes\" WHERE id = " + id;
                    cmd.ExecuteNonQuery();
                }
            }

            string pastaFotos = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";

            if (File.Exists(pastaFotos + id + ".png") == true)
            {
                File.Delete(pastaFotos + id + ".png");
            }

            Funcoes.MsgOk("Cliente excluído com sucesso!");
            CarregarClientes();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["colId"].Value);

            Form1 form1 = new Form1();
            form1.txtid.Text = id.ToString();
            form1.Show();
            this.Hide();

            form1.FormClosed += (s, args) =>
            {
                this.Show();
                CarregarClientes();
            };
        }
    }
}