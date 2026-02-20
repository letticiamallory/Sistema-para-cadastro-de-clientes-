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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=postgres;password=Pudimamassado1@;database=CadastroClientes";
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string query = "SELECT id, nome, documento FROM public.\"ClientesInformacoes\";";
            NpgsqlCommand cmd = new NpgsqlCommand (query, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
