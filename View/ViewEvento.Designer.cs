namespace ControllAcess.View
{
    partial class ViewEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEvento));
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar_data = new System.Windows.Forms.MonthCalendar();
            this.maskedTextBox_ini = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_fim = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_participantes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_evento = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_local = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_andar = new System.Windows.Forms.ComboBox();
            this.textBox_sala = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_bloco = new System.Windows.Forms.TextBox();
            this.button_pesquisaLocal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "ABERTO",
            "FECHADO"});
            this.comboBox_tipo.Location = new System.Drawing.Point(510, 28);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(110, 28);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(337, 20);
            this.textBox_desc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            this.label3.Click += new System.EventHandler(this.comboBox_data_SelectedIndexChanged);
            // 
            // monthCalendar_data
            // 
            this.monthCalendar_data.BackColor = System.Drawing.Color.Tomato;
            this.monthCalendar_data.ForeColor = System.Drawing.Color.Black;
            this.monthCalendar_data.Location = new System.Drawing.Point(110, 72);
            this.monthCalendar_data.Name = "monthCalendar_data";
            this.monthCalendar_data.ShowToday = false;
            this.monthCalendar_data.ShowTodayCircle = false;
            this.monthCalendar_data.TabIndex = 5;
            this.monthCalendar_data.Visible = false;
            this.monthCalendar_data.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.SelecionarData);
            // 
            // maskedTextBox_ini
            // 
            this.maskedTextBox_ini.Location = new System.Drawing.Point(730, 30);
            this.maskedTextBox_ini.Mask = "00:00  ";
            this.maskedTextBox_ini.Name = "maskedTextBox_ini";
            this.maskedTextBox_ini.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox_ini.TabIndex = 13;
            this.maskedTextBox_ini.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Início:";
            // 
            // maskedTextBox_fim
            // 
            this.maskedTextBox_fim.Location = new System.Drawing.Point(875, 30);
            this.maskedTextBox_fim.Mask = "00:00";
            this.maskedTextBox_fim.Name = "maskedTextBox_fim";
            this.maskedTextBox_fim.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox_fim.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(825, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fim:";
            // 
            // textBox_participantes
            // 
            this.textBox_participantes.Location = new System.Drawing.Point(510, 71);
            this.textBox_participantes.Multiline = true;
            this.textBox_participantes.Name = "textBox_participantes";
            this.textBox_participantes.Size = new System.Drawing.Size(562, 162);
            this.textBox_participantes.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Participantes:";
            // 
            // dgv_evento
            // 
            this.dgv_evento.AllowUserToAddRows = false;
            this.dgv_evento.AllowUserToDeleteRows = false;
            this.dgv_evento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_evento.BackgroundColor = System.Drawing.Color.White;
            this.dgv_evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_evento.Location = new System.Drawing.Point(9, 19);
            this.dgv_evento.Name = "dgv_evento";
            this.dgv_evento.ReadOnly = true;
            this.dgv_evento.Size = new System.Drawing.Size(426, 185);
            this.dgv_evento.TabIndex = 19;
            this.dgv_evento.SelectionChanged += new System.EventHandler(this.SelecionarLinhaEvento);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(6, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Eventos cadastrados:";
            // 
            // dgv_local
            // 
            this.dgv_local.AllowUserToAddRows = false;
            this.dgv_local.AllowUserToDeleteRows = false;
            this.dgv_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_local.BackgroundColor = System.Drawing.Color.White;
            this.dgv_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_local.Location = new System.Drawing.Point(3, 20);
            this.dgv_local.Name = "dgv_local";
            this.dgv_local.Size = new System.Drawing.Size(522, 168);
            this.dgv_local.TabIndex = 21;
            this.dgv_local.SelectionChanged += new System.EventHandler(this.SelecionarLinhaLocal);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox_andar);
            this.panel1.Controls.Add(this.textBox_sala);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_bloco);
            this.panel1.Controls.Add(this.button_pesquisaLocal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgv_local);
            this.panel1.Location = new System.Drawing.Point(510, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 233);
            this.panel1.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(197, 2);
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
            this.comboBox_andar.Location = new System.Drawing.Point(248, 191);
            this.comboBox_andar.Name = "comboBox_andar";
            this.comboBox_andar.Size = new System.Drawing.Size(56, 21);
            this.comboBox_andar.TabIndex = 33;
            // 
            // textBox_sala
            // 
            this.textBox_sala.Location = new System.Drawing.Point(384, 192);
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
            this.label10.Location = new System.Drawing.Point(316, 195);
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
            this.label11.Location = new System.Drawing.Point(201, 195);
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
            this.label9.Location = new System.Drawing.Point(0, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Bloco/Módulo:";
            // 
            // textBox_bloco
            // 
            this.textBox_bloco.Location = new System.Drawing.Point(90, 191);
            this.textBox_bloco.Name = "textBox_bloco";
            this.textBox_bloco.Size = new System.Drawing.Size(100, 20);
            this.textBox_bloco.TabIndex = 29;
            // 
            // button_pesquisaLocal
            // 
            this.button_pesquisaLocal.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisaLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisaLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisaLocal.Location = new System.Drawing.Point(448, 191);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Selecione o local do evento:";
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(165, 205);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 26;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.BackColor = System.Drawing.Color.Tomato;
            this.button_atualizar.Enabled = false;
            this.button_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_atualizar.Location = new System.Drawing.Point(87, 205);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 25;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = false;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.Tomato;
            this.button_excluir.Enabled = false;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_excluir.Location = new System.Drawing.Point(360, 205);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 24;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_gravar.Location = new System.Drawing.Point(9, 205);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 23;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisar.Location = new System.Drawing.Point(997, 28);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 27;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgv_evento);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button_cancelar);
            this.panel2.Controls.Add(this.button_atualizar);
            this.panel2.Controls.Add(this.button_gravar);
            this.panel2.Controls.Add(this.button_excluir);
            this.panel2.Location = new System.Drawing.Point(25, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 233);
            this.panel2.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(95, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(62, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(491, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(715, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(860, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "*";
            // 
            // comboBox_data
            // 
            this.comboBox_data.Enabled = false;
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Items.AddRange(new object[] {
            "ABERTO",
            "FECHADO"});
            this.comboBox_data.Location = new System.Drawing.Point(109, 64);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(229, 21);
            this.comboBox_data.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(917, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 15);
            this.label18.TabIndex = 38;
            this.label18.Text = "hrs";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(775, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 15);
            this.label19.TabIndex = 39;
            this.label19.Text = "hrs";
            // 
            // ViewEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox_data);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_participantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_fim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox_ini);
            this.Controls.Add(this.monthCalendar_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_tipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar_data;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_participantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_evento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_local;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_bloco;
        private System.Windows.Forms.Button button_pesquisaLocal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_andar;
        private System.Windows.Forms.TextBox textBox_sala;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}