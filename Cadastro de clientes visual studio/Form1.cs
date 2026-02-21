using Npgsql;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Cadastro_de_clientes_visual_studio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Handler required by the designer (label1.Click += this.label1_Click)
        private void label1_Click(object sender, EventArgs e)
        {
            // intentionally left empty
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validacoes() == true)
            {
                return;
            }

            SalvarClientePostgreSql();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=postgres;password=Pudimamassado1@;database=CadastroClientes";
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            string query = "SELECT id, nome, documento FROM public.\"ClientesInformacoes\" ORDER BY id ASC;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=postgres;password=Pudimamassado1@;database=CadastroClientes";
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            string query = "INSERT INTO public.\"ClientesInformacoes\" (nome, documento, gênero, rg, estado_civil, data_nascimento, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao) VALUES (@nome, @documento, @gênero, @rg, @estado_civil, @data_nascimento, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao );";
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome", txtname.Text);
            cmd.Parameters.AddWithValue("@documento", maskeddoc.Text);

            cmd.Parameters.AddWithValue("@gênero", "Genero");

            cmd.Parameters.AddWithValue("@rg", maskedrg.Text);
            cmd.Parameters.AddWithValue("@estado_civil", combocivil.Text);

            cmd.Parameters.AddWithValue("@data_nascimento", maskeddata.Text);

            cmd.Parameters.AddWithValue("@cep", maskedcep.Text);
            cmd.Parameters.AddWithValue("@endereco", textendereco.Text);
            cmd.Parameters.AddWithValue("@numero", textnum.Text);
            cmd.Parameters.AddWithValue("@bairro", textbairro.Text);
            cmd.Parameters.AddWithValue("@cidade", combocidade.Text);
            cmd.Parameters.AddWithValue("@estado", comboestado.Text);
            cmd.Parameters.AddWithValue("@celular", maskedcel.Text);
            cmd.Parameters.AddWithValue("@email", textemail.Text);
            cmd.Parameters.AddWithValue("@obs", textobs.Text);

            cmd.Parameters.AddWithValue("@situacao", "Ativo");
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Cliente inserido com sucesso!");


            button2_Click(sender, e);


            txtname.Clear();
            maskeddoc.Clear();
        }

        private void SalvarClientePostgreSql()
        {
            string constring = "server=localhost;user id=postgres;password=Pudimamassado1@;database=CadastroClientes";
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            string query = "INSERT INTO public.\"ClientesInformacoes\" (nome, documento, gênero, rg, estado_civil, data_nascimento, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao) VALUES (@nome, @documento, @gênero, @rg, @estado_civil, @data_nascimento, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao );";
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome", txtname.Text);
            cmd.Parameters.AddWithValue("@documento", maskeddoc.Text);

            if (radiomasc.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gênero", "Masculino");
            }
            else if (radiofem.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gênero", "Feminino");
            }
            else
            {
                cmd.Parameters.AddWithValue("@gênero", "Outros");
            }

            cmd.Parameters.AddWithValue("@rg", maskedrg.Text);
            cmd.Parameters.AddWithValue("@estado_civil", combocivil.Text);

            cmd.Parameters.AddWithValue("@data_nascimento", maskeddata.Text);

            cmd.Parameters.AddWithValue("@cep", maskedcep.Text);
            cmd.Parameters.AddWithValue("@endereco", textendereco.Text);
            cmd.Parameters.AddWithValue("@numero", textnum.Text);
            cmd.Parameters.AddWithValue("@bairro", textbairro.Text);
            cmd.Parameters.AddWithValue("@cidade", combocidade.Text);
            cmd.Parameters.AddWithValue("@estado", comboestado.Text);
            cmd.Parameters.AddWithValue("@celular", maskedcel.Text);
            cmd.Parameters.AddWithValue("@email", textemail.Text);
            cmd.Parameters.AddWithValue("@obs", textobs.Text);

            if (checkativo.Checked == true)
            {
                cmd.Parameters.AddWithValue("@situacao", "Ativo");
            }
            else
            {
                cmd.Parameters.AddWithValue("@situacao", "Inativo");
            }

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Cliente inserido com sucesso!");
        }

        private bool Validacoes()
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("O campo 'Nome' é obrigatório.");
                txtname.Focus();
                return true;
            }

            if (radiocpf.Checked == false && radiocnpj.Checked == false)
            {
                MessageBox.Show("Selecione o tipo de documento\r(CPF ou CNPJ).");
                return true;
            }

            if (maskeddoc.Text == "")
            {
                if (radiocpf.Checked == true)
                {
                    MessageBox.Show("O campo 'CPF' é obrigatório.");
                }
                else
                {
                    MessageBox.Show("O campo 'CNPJ' é obrigatório.");
                    maskeddoc.Focus();
                    return true;
                }

                if (radiomasc.Checked == false && radiofem.Checked == false && radiooutros.Checked == false)
                {
                    MessageBox.Show("Selecione o gênero.");
                    return true;
                } 


            }
            return false;
        }
    }
}
