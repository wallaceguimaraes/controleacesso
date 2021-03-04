namespace ControllAcess.View
{
    partial class ViewEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_razao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cnpj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ativo = new System.Windows.Forms.ComboBox();
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
            this.dgv_local = new System.Windows.Forms.DataGridView();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_gravar = new System.Windows.Forms.Button();
            this.dgv_empresa = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBox_data = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa:";
            // 
            // textBox_empresa
            // 
            this.textBox_empresa.Location = new System.Drawing.Point(123, 8);
            this.textBox_empresa.Name = "textBox_empresa";
            this.textBox_empresa.Size = new System.Drawing.Size(362, 20);
            this.textBox_empresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razão social:";
            // 
            // textBox_razao
            // 
            this.textBox_razao.Location = new System.Drawing.Point(123, 52);
            this.textBox_razao.Name = "textBox_razao";
            this.textBox_razao.Size = new System.Drawing.Size(362, 20);
            this.textBox_razao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ:";
            // 
            // textBox_cnpj
            // 
            this.textBox_cnpj.Location = new System.Drawing.Point(123, 108);
            this.textBox_cnpj.Name = "textBox_cnpj";
            this.textBox_cnpj.Size = new System.Drawing.Size(362, 20);
            this.textBox_cnpj.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ativo:";
            // 
            // comboBox_ativo
            // 
            this.comboBox_ativo.AutoCompleteCustomSource.AddRange(new string[] {
            "SIM",
            "NÃO"});
            this.comboBox_ativo.FormattingEnabled = true;
            this.comboBox_ativo.Items.AddRange(new object[] {
            "SIM",
            "NÂO"});
            this.comboBox_ativo.Location = new System.Drawing.Point(428, 157);
            this.comboBox_ativo.Name = "comboBox_ativo";
            this.comboBox_ativo.Size = new System.Drawing.Size(56, 21);
            this.comboBox_ativo.TabIndex = 27;
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
            this.panel1.Location = new System.Drawing.Point(536, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 223);
            this.panel1.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(212, 2);
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
            this.button_pesquisaLocal.Location = new System.Drawing.Point(450, 191);
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
            this.label8.Size = new System.Drawing.Size(207, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Onde a empresa está alocada?";
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
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(317, 191);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 32;
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
            this.button_atualizar.Location = new System.Drawing.Point(245, 191);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 31;
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
            this.button_excluir.Location = new System.Drawing.Point(173, 191);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 30;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_gravar.Location = new System.Drawing.Point(101, 191);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 29;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // dgv_empresa
            // 
            this.dgv_empresa.AllowUserToAddRows = false;
            this.dgv_empresa.AllowUserToDeleteRows = false;
            this.dgv_empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_empresa.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresa.Location = new System.Drawing.Point(37, 263);
            this.dgv_empresa.Name = "dgv_empresa";
            this.dgv_empresa.ReadOnly = true;
            this.dgv_empresa.Size = new System.Drawing.Size(1035, 215);
            this.dgv_empresa.TabIndex = 33;
            this.dgv_empresa.SelectionChanged += new System.EventHandler(this.SelecionarLinhaEmpresa);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Empresas cadastradas";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.maskedTextBox_data);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button_pesquisar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_cnpj);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_empresa);
            this.panel2.Controls.Add(this.button_cancelar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_atualizar);
            this.panel2.Controls.Add(this.textBox_razao);
            this.panel2.Controls.Add(this.button_excluir);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_gravar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox_ativo);
            this.panel2.Location = new System.Drawing.Point(37, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 224);
            this.panel2.TabIndex = 35;
            // 
            // maskedTextBox_data
            // 
            this.maskedTextBox_data.Location = new System.Drawing.Point(123, 153);
            this.maskedTextBox_data.Mask = "00/00/0000";
            this.maskedTextBox_data.Name = "maskedTextBox_data";
            this.maskedTextBox_data.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_data.TabIndex = 38;
            this.maskedTextBox_data.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(104, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Data locação:";
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisar.Location = new System.Drawing.Point(408, 191);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 35;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(62, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(84, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "*";
            // 
            // ViewEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_empresa);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_razao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_ativo;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.DataGridView dgv_empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}