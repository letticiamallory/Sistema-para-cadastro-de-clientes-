using Npgsql;
using System.Data;
using System.Text.Json;

namespace Cadastro_de_clientes_visual_studio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string constring = "server=localhost;user id=postgres;password=Pudimamassado1@;database=CadastroClientes";
        string pastafotos = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";

        private void Form1_Load(object sender, EventArgs e)
        {
            Funcoes.BuscaSql(constring, "SELECT endereco FROM public.\"ClientesInformacoes\"");

            if (txtid.Text == "")
            {
                return;
            }

            buttonsalvar.Text = "Atualizar";

            using (NpgsqlConnection con = new NpgsqlConnection(constring))
            {
                con.Open();

                using (NpgsqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM public.\"ClientesInformacoes\" WHERE id = " + txtid.Text;

                    DataTable dt = new DataTable();

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);

                        txtname.Text = dt.Rows[0]["nome"].ToString();
                        combocivil.Text = dt.Rows[0]["estado_civil"].ToString();
                        maskeddata.Text = dt.Rows[0]["data_nascimento"].ToString();
                        maskedcep.Text = dt.Rows[0]["cep"].ToString();
                        textendereco.Text = dt.Rows[0]["endereco"].ToString();
                        textnum.Text = dt.Rows[0]["numero"].ToString();
                        textbairro.Text = dt.Rows[0]["bairro"].ToString();
                        combocidade.Text = dt.Rows[0]["cidade"].ToString();
                        comboestado.Text = dt.Rows[0]["estado"].ToString();
                        maskedcel.Text = dt.Rows[0]["celular"].ToString();
                        textemail.Text = dt.Rows[0]["email"].ToString();
                        textobs.Text = dt.Rows[0]["obs"].ToString();

                        if (dt.Rows[0]["documento"].ToString().Length == 11)
                        {
                            radiocpf.Checked = true;
                        }
                        else
                        {
                            radiocnpj.Checked = true;
                        }

                        maskeddoc.Text = dt.Rows[0]["documento"].ToString();

                        if (dt.Rows[0]["gênero"].ToString() == "Masculino")
                        {
                            radiomasc.Checked = true;
                        }
                        else if (dt.Rows[0]["gênero"].ToString() == "Feminino")
                        {
                            radiofem.Checked = true;
                        }
                        else
                        {
                            radiooutros.Checked = true;
                        }

                        if (dt.Rows[0]["situacao"].ToString() == "Ativo")
                        {
                            checkativo.Checked = true;
                        }
                        else
                        {
                            checkativo.Checked = false;
                        }

                        if (File.Exists(pastafotos + txtid.Text + ".png") == true)
                        {
                            ImgCliente.Image = Image.FromFile(pastafotos + txtid.Text + ".png");
                        }
                        else
                        {
                            ImgCliente.Image = Properties.Resources.thedigitalartist_icon_9798055_640__1_;
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(txtname);
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
            if (radiocpf.Checked == true)
            {
                maskeddoc.Mask = "000.000.000-00";
                maskeddoc.Focus();
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (radiocnpj.Checked == true)
            {
                maskeddoc.Mask = "00.000.000/0000-00";
                maskeddoc.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiocnpj.Checked == true)
            {
                maskeddoc.Mask = "00.000.000/0000-00";
                maskeddoc.Focus();
            }
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
            if (txtid.Text == "")
            {
                MessageBox.Show("Não há foto a ser removida.");
                return;
            }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtid.Text + ".png") == false)
            {
                Funcoes.MsgErro("Não foi possível encontrar a foto do cliente para remover.");
                return;
            }

            if (Funcoes.Pergunta("Deseja remover a foto do cliente?") == false)
            {
                return;
            }

            ImgCliente.Image = Properties.Resources.thedigitalartist_icon_9798055_640__1_;

            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtid.Text + ".png");
        }

        private void SalvarClientePostgreSql()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(constring))
            {
                con.Open();

                string query;

                if (txtid.Text == "")
                {
                    query = @"INSERT INTO public.""ClientesInformacoes"" 
                (nome, documento, gênero, estado_civil, data_nascimento, 
                 cep, endereco, numero, bairro, cidade, estado, celular, 
                 email, obs, situacao) 
                VALUES 
                (@nome, @documento, @gênero, @estado_civil, @data_nascimento, 
                 @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, 
                 @email, @obs, @situacao)
                RETURNING id;";
                }
                else
                {
                    query = @"UPDATE public.""ClientesInformacoes"" SET 
                nome = @nome,
                documento = @documento,
                gênero = @gênero,
                estado_civil = @estado_civil,
                data_nascimento = @data_nascimento,
                cep = @cep,
                endereco = @endereco,
                numero = @numero,
                bairro = @bairro,
                cidade = @cidade,
                estado = @estado,
                celular = @celular,
                email = @email,
                obs = @obs,
                situacao = @situacao
                WHERE id = " + txtid.Text;
                }

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", txtname.Text);
                    cmd.Parameters.AddWithValue("@documento", maskeddoc.Text);

                    if (radiomasc.Checked == true)
                        cmd.Parameters.AddWithValue("@gênero", "Masculino");
                    else if (radiofem.Checked == true)
                        cmd.Parameters.AddWithValue("@gênero", "Feminino");
                    else
                        cmd.Parameters.AddWithValue("@gênero", "Outros");

                    cmd.Parameters.AddWithValue("@estado_civil", combocivil.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(maskeddata.Text));
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
                        cmd.Parameters.AddWithValue("@situacao", "Ativo");
                    else
                        cmd.Parameters.AddWithValue("@situacao", "Inativo");

                    if (txtid.Text == "")
                    {
                        int novoId = Convert.ToInt32(cmd.ExecuteScalar());
                        txtid.Text = novoId.ToString();
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                con.Close();
                MessageBox.Show("Cliente salvo com sucesso!");
            }
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

            string docSemMascara = maskeddoc.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            if (docSemMascara == "")
            {
                if (radiocpf.Checked == true)
                {
                    MessageBox.Show("O campo 'CPF' é obrigatório.");
                }
                else
                {
                    MessageBox.Show("O campo 'CNPJ' é obrigatório.");
                }

                maskeddoc.Focus();
                return true;
            }

            if (radiomasc.Checked == false && radiofem.Checked == false && radiooutros.Checked == false)
            {
                MessageBox.Show("Selecione o gênero.");
                return true;
            }

            DateTime dataValida;
            string dataTexto = maskeddata.Text;

            if (!DateTime.TryParseExact(dataTexto, "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture,
                                        System.Globalization.DateTimeStyles.None,
                                        out dataValida))
            {
                MessageBox.Show("Data de nascimento inválida. Use o formato dd/mm/yyyy.",
                               "Erro de validação",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                maskeddata.Focus();
                return true;
            }

            if (dataValida > DateTime.Today)
            {
                MessageBox.Show("A data de nascimento não pode ser futura.",
                               "Erro de validação",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                maskeddata.Focus();
                return true;
            }

            if (dataValida < new DateTime(1904, 1, 1))
            {
                MessageBox.Show("Data de nascimento inválida.");
                maskeddata.Focus();
                return true;
            }

            return false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Funcoes.Pergunta("Deseja limpar os campos?") == false)
            {
                return;
            }

            txtid.Clear();
            txtname.Clear();
            maskeddoc.Clear();
            maskeddata.Clear();
            maskedcep.Clear();
            maskedcel.Clear();
            textendereco.Clear();
            textnum.Clear();
            textbairro.Clear();
            textemail.Clear();
            textobs.Clear();
            radiomasc.Checked = false;
            radiofem.Checked = false;
            radiooutros.Checked = false;
            radiocpf.Checked = false;
            radiocnpj.Checked = false;
            combocivil.SelectedIndex = -1;
            comboestado.SelectedIndex = -1;
            combocidade.SelectedIndex = -1;
            checkativo.Checked = false;
            buttonsalvar.Text = "Salvar";
            ImgCliente.Image = Properties.Resources.thedigitalartist_icon_9798055_640__1_;
        }

        private void radiofem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskeddata_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textendereco_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(textendereco);
        }

        private void textbairro_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(textbairro);
        }

        private void u_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                Funcoes.MsgErro("Salve o cliente antes de adicionar uma foto.");
                return;
            }

            OpenFileDialog caixa = new OpenFileDialog();

            caixa.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp|Todos os Arquivos|*.*";

            if (caixa.ShowDialog() == DialogResult.OK)
            {
                ImgCliente.Image = Image.FromFile(caixa.FileName);

                File.Copy(caixa.FileName, AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtid.Text + ".png", true);
            }
        }

        private void maskeddoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private async void maskedcep_Leave(object sender, EventArgs e)
        {
            string cep = maskedcep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                return;
            }

            try
            {
                using (HttpClient http = new HttpClient())
                {
                    string url = "https://viacep.com.br/ws/" + cep + "/json/";
                    string resposta = await http.GetStringAsync(url);

                    using (JsonDocument doc = JsonDocument.Parse(resposta))
                    {
                        JsonElement root = doc.RootElement;

                        if (root.TryGetProperty("erro", out _))
                        {
                            Funcoes.MsgAlerta("CEP não encontrado.");
                            return;
                        }

                        textendereco.Text = root.GetProperty("logradouro").GetString();
                        textbairro.Text = root.GetProperty("bairro").GetString();

                        string uf = root.GetProperty("uf").GetString() ?? "";
                        string nomeCidade = root.GetProperty("localidade").GetString() ?? "";

                        foreach (var item in comboestado.Items)
                        {
                            if (item.ToString()!.Contains("(" + uf + ")"))
                            {
                                comboestado.SelectedItem = item;
                                break;
                            }
                        }

                        combocidade.Items.Clear();
                        combocidade.Items.Add(nomeCidade);
                        combocidade.SelectedIndex = 0;

                        textnum.Focus();
                    }
                }
            }
            catch
            {
                Funcoes.MsgAlerta("Não foi possível buscar o CEP. Verifique sua conexão.");
            }
        }
    }
}