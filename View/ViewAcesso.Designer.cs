namespace ControllAcess.View
{
    partial class ViewAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAcesso));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.button_pesquisa = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgv_pessoa = new System.Windows.Forms.DataGridView();
            this.label_tipo_pessoa = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_andar = new System.Windows.Forms.ComboBox();
            this.textBox_sala = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_bloco = new System.Windows.Forms.TextBox();
            this.button_pesquisaLocal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_local = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_acesso = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_cartao = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_pesquisarCartao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_obs = new System.Windows.Forms.TextBox();
            this.button_descarta = new System.Windows.Forms.Button();
            this.pictureBox_x = new System.Windows.Forms.PictureBox();
            this.label_foto = new System.Windows.Forms.Label();
            this.pictureBox_check = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_captura = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pessoa)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(88, 14);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(318, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(88, 42);
            this.maskedTextBox_cpf.Mask = "000.000.000-00";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBox_cpf.TabIndex = 3;
            this.maskedTextBox_cpf.Leave += new System.EventHandler(this.ValidaCPF);
            // 
            // button_pesquisa
            // 
            this.button_pesquisa.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pesquisa.Location = new System.Drawing.Point(194, 40);
            this.button_pesquisa.Name = "button_pesquisa";
            this.button_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisa.TabIndex = 4;
            this.button_pesquisa.Text = "Pesquisar";
            this.button_pesquisa.UseVisualStyleBackColor = false;
            this.button_pesquisa.Click += new System.EventHandler(this.button_pesquisa_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.BackColor = System.Drawing.Color.Tomato;
            this.button_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.button_cadastrar.Location = new System.Drawing.Point(412, 15);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 5;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = false;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dgv_pessoa);
            this.panel2.Controls.Add(this.label_tipo_pessoa);
            this.panel2.Controls.Add(this.button_cancelar);
            this.panel2.Location = new System.Drawing.Point(12, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 195);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(393, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 114);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // dgv_pessoa
            // 
            this.dgv_pessoa.AllowUserToAddRows = false;
            this.dgv_pessoa.AllowUserToDeleteRows = false;
            this.dgv_pessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pessoa.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pessoa.Location = new System.Drawing.Point(9, 18);
            this.dgv_pessoa.Name = "dgv_pessoa";
            this.dgv_pessoa.ReadOnly = true;
            this.dgv_pessoa.Size = new System.Drawing.Size(380, 143);
            this.dgv_pessoa.TabIndex = 19;
            this.dgv_pessoa.SelectionChanged += new System.EventHandler(this.SelecionarLinhaPessoa);
            // 
            // label_tipo_pessoa
            // 
            this.label_tipo_pessoa.AutoSize = true;
            this.label_tipo_pessoa.BackColor = System.Drawing.Color.Transparent;
            this.label_tipo_pessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo_pessoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_tipo_pessoa.Location = new System.Drawing.Point(6, 0);
            this.label_tipo_pessoa.Name = "label_tipo_pessoa";
            this.label_tipo_pessoa.Size = new System.Drawing.Size(147, 15);
            this.label_tipo_pessoa.TabIndex = 20;
            this.label_tipo_pessoa.Text = "Pessoas cadastradas:";
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(8, 167);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 26;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.comboBox_andar);
            this.panel3.Controls.Add(this.textBox_sala);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox_bloco);
            this.panel3.Controls.Add(this.button_pesquisaLocal);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dgv_local);
            this.panel3.Location = new System.Drawing.Point(11, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 174);
            this.panel3.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(145, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "*";
            // 
            // comboBox_andar
            // 
            this.comboBox_andar.AutoCompleteCustomSource.AddRange(new string[] {
            "SIM",
            "NÃO"});
            this.comboBox_andar.FormattingEnabled = true;
            this.comboBox_andar.Items.AddRange(new object[] {
            "0º",
            "1º",
            "2º",
            "3º",
            "4º",
            "5º",
            "6º",
            "7º",
            "8º",
            "9º",
            "10º",
            "11º",
            "12º",
            "13º",
            "14º",
            "15º",
            "16º",
            "17º",
            "18º",
            "19º",
            "20º"});
            this.comboBox_andar.Location = new System.Drawing.Point(260, 142);
            this.comboBox_andar.Name = "comboBox_andar";
            this.comboBox_andar.Size = new System.Drawing.Size(56, 21);
            this.comboBox_andar.TabIndex = 33;
            // 
            // textBox_sala
            // 
            this.textBox_sala.Location = new System.Drawing.Point(388, 142);
            this.textBox_sala.Name = "textBox_sala";
            this.textBox_sala.Size = new System.Drawing.Size(56, 20);
            this.textBox_sala.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(322, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sala/Apt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(212, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Andar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(5, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Bloco/Módulo:";
            // 
            // textBox_bloco
            // 
            this.textBox_bloco.Location = new System.Drawing.Point(105, 142);
            this.textBox_bloco.Name = "textBox_bloco";
            this.textBox_bloco.Size = new System.Drawing.Size(100, 20);
            this.textBox_bloco.TabIndex = 29;
            // 
            // button_pesquisaLocal
            // 
            this.button_pesquisaLocal.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisaLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisaLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisaLocal.Location = new System.Drawing.Point(450, 141);
            this.button_pesquisaLocal.Name = "button_pesquisaLocal";
            this.button_pesquisaLocal.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisaLocal.TabIndex = 28;
            this.button_pesquisaLocal.Text = "Pesquisar";
            this.button_pesquisaLocal.UseVisualStyleBackColor = false;
            this.button_pesquisaLocal.Click += new System.EventHandler(this.button_pesquisarLocal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Selecione o local:";
            // 
            // dgv_local
            // 
            this.dgv_local.AllowUserToAddRows = false;
            this.dgv_local.AllowUserToDeleteRows = false;
            this.dgv_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_local.BackgroundColor = System.Drawing.Color.White;
            this.dgv_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_local.Location = new System.Drawing.Point(8, 36);
            this.dgv_local.Name = "dgv_local";
            this.dgv_local.Size = new System.Drawing.Size(510, 100);
            this.dgv_local.TabIndex = 21;
            this.dgv_local.SelectionChanged += new System.EventHandler(this.SelecionarLinhaLocal);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tomato;
            this.panel4.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgv_acesso);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(567, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 192);
            this.panel4.TabIndex = 30;
            // 
            // dgv_acesso
            // 
            this.dgv_acesso.AllowUserToAddRows = false;
            this.dgv_acesso.AllowUserToDeleteRows = false;
            this.dgv_acesso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_acesso.BackgroundColor = System.Drawing.Color.White;
            this.dgv_acesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_acesso.Location = new System.Drawing.Point(9, 32);
            this.dgv_acesso.Name = "dgv_acesso";
            this.dgv_acesso.ReadOnly = true;
            this.dgv_acesso.Size = new System.Drawing.Size(480, 153);
            this.dgv_acesso.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Acessos do dia:";
            // 
            // dgv_cartao
            // 
            this.dgv_cartao.AllowUserToAddRows = false;
            this.dgv_cartao.AllowUserToDeleteRows = false;
            this.dgv_cartao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cartao.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_cartao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cartao.Location = new System.Drawing.Point(3, 30);
            this.dgv_cartao.Name = "dgv_cartao";
            this.dgv_cartao.ReadOnly = true;
            this.dgv_cartao.Size = new System.Drawing.Size(479, 169);
            this.dgv_cartao.TabIndex = 21;
            this.dgv_cartao.SelectionChanged += new System.EventHandler(this.SelecionarLinhaCartao);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(198, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 52);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button_pesquisarCartao);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboBox_tipo);
            this.panel5.Controls.Add(this.textBox_numero);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.dgv_cartao);
            this.panel5.Location = new System.Drawing.Point(553, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 206);
            this.panel5.TabIndex = 31;
            // 
            // button_pesquisarCartao
            // 
            this.button_pesquisarCartao.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisarCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisarCartao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisarCartao.Location = new System.Drawing.Point(407, 3);
            this.button_pesquisarCartao.Name = "button_pesquisarCartao";
            this.button_pesquisarCartao.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisarCartao.TabIndex = 27;
            this.button_pesquisarCartao.Text = "Pesquisar";
            this.button_pesquisarCartao.UseVisualStyleBackColor = false;
            this.button_pesquisarCartao.Click += new System.EventHandler(this.button_pesquisarCartao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo:";
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.AutoCompleteCustomSource.AddRange(new string[] {
            "FUNCIONÁRIO",
            "VISITANTE"});
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "CONDÔMINO",
            "FUNCIONÁRIO",
            "VISITANTE"});
            this.comboBox_tipo.Location = new System.Drawing.Point(258, 5);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(135, 21);
            this.comboBox_tipo.TabIndex = 25;
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(70, 5);
            this.textBox_numero.MaxLength = 10;
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(145, 20);
            this.textBox_numero.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "N° Cartão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(550, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selecione o cartão:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.textBox_obs);
            this.panel7.Controls.Add(this.button_descarta);
            this.panel7.Controls.Add(this.pictureBox_x);
            this.panel7.Controls.Add(this.label_foto);
            this.panel7.Controls.Add(this.pictureBox_check);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.button_cadastrar);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.button_captura);
            this.panel7.Controls.Add(this.button_pesquisa);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.maskedTextBox_cpf);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBox_nome);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(13, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1060, 305);
            this.panel7.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(69, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 15);
            this.label16.TabIndex = 42;
            this.label16.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(58, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 41;
            this.label14.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Observação:";
            // 
            // textBox_obs
            // 
            this.textBox_obs.Location = new System.Drawing.Point(553, 249);
            this.textBox_obs.Multiline = true;
            this.textBox_obs.Name = "textBox_obs";
            this.textBox_obs.Size = new System.Drawing.Size(490, 49);
            this.textBox_obs.TabIndex = 39;
            // 
            // button_descarta
            // 
            this.button_descarta.BackColor = System.Drawing.Color.Red;
            this.button_descarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_descarta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_descarta.Location = new System.Drawing.Point(273, 247);
            this.button_descarta.Name = "button_descarta";
            this.button_descarta.Size = new System.Drawing.Size(97, 29);
            this.button_descarta.TabIndex = 38;
            this.button_descarta.Text = "Descartar";
            this.button_descarta.UseVisualStyleBackColor = false;
            this.button_descarta.Visible = false;
            this.button_descarta.Click += new System.EventHandler(this.DescartarFoto_Click);
            // 
            // pictureBox_x
            // 
            this.pictureBox_x.BackgroundImage = global::ControllAcess.Properties.Resources.imgx2;
            this.pictureBox_x.Location = new System.Drawing.Point(168, 250);
            this.pictureBox_x.Name = "pictureBox_x";
            this.pictureBox_x.Size = new System.Drawing.Size(15, 15);
            this.pictureBox_x.TabIndex = 37;
            this.pictureBox_x.TabStop = false;
            // 
            // label_foto
            // 
            this.label_foto.AutoSize = true;
            this.label_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_foto.Location = new System.Drawing.Point(128, 250);
            this.label_foto.Name = "label_foto";
            this.label_foto.Size = new System.Drawing.Size(36, 13);
            this.label_foto.TabIndex = 36;
            this.label_foto.Text = "Foto:";
            // 
            // pictureBox_check
            // 
            this.pictureBox_check.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_check.BackgroundImage = global::ControllAcess.Properties.Resources.checado;
            this.pictureBox_check.Location = new System.Drawing.Point(168, 250);
            this.pictureBox_check.Name = "pictureBox_check";
            this.pictureBox_check.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_check.TabIndex = 35;
            this.pictureBox_check.TabStop = false;
            this.pictureBox_check.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(696, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(49, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "*";
            // 
            // button_captura
            // 
            this.button_captura.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_captura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_captura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_captura.Image = global::ControllAcess.Properties.Resources.camer1;
            this.button_captura.Location = new System.Drawing.Point(11, 252);
            this.button_captura.Name = "button_captura";
            this.button_captura.Size = new System.Drawing.Size(34, 29);
            this.button_captura.TabIndex = 32;
            this.button_captura.UseVisualStyleBackColor = false;
            this.button_captura.Click += new System.EventHandler(this.AbrirCam_Click);
            // 
            // ViewAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de acesso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pessoa)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button_pesquisa;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_pessoa;
        private System.Windows.Forms.Label label_tipo_pessoa;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_andar;
        private System.Windows.Forms.TextBox textBox_sala;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_bloco;
        private System.Windows.Forms.Button button_pesquisaLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_local;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_acesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_cartao;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_pesquisarCartao;
        private System.Windows.Forms.Button button_captura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox_check;
        private System.Windows.Forms.PictureBox pictureBox_x;
        private System.Windows.Forms.Label label_foto;
        private System.Windows.Forms.Button button_descarta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_obs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
    }
}