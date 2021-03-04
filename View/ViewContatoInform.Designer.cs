namespace ControllAcess.View
{
    partial class ViewContatoInform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContatoInform));
            this.dgv_contato = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contato
            // 
            this.dgv_contato.AllowUserToAddRows = false;
            this.dgv_contato.AllowUserToDeleteRows = false;
            this.dgv_contato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_contato.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_contato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_contato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contato.Location = new System.Drawing.Point(55, 126);
            this.dgv_contato.Name = "dgv_contato";
            this.dgv_contato.ReadOnly = true;
            this.dgv_contato.Size = new System.Drawing.Size(939, 296);
            this.dgv_contato.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Lista de contatos";
            // 
            // ViewContatoInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControllAcess.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1080, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_contato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewContatoInform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contato;
        private System.Windows.Forms.Label label1;
    }
}