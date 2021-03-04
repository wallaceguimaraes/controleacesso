namespace ControllAcess.View
{
    partial class ViewCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCam));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_capturar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_imagem2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_imagem1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.Color.Tomato;
            this.button_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gravar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_gravar.Location = new System.Drawing.Point(331, 55);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 30);
            this.button_gravar.TabIndex = 3;
            this.button_gravar.Text = "Iniciar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.SelecionaCam);
            // 
            // button_capturar
            // 
            this.button_capturar.BackColor = System.Drawing.Color.Tomato;
            this.button_capturar.Enabled = false;
            this.button_capturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_capturar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_capturar.Image = global::ControllAcess.Properties.Resources.camer1;
            this.button_capturar.Location = new System.Drawing.Point(412, 55);
            this.button_capturar.Name = "button_capturar";
            this.button_capturar.Size = new System.Drawing.Size(48, 30);
            this.button_capturar.TabIndex = 4;
            this.button_capturar.UseVisualStyleBackColor = false;
            this.button_capturar.Click += new System.EventHandler(this.button_capturar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ControllAcess.Properties.Resources.salvar;
            this.button1.Location = new System.Drawing.Point(549, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(467, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_imagem2
            // 
            this.pictureBox_imagem2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_imagem2.Location = new System.Drawing.Point(75, 119);
            this.pictureBox_imagem2.Name = "pictureBox_imagem2";
            this.pictureBox_imagem2.Size = new System.Drawing.Size(640, 480);
            this.pictureBox_imagem2.TabIndex = 1;
            this.pictureBox_imagem2.TabStop = false;
            this.pictureBox_imagem2.Visible = false;
            // 
            // pictureBox_imagem1
            // 
            this.pictureBox_imagem1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_imagem1.Location = new System.Drawing.Point(75, 121);
            this.pictureBox_imagem1.Name = "pictureBox_imagem1";
            this.pictureBox_imagem1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox_imagem1.TabIndex = 0;
            this.pictureBox_imagem1.TabStop = false;
            // 
            // ViewCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_capturar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox_imagem2);
            this.Controls.Add(this.pictureBox_imagem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Voltar);
            this.Load += new System.EventHandler(this.ViewCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_imagem1;
        private System.Windows.Forms.PictureBox pictureBox_imagem2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_capturar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}