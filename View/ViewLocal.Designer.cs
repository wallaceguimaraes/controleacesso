namespace ControllAcess.View
{
    partial class ViewLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLocal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_bloco = new System.Windows.Forms.TextBox();
            this.textBox_sala = new System.Windows.Forms.TextBox();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.dgv_local = new System.Windows.Forms.DataGridView();
            this.comboBox_ativo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_andar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bloco/Módulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Andar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sala/Apt:";
            // 
            // textBox_bloco
            // 
            this.textBox_bloco.Location = new System.Drawing.Point(149, 78);
            this.textBox_bloco.Name = "textBox_bloco";
            this.textBox_bloco.Size = new System.Drawing.Size(164, 20);
            this.textBox_bloco.TabIndex = 3;
            // 
            // textBox_sala
            // 
            this.textBox_sala.Location = new System.Drawing.Point(567, 78);
            this.textBox_sala.Name = "textBox_sala";
            this.textBox_sala.Size = new System.Drawing.Size(56, 20);
            this.textBox_sala.TabIndex = 5;
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_gravar.Location = new System.Drawing.Point(148, 119);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 7;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(365, 119);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 20;
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
            this.button_atualizar.Location = new System.Drawing.Point(292, 119);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 19;
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
            this.button_excluir.Location = new System.Drawing.Point(220, 119);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 18;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisar.Location = new System.Drawing.Point(838, 77);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 21;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // dgv_local
            // 
            this.dgv_local.AllowUserToAddRows = false;
            this.dgv_local.AllowUserToDeleteRows = false;
            this.dgv_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_local.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_local.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_local.Location = new System.Drawing.Point(51, 184);
            this.dgv_local.Name = "dgv_local";
            this.dgv_local.ReadOnly = true;
            this.dgv_local.Size = new System.Drawing.Size(862, 263);
            this.dgv_local.TabIndex = 22;
            this.dgv_local.SelectionChanged += new System.EventHandler(this.SelecionarLinha);
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
            this.comboBox_ativo.Location = new System.Drawing.Point(689, 78);
            this.comboBox_ativo.Name = "comboBox_ativo";
            this.comboBox_ativo.Size = new System.Drawing.Size(79, 21);
            this.comboBox_ativo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ativo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Locais cadastrados";
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
            this.comboBox_andar.Location = new System.Drawing.Point(405, 77);
            this.comboBox_andar.Name = "comboBox_andar";
            this.comboBox_andar.Size = new System.Drawing.Size(56, 21);
            this.comboBox_andar.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(542, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(379, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(772, 165);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 16);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "+ Adicionar contato";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ViewLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_andar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_ativo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_local);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.textBox_sala);
            this.Controls.Add(this.textBox_bloco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_local)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_bloco;
        private System.Windows.Forms.TextBox textBox_sala;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.DataGridView dgv_local;
        private System.Windows.Forms.ComboBox comboBox_ativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_andar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}