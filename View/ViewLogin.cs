using AcessoControle.Controller;
using AcessoControle.Model.Entity;
using ControllAcess.Util;
using ControllAcess.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllAcess
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            string msg;
            Usuario usuario;

            usuario=loginController.ValidaUsuario(textBox_usuario.Text, textBox_senha.Text);

            if (usuario!=null)
            {

                Sessao sess = Sessao.getInstance();
                sess.setUsuario(usuario);
                ViewIndex index = new ViewIndex(); 
                index.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void label3nfmdnmdnfmdfn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
