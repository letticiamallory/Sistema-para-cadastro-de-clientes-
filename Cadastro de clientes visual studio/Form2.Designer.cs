namespace Cadastro_de_clientes_visual_studio
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            buttonform = new Button();
            buttonpdf = new Button();
            buttonedit = new Button();
            buttonadd = new Button();
            dgvClientes = new DataGridView();
            txtbusca = new TextBox();
            btnBuscar = new Button();
            lblBusca = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonform);
            groupBox1.Controls.Add(buttonpdf);
            groupBox1.Controls.Add(buttonedit);
            groupBox1.Controls.Add(buttonadd);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Ações ";
            // 
            // buttonform
            // 
            buttonform.BackColor = Color.Transparent;
            buttonform.BackgroundImage = (Image)resources.GetObject("buttonform.BackgroundImage");
            buttonform.Cursor = Cursors.Hand;
            buttonform.Enabled = false;
            buttonform.FlatAppearance.BorderSize = 0;
            buttonform.FlatStyle = FlatStyle.Flat;
            buttonform.Location = new Point(188, 24);
            buttonform.Name = "buttonform";
            buttonform.Size = new Size(51, 50);
            buttonform.TabIndex = 1;
            buttonform.UseVisualStyleBackColor = false;
            buttonform.Click += button1_Click;
            // 
            // buttonpdf
            // 
            buttonpdf.BackColor = Color.Transparent;
            buttonpdf.BackgroundImage = (Image)resources.GetObject("buttonpdf.BackgroundImage");
            buttonpdf.Cursor = Cursors.Hand;
            buttonpdf.FlatAppearance.BorderSize = 0;
            buttonpdf.FlatStyle = FlatStyle.Flat;
            buttonpdf.Location = new Point(131, 24);
            buttonpdf.Name = "buttonpdf";
            buttonpdf.Size = new Size(51, 50);
            buttonpdf.TabIndex = 1;
            buttonpdf.UseVisualStyleBackColor = false;
            buttonpdf.Click += button1_Click;
            // 
            // buttonedit
            // 
            buttonedit.BackColor = Color.Transparent;
            buttonedit.BackgroundImage = (Image)resources.GetObject("buttonedit.BackgroundImage");
            buttonedit.Cursor = Cursors.Hand;
            buttonedit.Enabled = false;
            buttonedit.FlatAppearance.BorderSize = 0;
            buttonedit.FlatStyle = FlatStyle.Flat;
            buttonedit.Location = new Point(74, 25);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(48, 48);
            buttonedit.TabIndex = 1;
            buttonedit.UseVisualStyleBackColor = false;
            buttonedit.Click += button1_Click;
            // 
            // buttonadd
            // 
            buttonadd.BackColor = Color.Transparent;
            buttonadd.BackgroundImage = (Image)resources.GetObject("buttonadd.BackgroundImage");
            buttonadd.Cursor = Cursors.Hand;
            buttonadd.FlatAppearance.BorderSize = 0;
            buttonadd.FlatStyle = FlatStyle.Flat;
            buttonadd.Location = new Point(17, 25);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(48, 48);
            buttonadd.TabIndex = 1;
            buttonadd.UseVisualStyleBackColor = false;
            buttonadd.Click += button1_Click;
            // 
            // lblBusca
            // 
            lblBusca.AutoSize = true;
            lblBusca.BackColor = Color.Transparent;
            lblBusca.Font = new Font("Segoe UI", 10F);
            lblBusca.Location = new Point(280, 35);
            lblBusca.Name = "lblBusca";
            lblBusca.Text = "Buscar:";
            // 
            // txtbusca
            // 
            txtbusca.Font = new Font("Segoe UI", 10F);
            txtbusca.Location = new Point(338, 32);
            txtbusca.Name = "txtbusca";
            txtbusca.Size = new Size(350, 25);
            txtbusca.TabIndex = 2;
            txtbusca.KeyDown += txtbusca_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(698, 31);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 27);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.Location = new Point(12, 110);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(1240, 555);
            dgvClientes.TabIndex = 4;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1080_1080__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscar);
            Controls.Add(txtbusca);
            Controls.Add(lblBusca);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de cadastro";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonadd;
        private Button buttonform;
        private Button buttonpdf;
        private Button buttonedit;
        private DataGridView dgvClientes;
        private TextBox txtbusca;
        private Button btnBuscar;
        private Label lblBusca;
    }
}