namespace Cadastro_de_clientes_visual_studio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtid = new TextBox();
            label2 = new Label();
            txtname = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox7 = new TextBox();
            textendereco = new TextBox();
            textnum = new TextBox();
            label16 = new Label();
            textbairro = new TextBox();
            textemail = new TextBox();
            textobs = new TextBox();
            radiocpf = new RadioButton();
            radiocnpj = new RadioButton();
            radiomasc = new RadioButton();
            radiofem = new RadioButton();
            radiooutros = new RadioButton();
            groupBox1 = new GroupBox();
            checkativo = new CheckBox();
            maskeddoc = new MaskedTextBox();
            maskeddata = new MaskedTextBox();
            maskedcel = new MaskedTextBox();
            maskedcep = new MaskedTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboestado = new ComboBox();
            label3 = new Label();
            combocivil = new ComboBox();
            combocidade = new ComboBox();
            pictureBox1 = new PictureBox();
            u = new Button();
            button1 = new Button();
            buttonsalvar = new Button();
            maskedrg = new MaskedTextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(165, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(165, 53);
            txtid.Name = "txtid";
            txtid.Size = new Size(117, 25);
            txtid.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(288, 31);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome do Cliente";
            label2.Click += label2_Click;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(288, 53);
            txtname.Name = "txtname";
            txtname.Size = new Size(386, 25);
            txtname.TabIndex = 1;
            txtname.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(165, 162);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 0;
            label5.Text = "RG";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(321, 162);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 0;
            label6.Text = "Estado Civil";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(512, 162);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 0;
            label7.Text = "Data de Nascimento";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(48, 228);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 0;
            label8.Text = "CEP";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(154, 228);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 0;
            label9.Text = "Endereço";
            label9.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(566, 228);
            label10.Name = "label10";
            label10.Size = new Size(26, 20);
            label10.TabIndex = 0;
            label10.Text = "№";
            label10.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(48, 417);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 0;
            label11.Text = "Observações";
            label11.Click += label1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(337, 293);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 0;
            label12.Text = "Cidade";
            label12.Click += label1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(300, 353);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 0;
            label13.Text = "Celular";
            label13.Click += label1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.Location = new Point(410, 353);
            label14.Name = "label14";
            label14.Size = new Size(52, 20);
            label14.TabIndex = 0;
            label14.Text = "E-mail";
            label14.Click += label1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F);
            label15.Location = new Point(48, 572);
            label15.Name = "label15";
            label15.Size = new Size(132, 20);
            label15.TabIndex = 0;
            label15.Text = "Situação Cadastral";
            label15.Click += label1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(512, 185);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(162, 23);
            textBox7.TabIndex = 1;
            // 
            // textendereco
            // 
            textendereco.Font = new Font("Microsoft Sans Serif", 9.75F);
            textendereco.Location = new Point(154, 251);
            textendereco.Name = "textendereco";
            textendereco.Size = new Size(406, 22);
            textendereco.TabIndex = 7;
            // 
            // textnum
            // 
            textnum.Font = new Font("Microsoft Sans Serif", 9.75F);
            textnum.Location = new Point(566, 251);
            textnum.Name = "textnum";
            textnum.Size = new Size(108, 22);
            textnum.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F);
            label16.Location = new Point(48, 293);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 0;
            label16.Text = "Bairro";
            label16.Click += label1_Click;
            // 
            // textbairro
            // 
            textbairro.Font = new Font("Microsoft Sans Serif", 9.75F);
            textbairro.Location = new Point(48, 316);
            textbairro.Name = "textbairro";
            textbairro.Size = new Size(283, 22);
            textbairro.TabIndex = 9;
            // 
            // textemail
            // 
            textemail.Font = new Font("Microsoft Sans Serif", 9.75F);
            textemail.Location = new Point(410, 376);
            textemail.Name = "textemail";
            textemail.Size = new Size(264, 22);
            textemail.TabIndex = 13;
            // 
            // textobs
            // 
            textobs.Font = new Font("Microsoft Sans Serif", 9.75F);
            textobs.Location = new Point(48, 440);
            textobs.Multiline = true;
            textobs.Name = "textobs";
            textobs.Size = new Size(626, 89);
            textobs.TabIndex = 14;
            // 
            // radiocpf
            // 
            radiocpf.AutoSize = true;
            radiocpf.Location = new Point(8, 3);
            radiocpf.Name = "radiocpf";
            radiocpf.Size = new Size(46, 19);
            radiocpf.TabIndex = 0;
            radiocpf.TabStop = true;
            radiocpf.Text = "CPF";
            radiocpf.UseVisualStyleBackColor = true;
            radiocpf.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radiocnpj
            // 
            radiocnpj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radiocnpj.Location = new Point(60, 3);
            radiocnpj.Margin = new Padding(3, 3, 17, 10);
            radiocnpj.Name = "radiocnpj";
            radiocnpj.Size = new Size(52, 19);
            radiocnpj.TabIndex = 3;
            radiocnpj.TabStop = true;
            radiocnpj.Text = "CNPJ";
            radiocnpj.TextAlign = ContentAlignment.MiddleRight;
            radiocnpj.UseVisualStyleBackColor = true;
            radiocnpj.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radiomasc
            // 
            radiomasc.AutoSize = true;
            radiomasc.Location = new Point(14, 25);
            radiomasc.Name = "radiomasc";
            radiomasc.Size = new Size(94, 24);
            radiomasc.TabIndex = 0;
            radiomasc.TabStop = true;
            radiomasc.Text = "Masculino";
            radiomasc.UseVisualStyleBackColor = true;
            radiomasc.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radiofem
            // 
            radiofem.AutoSize = true;
            radiofem.Location = new Point(140, 25);
            radiofem.Name = "radiofem";
            radiofem.Size = new Size(88, 24);
            radiofem.TabIndex = 4;
            radiofem.TabStop = true;
            radiofem.Text = "Feminino";
            radiofem.UseVisualStyleBackColor = true;
            // 
            // radiooutros
            // 
            radiooutros.AutoSize = true;
            radiooutros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiooutros.Location = new Point(251, 25);
            radiooutros.Name = "radiooutros";
            radiooutros.Size = new Size(71, 24);
            radiooutros.TabIndex = 4;
            radiooutros.TabStop = true;
            radiooutros.Text = "Outros";
            radiooutros.UseVisualStyleBackColor = true;
            radiooutros.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radiomasc);
            groupBox1.Controls.Add(radiooutros);
            groupBox1.Controls.Add(radiofem);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(323, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 55);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = " Gênero ";
            // 
            // checkativo
            // 
            checkativo.AutoSize = true;
            checkativo.Checked = true;
            checkativo.CheckState = CheckState.Checked;
            checkativo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkativo.Location = new Point(186, 572);
            checkativo.Name = "checkativo";
            checkativo.Size = new Size(63, 24);
            checkativo.TabIndex = 6;
            checkativo.Text = "Ativo";
            checkativo.UseVisualStyleBackColor = true;
            // 
            // maskeddoc
            // 
            maskeddoc.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskeddoc.Location = new Point(165, 121);
            maskeddoc.Mask = "000,000,000-00";
            maskeddoc.Name = "maskeddoc";
            maskeddoc.Size = new Size(139, 23);
            maskeddoc.TabIndex = 2;
            // 
            // maskeddata
            // 
            maskeddata.Font = new Font("Microsoft Sans Serif", 9.75F);
            maskeddata.Location = new Point(512, 185);
            maskeddata.Mask = "00/00/0000";
            maskeddata.Name = "maskeddata";
            maskeddata.Size = new Size(162, 22);
            maskeddata.TabIndex = 5;
            // 
            // maskedcel
            // 
            maskedcel.Font = new Font("Microsoft Sans Serif", 9.75F);
            maskedcel.Location = new Point(300, 374);
            maskedcel.Mask = "(00) 00000-0000";
            maskedcel.Name = "maskedcel";
            maskedcel.Size = new Size(103, 22);
            maskedcel.TabIndex = 12;
            maskedcel.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // maskedcep
            // 
            maskedcep.Font = new Font("Microsoft Sans Serif", 9.75F);
            maskedcep.Location = new Point(48, 251);
            maskedcep.Mask = "00000-000";
            maskedcep.Name = "maskedcep";
            maskedcep.Size = new Size(100, 22);
            maskedcep.TabIndex = 6;
            maskedcep.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(radiocnpj);
            flowLayoutPanel1.Controls.Add(radiocpf);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(165, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(129, 25);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.WrapContents = false;
            // 
            // comboestado
            // 
            comboestado.DropDownHeight = 200;
            comboestado.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboestado.FormattingEnabled = true;
            comboestado.IntegralHeight = false;
            comboestado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            comboestado.Location = new Point(48, 376);
            comboestado.Name = "comboestado";
            comboestado.Size = new Size(246, 24);
            comboestado.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(48, 353);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "Estado";
            label3.Click += label1_Click;
            // 
            // combocivil
            // 
            combocivil.Font = new Font("Microsoft Sans Serif", 9.75F);
            combocivil.FormattingEnabled = true;
            combocivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Divorciado", "Viúvo", "" });
            combocivil.Location = new Point(321, 185);
            combocivil.Name = "combocivil";
            combocivil.Size = new Size(185, 24);
            combocivil.TabIndex = 4;
            // 
            // combocidade
            // 
            combocidade.Font = new Font("Microsoft Sans Serif", 9.75F);
            combocidade.FormattingEnabled = true;
            combocidade.Location = new Point(337, 316);
            combocidade.Name = "combocidade";
            combocidade.Size = new Size(337, 24);
            combocidade.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // u
            // 
            u.BackColor = Color.LimeGreen;
            u.FlatAppearance.BorderSize = 0;
            u.FlatStyle = FlatStyle.Flat;
            u.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            u.ForeColor = SystemColors.ControlText;
            u.Image = (Image)resources.GetObject("u.Image");
            u.ImageAlign = ContentAlignment.MiddleLeft;
            u.Location = new Point(23, 188);
            u.Name = "u";
            u.RightToLeft = RightToLeft.No;
            u.Size = new Size(71, 23);
            u.TabIndex = 12;
            u.Text = "Upload";
            u.TextAlign = ContentAlignment.MiddleRight;
            u.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(99, 188);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(35, 23);
            button1.TabIndex = 12;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonsalvar
            // 
            buttonsalvar.BackColor = Color.Gainsboro;
            buttonsalvar.FlatAppearance.BorderSize = 0;
            buttonsalvar.FlatStyle = FlatStyle.Flat;
            buttonsalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsalvar.ForeColor = SystemColors.ControlText;
            buttonsalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonsalvar.Location = new Point(606, 607);
            buttonsalvar.Name = "buttonsalvar";
            buttonsalvar.RightToLeft = RightToLeft.No;
            buttonsalvar.Size = new Size(68, 29);
            buttonsalvar.TabIndex = 12;
            buttonsalvar.Text = "Salvar";
            buttonsalvar.UseVisualStyleBackColor = false;
            buttonsalvar.Click += button3_Click;
            // 
            // maskedrg
            // 
            maskedrg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedrg.Location = new Point(165, 184);
            maskedrg.Mask = "0,000,000";
            maskedrg.Name = "maskedrg";
            maskedrg.Size = new Size(150, 25);
            maskedrg.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(356, 607);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "postgresql";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 537);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(127, 59);
            dataGridView1.TabIndex = 17;
            // 
            // button7
            // 
            button7.Location = new Point(256, 607);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 18;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 255, 254);
            BackgroundImage = Properties.Resources.Captura_de_tela_2026_02_16_162357;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 661);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(maskedrg);
            Controls.Add(button1);
            Controls.Add(buttonsalvar);
            Controls.Add(u);
            Controls.Add(pictureBox1);
            Controls.Add(combocidade);
            Controls.Add(combocivil);
            Controls.Add(comboestado);
            Controls.Add(maskedcep);
            Controls.Add(maskedcel);
            Controls.Add(maskeddata);
            Controls.Add(maskeddoc);
            Controls.Add(checkativo);
            Controls.Add(groupBox1);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textobs);
            Controls.Add(textemail);
            Controls.Add(textbairro);
            Controls.Add(textendereco);
            Controls.Add(textnum);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label3);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid;
        private Label label2;
        private TextBox txtname;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox7;
        private TextBox textendereco;
        private TextBox textnum;
        private Label label16;
        private TextBox textbairro;
        private TextBox textemail;
        private TextBox textobs;
        private RadioButton radiocpf;
        private RadioButton radiomasc;
        private RadioButton radiofem;
        private RadioButton radiooutros;
        private GroupBox groupBox1;
        private CheckBox checkativo;
        private MaskedTextBox maskeddoc;
        private MaskedTextBox maskeddata;
        private MaskedTextBox maskedcel;
        private MaskedTextBox maskedcep;
        private FlowLayoutPanel flowLayoutPanel1;
        public RadioButton radiocnpj;
        private ComboBox comboestado;
        private Label label3;
        private ComboBox combocivil;
        private ComboBox combocidade;
        private PictureBox pictureBox1;
        private Button u;
        private Button button1;
        private Button buttonsalvar;
        private MaskedTextBox maskedrg;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button7;
    }
}
