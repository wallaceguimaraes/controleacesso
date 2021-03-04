namespace ControllAcess.View
{
    partial class ViewPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPessoa));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_escolher = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_nasc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_rg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_obs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_contato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_captura = new System.Windows.Forms.Button();
            this.comboBox_ativo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_gravar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_pessoa = new System.Windows.Forms.DataGridView();
            this.label_tipo_pessoa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_escolher
            // 
            this.button_escolher.Location = new System.Drawing.Point(11, 127);
            this.button_escolher.Name = "button_escolher";
            this.button_escolher.Size = new System.Drawing.Size(104, 29);
            this.button_escolher.TabIndex = 1;
            this.button_escolher.Text = "Escolher arquivo...";
            this.button_escolher.UseVisualStyleBackColor = true;
            this.button_escolher.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 114);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(752, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(71, 16);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(315, 20);
            this.textBox_nome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF:";
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(71, 48);
            this.maskedTextBox_cpf.Mask = "000.000.000-00";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox_cpf.TabIndex = 8;
            // 
            // maskedTextBox_nasc
            // 
            this.maskedTextBox_nasc.Location = new System.Drawing.Point(318, 47);
            this.maskedTextBox_nasc.Mask = "00/00/0000";
            this.maskedTextBox_nasc.Name = "maskedTextBox_nasc";
            this.maskedTextBox_nasc.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBox_nasc.TabIndex = 9;
            this.maskedTextBox_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Nasc:";
            // 
            // textBox_rg
            // 
            this.textBox_rg.Location = new System.Drawing.Point(71, 84);
            this.textBox_rg.Name = "textBox_rg";
            this.textBox_rg.Size = new System.Drawing.Size(90, 20);
            this.textBox_rg.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "RG:";
            // 
            // textBox_obs
            // 
            this.textBox_obs.Location = new System.Drawing.Point(752, 17);
            this.textBox_obs.Multiline = true;
            this.textBox_obs.Name = "textBox_obs";
            this.textBox_obs.Size = new System.Drawing.Size(290, 162);
            this.textBox_obs.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Observação:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(71, 122);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(315, 20);
            this.textBox_email.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-mail:";
            // 
            // textBox_contato
            // 
            this.textBox_contato.Location = new System.Drawing.Point(71, 159);
            this.textBox_contato.Name = "textBox_contato";
            this.textBox_contato.Size = new System.Drawing.Size(165, 20);
            this.textBox_contato.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contato:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.comboBox_ativo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button_pesquisar);
            this.panel1.Controls.Add(this.button_cancelar);
            this.panel1.Controls.Add(this.button_atualizar);
            this.panel1.Controls.Add(this.button_excluir);
            this.panel1.Controls.Add(this.button_gravar);
            this.panel1.Controls.Add(this.textBox_nome);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_contato);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_obs);
            this.panel1.Controls.Add(this.maskedTextBox_cpf);
            this.panel1.Controls.Add(this.textBox_rg);
            this.panel1.Controls.Add(this.maskedTextBox_nasc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 234);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_escolher);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.button_captura);
            this.panel3.Location = new System.Drawing.Point(396, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 162);
            this.panel3.TabIndex = 41;
            // 
            // button_captura
            // 
            this.button_captura.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_captura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_captura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_captura.Image = global::ControllAcess.Properties.Resources.camer1;
            this.button_captura.Location = new System.Drawing.Point(158, 6);
            this.button_captura.Name = "button_captura";
            this.button_captura.Size = new System.Drawing.Size(46, 29);
            this.button_captura.TabIndex = 33;
            this.button_captura.UseVisualStyleBackColor = false;
            // 
            // comboBox_ativo
            // 
            this.comboBox_ativo.AutoCompleteCustomSource.AddRange(new string[] {
            "SIM",
            "NÃO"});
            this.comboBox_ativo.FormattingEnabled = true;
            this.comboBox_ativo.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.comboBox_ativo.Location = new System.Drawing.Point(317, 158);
            this.comboBox_ativo.Name = "comboBox_ativo";
            this.comboBox_ativo.Size = new System.Drawing.Size(69, 21);
            this.comboBox_ativo.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ativo:";
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisar.Location = new System.Drawing.Point(313, 196);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 38;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(236, 196);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 37;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            // 
            // button_atualizar
            // 
            this.button_atualizar.BackColor = System.Drawing.Color.Tomato;
            this.button_atualizar.Enabled = false;
            this.button_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_atualizar.Location = new System.Drawing.Point(161, 196);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 36;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = false;
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.Tomato;
            this.button_excluir.Enabled = false;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_excluir.Location = new System.Drawing.Point(86, 196);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 35;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_gravar.Location = new System.Drawing.Point(14, 196);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 34;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgv_pessoa);
            this.panel2.Controls.Add(this.label_tipo_pessoa);
            this.panel2.Location = new System.Drawing.Point(12, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 252);
            this.panel2.TabIndex = 30;
            // 
            // dgv_pessoa
            // 
            this.dgv_pessoa.AllowUserToAddRows = false;
            this.dgv_pessoa.AllowUserToDeleteRows = false;
            this.dgv_pessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pessoa.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pessoa.Location = new System.Drawing.Point(9, 19);
            this.dgv_pessoa.Name = "dgv_pessoa";
            this.dgv_pessoa.ReadOnly = true;
            this.dgv_pessoa.Size = new System.Drawing.Size(1033, 226);
            this.dgv_pessoa.TabIndex = 19;
            // 
            // label_tipo_pessoa
            // 
            this.label_tipo_pessoa.AutoSize = true;
            this.label_tipo_pessoa.BackColor = System.Drawing.Color.Transparent;
            this.label_tipo_pessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo_pessoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_tipo_pessoa.Location = new System.Drawing.Point(7, 0);
            this.label_tipo_pessoa.Name = "label_tipo_pessoa";
            this.label_tipo_pessoa.Size = new System.Drawing.Size(164, 16);
            this.label_tipo_pessoa.TabIndex = 20;
            this.label_tipo_pessoa.Text = "Pessoas cadastradas:";
            // 
            // ViewPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPessoa";
            this.Text = "Pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_escolher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_nasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_rg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_obs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_contato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_captura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_pessoa;
        private System.Windows.Forms.Label label_tipo_pessoa;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_ativo;
        private System.Windows.Forms.Panel panel3;
    }
}