using AcessoControle.Model.Entity;
using ControllAcess.Controller;
using ControllAcess.Model.Entity;
using ControllAcess.Util;
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
    public partial class ViewIndex : Form
    {
        public ViewIndex()
        {
            InitializeComponent();
            Usuario usu = new Usuario();
            usu = Sessao.getInstance().getUsuario();
            labelPerfil.Text = usu.GetPerfil();
            
            string data = DateTime.Today.ToString();
            int flag = 0; //flag recebendo 0 informando que devo pegar a segunda query listando apenas eventos a partir da data atual

            if (usu.GetPerfil()=="EMPRESA")
            {
                label1.Text = "BEM VINDO AO SISTEMA DE CONTROLE DE ACESSO " + usu.GetUsuario();
                
                subMenuAcesso.Visible = false;
                subMenuCartao.Visible = false;
                subMenuLocal.Visible = false;
                subMenu_usuario.Visible = false;
                subMenuEmpresa.Visible = false;
                subMenuCondom.Visible = false;
                dgv_evento.Visible = false;
                //panel1.Visible = false;
                monthCalendar_data.Visible = false;
                label5.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox_desc.Visible = false;
                comboBox_tipo.Visible = false;
                button_pesquisar.Visible = false;
                menuOcorrencia.Visible = false;
                menuRelatorio.Visible = false;
                panel1.Visible = false;
            }
            else if(usu.GetPerfil()=="CONDÔMINO")
            {
                label1.Text = "BEM VINDO AO SISTEMA DE CONTROLE DE ACESSO " + usu.GetUsuario();
                menuCadastro.Visible = false;
                dgv_evento.Visible = false;
                //panel1.Visible = false;
                monthCalendar_data.Visible = false;
                label5.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox_desc.Visible = false;
                comboBox_tipo.Visible = false;
                button_pesquisar.Visible = false;
                menuOcorrencia.Visible = false;
                menuRelatorio.Visible = false;
                panel1.Visible = false;

            }else if (usu.GetPerfil()=="RECEPÇÃO")
            {
                label1.Text = "BEM VINDO AO SISTEMA DE CONTROLE DE ACESSO " + usu.GetUsuario();
                menuEvento.Visible = false;
                menuRelatorio.Visible = false;
                subMenuEmpresa.Visible = false;
                subMenuFuncionario.Visible = false;
                subMenuLocal.Visible = false;
            }
            else if(usu.GetPerfil()=="ADMINISTRADOR")
            {
                label1.Text = "BEM VINDO AO SISTEMA DE CONTROLE DE ACESSO " + usu.GetUsuario();
            }
            ListarEvento(data, flag);
        }


        Evento evento = new Evento();
        int flagData = 1;


        private void visitantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCartao cartao = new ViewCartao();
            cartao.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListarEvento(string data, int flag)
        {
            EventoController eventoC = new EventoController();
            dgv_evento.DataSource = eventoC.ListarEvento(data, flag);
            dgv_evento.Columns[0].Visible = false;
            dgv_evento.Columns[3].Visible = false;
            dgv_evento.Columns[7].Visible = false;
            dgv_evento.Columns[8].Visible = false;
        }

        private void visitantesToolStripMenuItem2_Click(object sender, EventArgs e)
        {


            



        }

        private void adicionarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEvento evento = new ViewEvento();
            evento.Show();
            this.Hide();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLocal local = new ViewLocal();
            local.Show();
            this.Hide();
        }

        private void SelecionarLinhaEvento(object sender, EventArgs e)
        {
            if (dgv_evento.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_evento.Rows[dgv_evento.SelectedRows[0].Index].DataBoundItem;
                evento.SetEvento_id(Convert.ToInt32(dr["codigo"]));
                evento.SetAtivo(dr["Ativo"].ToString());
                evento.SetDescricao(dr["Descricao"].ToString());
                evento.SetData(dr["Data"].ToString());
                evento.SetFim(dr["Fim"].ToString());
                evento.SetInicio(dr["Início"].ToString());
                evento.SetParticipantes(dr["Participantes"].ToString());
                evento.SetTipo(dr["Tipo"].ToString());
                evento.SetLocalId(Convert.ToInt32(dr["local_id"]));
                ViewEventoInforma informa = new ViewEventoInforma(evento);
                informa.Show();
                this.Hide();      
            }
        }

        private void Voltar(object sender, FormClosingEventArgs e)
        {
            //ViewLogin login = new ViewLogin();
        }


        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            EventoController eventoC = new EventoController();
            Evento eventol = new Evento();
            eventol.SetDescricao(textBox_desc.Text);
            eventol.SetTipo(comboBox_tipo.Text);
            eventol.SetData(evento.GetData());
            dgv_evento.DataSource = eventoC.Pesquisar(eventol);
            evento.SetData(null);
        }

        private void SelecionarData(object sender, DateRangeEventArgs e)
        {
            evento.SetData(monthCalendar_data.SelectionStart.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(evento.GetData());
        }

        private void comboBox_data_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (flagData == 1)
            {
                flagData = 0;
                monthCalendar_data.Visible = true;

            }
            else
            {
                flagData = 1;
                monthCalendar_data.Visible = false;
            }
        }

        private void subMenuEmpresa_Click(object sender, EventArgs e)
        {
            ViewEmpresa empresa = new ViewEmpresa();
            empresa.Show();
            this.Hide();
        }

        private void subMenuAcesso_Click(object sender, EventArgs e)
        {

            ViewAcesso acesso = new ViewAcesso();
            acesso.Show();
            this.Hide();


        }

        private void funcionariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewPessoa pessoa = new ViewPessoa();
            pessoa.Show();
            this.Hide();
        }
    }
}
