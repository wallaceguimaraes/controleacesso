namespace ControllAcess.View
{
    partial class ViewCartao
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
                //Index index = new Index();
                //index.Show();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCartao));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.dgv_cartao = new System.Windows.Forms.DataGridView();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_ini = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_fim = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ativo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Cartão:";
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(143, 50);
            this.textBox_numero.MaxLength = 10;
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(166, 20);
            this.textBox_numero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cartões cadastrados";
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_gravar.Location = new System.Drawing.Point(50, 191);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 6;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisar.Location = new System.Drawing.Point(329, 84);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 7;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.Tomato;
            this.button_excluir.Enabled = false;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_excluir.Location = new System.Drawing.Point(143, 191);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 8;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // dgv_cartao
            // 
            this.dgv_cartao.AllowUserToAddRows = false;
            this.dgv_cartao.AllowUserToDeleteRows = false;
            this.dgv_cartao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cartao.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_cartao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cartao.Location = new System.Drawing.Point(50, 253);
            this.dgv_cartao.Name = "dgv_cartao";
            this.dgv_cartao.ReadOnly = true;
            this.dgv_cartao.Size = new System.Drawing.Size(954, 187);
            this.dgv_cartao.TabIndex = 9;
            this.dgv_cartao.SelectionChanged += new System.EventHandler(this.SelecionarLinha);
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
            this.comboBox_tipo.Location = new System.Drawing.Point(143, 86);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(166, 21);
            this.comboBox_tipo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo:";
            // 
            // maskedTextBox_ini
            // 
            this.maskedTextBox_ini.Location = new System.Drawing.Point(143, 129);
            this.maskedTextBox_ini.Mask = "00:00";
            this.maskedTextBox_ini.Name = "maskedTextBox_ini";
            this.maskedTextBox_ini.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox_ini.TabIndex = 12;
            this.maskedTextBox_ini.Text = "0000";
            this.maskedTextBox_ini.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Período:";
            // 
            // maskedTextBox_fim
            // 
            this.maskedTextBox_fim.Location = new System.Drawing.Point(210, 129);
            this.maskedTextBox_fim.Mask = "00:00";
            this.maskedTextBox_fim.Name = "maskedTextBox_fim";
            this.maskedTextBox_fim.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox_fim.TabIndex = 14;
            this.maskedTextBox_fim.Text = "0000";
            this.maskedTextBox_fim.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "às";
            // 
            // button_atualizar
            // 
            this.button_atualizar.BackColor = System.Drawing.Color.Tomato;
            this.button_atualizar.Enabled = false;
            this.button_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_atualizar.Location = new System.Drawing.Point(234, 191);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 16;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = false;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(327, 191);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 17;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ativo:";
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
            this.comboBox_ativo.Location = new System.Drawing.Point(143, 157);
            this.comboBox_ativo.Name = "comboBox_ativo";
            this.comboBox_ativo.Size = new System.Drawing.Size(99, 21);
            this.comboBox_ativo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(117, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(117, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(327, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(117, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "*";
            // 
            // ViewCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox_fim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_ini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.dgv_cartao);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ativo);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewCartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.DataGridView dgv_cartao;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ativo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}