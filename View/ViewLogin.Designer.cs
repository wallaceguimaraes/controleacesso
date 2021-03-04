namespace ControllAcess
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_usuario.ForeColor = System.Drawing.Color.Chocolate;
            this.textBox_usuario.Location = new System.Drawing.Point(418, 187);
            this.textBox_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(260, 22);
            this.textBox_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(415, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_senha.ForeColor = System.Drawing.Color.Chocolate;
            this.textBox_senha.Location = new System.Drawing.Point(418, 240);
            this.textBox_senha.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(260, 22);
            this.textBox_senha.TabIndex = 2;
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(415, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // button_entrar
            // 
            this.button_entrar.BackColor = System.Drawing.Color.Tomato;
            this.button_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_entrar.FlatAppearance.BorderSize = 4;
            this.button_entrar.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_entrar.Location = new System.Drawing.Point(489, 270);
            this.button_entrar.Margin = new System.Windows.Forms.Padding(4);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(112, 28);
            this.button_entrar.TabIndex = 4;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = false;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ControllAcess.Properties.Resources.logoscac2;
            this.pictureBox1.Location = new System.Drawing.Point(437, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 152);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(735, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

