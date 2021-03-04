namespace ControllAcess.View
{
    partial class ViewContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContato));
            this.button_gravar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_sala = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_andar = new System.Windows.Forms.Label();
            this.label_bloco = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_contato = new System.Windows.Forms.DataGridView();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ramal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_contato = new System.Windows.Forms.TextBox();
            this.comboBox_ativo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_pesquisaLocal = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_grav = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contato)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_gravar.Location = new System.Drawing.Point(426, 420);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 8;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.BackgroundImage = global::ControllAcess.Properties.Resources.background;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_sala);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_andar);
            this.panel1.Controls.Add(this.label_bloco);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(51, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 81);
            this.panel1.TabIndex = 32;
            // 
            // label_sala
            // 
            this.label_sala.AutoSize = true;
            this.label_sala.BackColor = System.Drawing.Color.Transparent;
            this.label_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_sala.Location = new System.Drawing.Point(516, 39);
            this.label_sala.Name = "label_sala";
            this.label_sala.Size = new System.Drawing.Size(13, 15);
            this.label_sala.TabIndex = 40;
            this.label_sala.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Local:";
            // 
            // label_andar
            // 
            this.label_andar.AutoSize = true;
            this.label_andar.BackColor = System.Drawing.Color.Transparent;
            this.label_andar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_andar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_andar.Location = new System.Drawing.Point(348, 39);
            this.label_andar.Name = "label_andar";
            this.label_andar.Size = new System.Drawing.Size(13, 15);
            this.label_andar.TabIndex = 39;
            this.label_andar.Text = "*";
            // 
            // label_bloco
            // 
            this.label_bloco.AutoSize = true;
            this.label_bloco.BackColor = System.Drawing.Color.Transparent;
            this.label_bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bloco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_bloco.Location = new System.Drawing.Point(241, 39);
            this.label_bloco.Name = "label_bloco";
            this.label_bloco.Size = new System.Drawing.Size(13, 15);
            this.label_bloco.TabIndex = 38;
            this.label_bloco.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(444, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Sala/Apt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(294, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Andar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(134, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bloco/Módulo:";
            // 
            // dgv_contato
            // 
            this.dgv_contato.AllowUserToAddRows = false;
            this.dgv_contato.AllowUserToDeleteRows = false;
            this.dgv_contato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_contato.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_contato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_contato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contato.Location = new System.Drawing.Point(59, 257);
            this.dgv_contato.Name = "dgv_contato";
            this.dgv_contato.ReadOnly = true;
            this.dgv_contato.Size = new System.Drawing.Size(854, 242);
            this.dgv_contato.TabIndex = 33;
            this.dgv_contato.SelectionChanged += new System.EventHandler(this.SelecionarLinhaContato);
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(163, 151);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.Size = new System.Drawing.Size(327, 20);
            this.textBox_res.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(54, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Responsável:";
            // 
            // textBox_ramal
            // 
            this.textBox_ramal.Location = new System.Drawing.Point(596, 152);
            this.textBox_ramal.Name = "textBox_ramal";
            this.textBox_ramal.Size = new System.Drawing.Size(120, 20);
            this.textBox_ramal.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(537, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ramal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(54, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Contato:";
            // 
            // textBox_contato
            // 
            this.textBox_contato.Location = new System.Drawing.Point(163, 190);
            this.textBox_contato.Name = "textBox_contato";
            this.textBox_contato.Size = new System.Drawing.Size(327, 20);
            this.textBox_contato.TabIndex = 39;
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
            this.comboBox_ativo.Location = new System.Drawing.Point(596, 189);
            this.comboBox_ativo.Name = "comboBox_ativo";
            this.comboBox_ativo.Size = new System.Drawing.Size(79, 21);
            this.comboBox_ativo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ativo:";
            // 
            // button_pesquisaLocal
            // 
            this.button_pesquisaLocal.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisaLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisaLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisaLocal.Location = new System.Drawing.Point(749, 152);
            this.button_pesquisaLocal.Name = "button_pesquisaLocal";
            this.button_pesquisaLocal.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisaLocal.TabIndex = 42;
            this.button_pesquisaLocal.Text = "Pesquisar";
            this.button_pesquisaLocal.UseVisualStyleBackColor = false;
            this.button_pesquisaLocal.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.button_cancelar.Location = new System.Drawing.Point(415, 228);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 45;
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
            this.button_atualizar.Location = new System.Drawing.Point(138, 228);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 44;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = false;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_grav
            // 
            this.button_grav.BackColor = System.Drawing.Color.Tomato;
            this.button_grav.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grav.ForeColor = System.Drawing.SystemColors.Info;
            this.button_grav.Location = new System.Drawing.Point(57, 228);
            this.button_grav.Name = "button_grav";
            this.button_grav.Size = new System.Drawing.Size(75, 23);
            this.button_grav.TabIndex = 43;
            this.button_grav.Text = "Gravar";
            this.button_grav.UseVisualStyleBackColor = false;
            this.button_grav.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.Tomato;
            this.button_excluir.Enabled = false;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_excluir.Location = new System.Drawing.Point(219, 228);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 46;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(147, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(116, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "*";
            // 
            // ViewContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.button_grav);
            this.Controls.Add(this.button_pesquisaLocal);
            this.Controls.Add(this.comboBox_ativo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_contato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ramal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.dgv_contato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_gravar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_sala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_andar;
        private System.Windows.Forms.Label label_bloco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_contato;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ramal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_contato;
        private System.Windows.Forms.ComboBox comboBox_ativo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_pesquisaLocal;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_grav;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}