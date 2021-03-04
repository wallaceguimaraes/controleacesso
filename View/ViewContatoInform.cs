using ControllAcess.Controller;
using ControllAcess.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllAcess.View
{
    public partial class ViewContatoInform : Form
    {
        int local_ID;

        public ViewContatoInform(int local_id)
        {
            InitializeComponent();
            local_ID = local_id;
            ListarContato();
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref message);
        }

        private void ListarContato()
        {
            ContatoController contatoC = new ContatoController();
            dgv_contato.DataSource = contatoC.BuscarContatosPorID(local_ID);
            dgv_contato.Columns[0].Visible = false;
            dgv_contato.Columns[4].Visible = false;

        }


        /*
        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewEventoInforma index = new ViewEventoInforma(evento);
            index.Show();
        }
        */


    }
}
