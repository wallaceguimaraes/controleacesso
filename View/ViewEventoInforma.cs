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
    public partial class ViewEventoInforma : Form
    {

        Evento evento;
        int local_ID;

        public ViewEventoInforma(Evento evento1)
        {
            InitializeComponent();
            evento = evento1;
            Local local = new Local();
            
            label_desc.Text = evento.GetDescricao();
            label_tipo.Text = evento.GetTipo();
            label_inicio.Text = evento.GetInicio();
            label_fim.Text = evento.GetFim();
            textBox_participantes.Text = evento.GetParticipantes();
            local=BuscarLocalPorID(evento.GetLocalId());
            label_bloco.Text = local.GetBloco();
            label_andar.Text = local.GetAndar();
            label_sala.Text = local.GetSala();
            local_ID = evento.GetLocalId();

            labelRes.Text= BuscarResponsavelPorID(local_ID);   

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

        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewIndex index = new ViewIndex();
            index.Show();
        }

        private Local BuscarLocalPorID(int ID)
        {
            Local local = new Local();
            LocalController localC = new LocalController();
            local=localC.BuscarLocalPorID(ID);
            return local;        
        }

        private string BuscarResponsavelPorID(int ID)
        {
            string nome;
            EventoController eventoC = new EventoController();
            nome=eventoC.BuscarResponsavelPorId(ID) ;
            return nome;
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        { 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewContatoInform contato = new ViewContatoInform(local_ID);
            contato.Show();
        }
    }
}
