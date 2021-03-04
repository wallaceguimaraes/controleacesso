namespace ControllAcess.View
{
    partial class ViewIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIndex));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCartao = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCondom = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOcorrencia = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuNovaOcorrencia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAdicionaEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocorrênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitantesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_evento = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.monthCalendar_data = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuOcorrencia,
            this.menuEvento,
            this.menuRelatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAcesso,
            this.subMenuCartao,
            this.subMenuCondom,
            this.subMenuEmpresa,
            this.subMenuLocal,
            this.subMenuFuncionario,
            this.subMenu_usuario});
            this.menuCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCadastro.ForeColor = System.Drawing.Color.Indigo;
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(69, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // subMenuAcesso
            // 
            this.subMenuAcesso.Name = "subMenuAcesso";
            this.subMenuAcesso.Size = new System.Drawing.Size(180, 22);
            this.subMenuAcesso.Text = "Acesso";
            this.subMenuAcesso.Click += new System.EventHandler(this.subMenuAcesso_Click);
            // 
            // subMenuCartao
            // 
            this.subMenuCartao.Name = "subMenuCartao";
            this.subMenuCartao.Size = new System.Drawing.Size(180, 22);
            this.subMenuCartao.Text = "Cartões";
            this.subMenuCartao.Click += new System.EventHandler(this.visitantesToolStripMenuItem1_Click);
            // 
            // subMenuCondom
            // 
            this.subMenuCondom.Name = "subMenuCondom";
            this.subMenuCondom.Size = new System.Drawing.Size(180, 22);
            this.subMenuCondom.Text = "Condôminos";
            // 
            // subMenuEmpresa
            // 
            this.subMenuEmpresa.Name = "subMenuEmpresa";
            this.subMenuEmpresa.Size = new System.Drawing.Size(180, 22);
            this.subMenuEmpresa.Text = "Empresas";
            this.subMenuEmpresa.Click += new System.EventHandler(this.subMenuEmpresa_Click);
            // 
            // subMenuFuncionario
            // 
            this.subMenuFuncionario.Name = "subMenuFuncionario";
            this.subMenuFuncionario.Size = new System.Drawing.Size(180, 22);
            this.subMenuFuncionario.Text = "Pessoas";
            this.subMenuFuncionario.Click += new System.EventHandler(this.funcionariosToolStripMenuItem2_Click);
            // 
            // subMenuLocal
            // 
            this.subMenuLocal.Name = "subMenuLocal";
            this.subMenuLocal.Size = new System.Drawing.Size(180, 22);
            this.subMenuLocal.Text = "Local";
            this.subMenuLocal.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // subMenu_usuario
            // 
            this.subMenu_usuario.Name = "subMenu_usuario";
            this.subMenu_usuario.Size = new System.Drawing.Size(180, 22);
            this.subMenu_usuario.Text = "Usuário";
            // 
            // menuOcorrencia
            // 
            this.menuOcorrencia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuNovaOcorrencia});
            this.menuOcorrencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOcorrencia.ForeColor = System.Drawing.Color.Indigo;
            this.menuOcorrencia.Name = "menuOcorrencia";
            this.menuOcorrencia.Size = new System.Drawing.Size(83, 20);
            this.menuOcorrencia.Text = "Ocorrências";
            // 
            // subMenuNovaOcorrencia
            // 
            this.subMenuNovaOcorrencia.Name = "subMenuNovaOcorrencia";
            this.subMenuNovaOcorrencia.Size = new System.Drawing.Size(163, 22);
            this.subMenuNovaOcorrencia.Text = "Nova ocorrência";
            // 
            // menuEvento
            // 
            this.menuEvento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAdicionaEvento});
            this.menuEvento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEvento.ForeColor = System.Drawing.Color.Indigo;
            this.menuEvento.Name = "menuEvento";
            this.menuEvento.Size = new System.Drawing.Size(60, 20);
            this.menuEvento.Text = "Eventos";
            // 
            // subMenuAdicionaEvento
            // 
            this.subMenuAdicionaEvento.Name = "subMenuAdicionaEvento";
            this.subMenuAdicionaEvento.Size = new System.Drawing.Size(165, 22);
            this.subMenuAdicionaEvento.Text = "Adicionar evento";
            this.subMenuAdicionaEvento.Click += new System.EventHandler(this.adicionarEventoToolStripMenuItem_Click);
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoToolStripMenuItem,
            this.empresasToolStripMenuItem1,
            this.eventosToolStripMenuItem1,
            this.funcionáriosToolStripMenuItem,
            this.ocorrênciasToolStripMenuItem,
            this.visitantesToolStripMenuItem3});
            this.menuRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRelatorio.ForeColor = System.Drawing.Color.Indigo;
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(73, 20);
            this.menuRelatorio.Text = "Relatórios";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.acessoToolStripMenuItem.Text = "Acesso";
            // 
            // empresasToolStripMenuItem1
            // 
            this.empresasToolStripMenuItem1.Name = "empresasToolStripMenuItem1";
            this.empresasToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.empresasToolStripMenuItem1.Text = "Empresas";
            // 
            // eventosToolStripMenuItem1
            // 
            this.eventosToolStripMenuItem1.Name = "eventosToolStripMenuItem1";
            this.eventosToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.eventosToolStripMenuItem1.Text = "Eventos";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // ocorrênciasToolStripMenuItem
            // 
            this.ocorrênciasToolStripMenuItem.Name = "ocorrênciasToolStripMenuItem";
            this.ocorrênciasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ocorrênciasToolStripMenuItem.Text = "Ocorrências";
            // 
            // visitantesToolStripMenuItem3
            // 
            this.visitantesToolStripMenuItem3.Name = "visitantesToolStripMenuItem3";
            this.visitantesToolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.visitantesToolStripMenuItem3.Text = "Visitantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "OlaCabeca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de eventos";
            // 
            // dgv_evento
            // 
            this.dgv_evento.AllowUserToAddRows = false;
            this.dgv_evento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.dgv_evento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_evento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_evento.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_evento.Location = new System.Drawing.Point(12, 21);
            this.dgv_evento.Name = "dgv_evento";
            this.dgv_evento.ReadOnly = true;
            this.dgv_evento.Size = new System.Drawing.Size(705, 304);
            this.dgv_evento.TabIndex = 4;
            this.dgv_evento.SelectionChanged += new System.EventHandler(this.SelecionarLinhaEvento);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(310, 130);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(363, 20);
            this.textBox_desc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo:";
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "ABERTO",
            "FECHADO"});
            this.comboBox_tipo.Location = new System.Drawing.Point(719, 130);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo.TabIndex = 9;
            // 
            // monthCalendar_data
            // 
            this.monthCalendar_data.BackColor = System.Drawing.Color.Tomato;
            this.monthCalendar_data.Location = new System.Drawing.Point(69, 152);
            this.monthCalendar_data.Name = "monthCalendar_data";
            this.monthCalendar_data.ShowToday = false;
            this.monthCalendar_data.ShowTodayCircle = false;
            this.monthCalendar_data.TabIndex = 10;
            this.monthCalendar_data.Visible = false;
            this.monthCalendar_data.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.SelecionarData);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data:";
            this.label5.Click += new System.EventHandler(this.comboBox_data_SelectedIndexChanged);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Tomato;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pesquisar.Location = new System.Drawing.Point(971, 128);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 28;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(802, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Perfil:";
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.BackColor = System.Drawing.Color.Transparent;
            this.labelPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfil.ForeColor = System.Drawing.Color.Indigo;
            this.labelPerfil.Location = new System.Drawing.Point(840, 24);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(0, 15);
            this.labelPerfil.TabIndex = 30;
            // 
            // comboBox_data
            // 
            this.comboBox_data.Enabled = false;
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Items.AddRange(new object[] {
            "ABERTO",
            "FECHADO"});
            this.comboBox_data.Location = new System.Drawing.Point(68, 131);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(229, 21);
            this.comboBox_data.TabIndex = 31;
            this.comboBox_data.Click += new System.EventHandler(this.comboBox_data_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgv_evento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(310, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 332);
            this.panel1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(69, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.Image = global::ControllAcess.Properties.Resources.config;
            this.pictureBox1.Location = new System.Drawing.Point(310, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ViewIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1084, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_data);
            this.Controls.Add(this.labelPerfil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar_data);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ViewIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voltar);
            this.EnabledChanged += new System.EventHandler(this.comboBox_data_SelectedIndexChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem subMenuAcesso;
        private System.Windows.Forms.ToolStripMenuItem subMenuCartao;
        private System.Windows.Forms.ToolStripMenuItem subMenuFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem subMenuLocal;
        private System.Windows.Forms.ToolStripMenuItem menuOcorrencia;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem subMenuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem subMenuNovaOcorrencia;
        private System.Windows.Forms.ToolStripMenuItem subMenuAdicionaEvento;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocorrênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitantesToolStripMenuItem3;
        private System.Windows.Forms.DataGridView dgv_evento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.MonthCalendar monthCalendar_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStripMenuItem subMenu_usuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuCondom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}