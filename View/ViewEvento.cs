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
    public partial class ViewEvento : Form
    {
        Usuario usu = new Usuario();

        public ViewEvento()
        {
            InitializeComponent();
            usu = Sessao.getInstance().getUsuario();
            string data = DateTime.Today.ToString();
            int flag = 1;


            ListarEvento(data, flag);
            ListarLocal();

        }

        Evento evento = new Evento();
        Local local = new Local();
        int flagData = 1;
       

        private void ListarLocal()
        {
            LocalController localC = new LocalController();



            if (usu.GetPerfil()=="ADMINISTRADOR")
            {
                dgv_local.DataSource = localC.ListarLocal();
                dgv_local.Columns[0].Visible = false;
                dgv_local.Columns[4].Visible = false;
            }
            else
            {
                dgv_local.DataSource = localC.ListarLocalPorID(usu.GetLocal_id());
                dgv_local.Columns[0].Visible = false;
                dgv_local.Columns[4].Visible = false;
                button_pesquisaLocal.Visible = false;
                textBox_bloco.Enabled = false;
                comboBox_andar.Enabled = false;
                textBox_sala.Enabled = false;


            }            
        }
      
        private void SelecionarLinhaLocal(object sender, EventArgs e)
        {
            if (dgv_local.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_local.Rows[dgv_local.SelectedRows[0].Index].DataBoundItem;
               

                if (MessageBox.Show("Local escolhido 'BLOCO/MÓDULO' "+ dr["Bloco"].ToString() +" 'ANDAR "+ dr["Andar"].ToString() +" 'SALA/APT' "+ dr["Sala"].ToString() +"  Confirma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    local.SetLocal_id(Convert.ToInt32(dr["codigo"]));
                    local.SetDisponivel(dr["Disponível"].ToString());
                    local.SetLocado(dr["Locado"].ToString());
                    textBox_bloco.Text = dr["Bloco"].ToString();
                    comboBox_andar.Text = dr["Andar"].ToString();
                    textBox_sala.Text = dr["Sala"].ToString();
                }
            }
        }
  
        private void button_pesquisarLocal_Click(object sender, EventArgs e)
        {
            LocalController localC = new LocalController();
            Local locall = new Local();
            locall.SetBloco(textBox_bloco.Text);
            locall.SetAndar(comboBox_andar.Text);
            locall.SetSala(textBox_sala.Text);
            dgv_local.DataSource = localC.Pesquisar(locall);

        }

        private void ListarEvento(string data, int flag)
        {


            if (usu.GetPerfil() == "ADMINISTRADOR")
            {
                EventoController eventoC = new EventoController();
                dgv_evento.DataSource = eventoC.ListarEvento(data, flag);
                dgv_evento.Columns[0].Visible = false;
                dgv_evento.Columns[3].Visible = false;
                dgv_evento.Columns[7].Visible = false;
                dgv_evento.Columns[8].Visible = false;
            }
            else
            {
                EventoController eventoC = new EventoController();
                dgv_evento.DataSource = eventoC.ListarEventoPorId(usu.GetUsuario_id());
                dgv_evento.Columns[0].Visible = false;
                dgv_evento.Columns[3].Visible = false;
                dgv_evento.Columns[7].Visible = false;
                dgv_evento.Columns[8].Visible = false;
            }

        }

        private void SelecionarLinhaEvento(object sender, EventArgs e)
        {
            if (dgv_evento.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_evento.Rows[dgv_evento.SelectedRows[0].Index].DataBoundItem;
                evento.SetEvento_id(Convert.ToInt32(dr["codigo"]));
                evento.SetAtivo(dr["Ativo"].ToString());
                textBox_desc.Text = dr["Descricao"].ToString();
                comboBox_tipo.Text = dr["Tipo"].ToString();
                textBox_participantes.Text = dr["Participantes"].ToString();
                monthCalendar_data.RemoveAllBoldedDates();
                monthCalendar_data.UpdateBoldedDates();
                string data = dr["Data"].ToString();             
                monthCalendar_data.AddBoldedDate(DateTime.Parse(data.Substring(0, data.IndexOf(" "))));
                monthCalendar_data.UpdateBoldedDates();
                maskedTextBox_ini.Text = dr["Início"].ToString();
                maskedTextBox_fim.Text = dr["Fim"].ToString();
                ListarLocalPorID(Convert.ToInt32(dr["local_id"].ToString()));
                button_excluir.Enabled = true;
                button_atualizar.Enabled = true;
                button_gravar.Enabled = false;
                this.monthCalendar_data.Visible = true;
                flagData = 0;
            }
        }

        private void ListarLocalPorID(int ID)
        {
            LocalController localC = new LocalController();
            dgv_local.DataSource = localC.ListarLocalPorID(ID);
            dgv_local.Columns[0].Visible = false;
            dgv_local.Columns[4].Visible = false;
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            EventoController eventoC = new EventoController();
            Evento eventol = new Evento();
            Usuario usu = new Usuario();
            usu = Sessao.getInstance().getUsuario();
            int flag;

            if (string.IsNullOrWhiteSpace(evento.GetData()) || string.IsNullOrWhiteSpace(textBox_desc.Text) || string.IsNullOrWhiteSpace(comboBox_tipo.Text) || !maskedTextBox_ini.MaskCompleted || !maskedTextBox_fim.MaskCompleted || local.GetLocal_id() == 0)
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                int a = Convert.ToInt32(maskedTextBox_ini.Text.Replace(":", ""));
                int b = Convert.ToInt32(maskedTextBox_fim.Text.Replace(":", ""));

                if (a > b)
                {
                    MessageBox.Show("Horário de início não pode ser maior do que o término do evento!");
                }
                else if (b > a)
                {
                    int retorno;
                    retorno = eventoC.ValidarHoraEvento(textBox_sala.Text, evento.GetData(), maskedTextBox_ini.Text, maskedTextBox_fim.Text);
                    if (retorno == 1)
                    {
                        MessageBox.Show("Já existe um evento agendado para esta sala e dentro do horário estipulado, por favor tente outro horário! ");
                    }
                    else
                    {
                        string participante = textBox_participantes.Text;
                        string tipo = comboBox_tipo.Text;
                        if (string.IsNullOrWhiteSpace(participante)) { participante = ""; }
                        if (tipo == "FECHADO" && participante == "")
                        {
                            MessageBox.Show("Para evento fechado é necessário preencher o campo de participantes!");
                        }
                        else
                        {
                            DateTime date = DateTime.Parse(evento.GetData());
                            if (date < DateTime.Today)
                            {
                                MessageBox.Show("Data inválida, o evento só pode ser cadastrado com a data a partir de hoje!");
                            }
                            else
                            {
                                eventol.SetDescricao(textBox_desc.Text);
                                eventol.SetTipo(comboBox_tipo.Text);
                                eventol.SetParticipantes(textBox_participantes.Text);
                                eventol.SetData(evento.GetData());
                                eventol.SetInicio(maskedTextBox_ini.Text);
                                eventol.SetFim(maskedTextBox_fim.Text);
                                eventol.SetUsuarioId(usu.GetUsuario_id());
                                eventol.SetLocalId(local.GetLocal_id());
                                flag = eventoC.IncluirEvento(eventol);

                                if (flag == 1)
                                {
                                    MessageBox.Show("Evento enviado para a recepção!");
                                    textBox_bloco.Text = "";
                                    comboBox_andar.Text = "";
                                    textBox_sala.Text = "";
                                    textBox_desc.Text = "";
                                    comboBox_tipo.Text = "";
                                    maskedTextBox_ini.Text = "";
                                    maskedTextBox_fim.Text = "";

                                    button_excluir.Enabled = false;
                                    button_atualizar.Enabled = false;
                                    button_gravar.Enabled = true;
                                    evento.SetData(" ");
                                    dateTimePicker2.Value = DateTime.Today;
                                    textBox_participantes.Text = "";
                                    ListarLocal();
                                    ListarEvento(DateTime.Today.ToString(), 1);
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao tentar cadastrar o novo evento.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O horário do início não pode ser igual ao horário de término do evento!");

                }
            }
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

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_bloco.Text = "";
            comboBox_andar.Text = "";
            textBox_sala.Text = "";
            textBox_desc.Text = "";
            textBox_participantes.Text= "";
            comboBox_tipo.Text = "";
            maskedTextBox_ini.Text = "";
            maskedTextBox_fim.Text = "";
            button_excluir.Enabled = false;
            button_atualizar.Enabled = false;
            button_gravar.Enabled = true;
            ListarEvento(DateTime.Today.ToString(), 1);
            //    ListarLocal();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            EventoController eventoC = new EventoController();

            int flag;

            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = eventoC.ExcluirEvento(evento.GetEvento_id());
                if (flag == 1)
                {
                    MessageBox.Show("Evento excluído com sucesso!");
                    textBox_bloco.Text = "";
                    comboBox_andar.Text = "";
                    textBox_sala.Text = "";

                    textBox_desc.Text = "";
                    textBox_participantes.Text = "";
                    comboBox_tipo.Text = "";
                    maskedTextBox_ini.Text = "";
                    maskedTextBox_fim.Text = "";
                    button_excluir.Enabled = false;
                    button_atualizar.Enabled = false;
                    button_gravar.Enabled = true;
                    ListarEvento(DateTime.Today.ToString(), 1);


                }
                else
                {
                    MessageBox.Show("Evento não excluído!");
                }
            }
           
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(evento.GetData()) || string.IsNullOrWhiteSpace(textBox_desc.Text) || string.IsNullOrWhiteSpace(comboBox_tipo.Text) || !maskedTextBox_ini.MaskCompleted || !maskedTextBox_fim.MaskCompleted || local.GetLocal_id() == 0)
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                int a = Convert.ToInt32(maskedTextBox_ini.Text.Replace(":", ""));
                int b = Convert.ToInt32(maskedTextBox_fim.Text.Replace(":", ""));

                if (a > b)
                {
                    MessageBox.Show("Horário de início não pode ser maior do que o término do evento!");
                }
                else if (b > a)
                {
                    int retorno;
                    EventoController eventoC = new EventoController();

                    retorno = eventoC.ValidarHoraEvento(textBox_sala.Text, evento.GetData(), maskedTextBox_ini.Text, maskedTextBox_fim.Text);
                    if (retorno == 1)
                    {
                        MessageBox.Show("Já existe um evento agendado para esta sala e dentro do horário estipulado, por favor tente outro horário! ");
                    }
                    else
                    {

                        string participante = textBox_participantes.Text;
                        string tipo = comboBox_tipo.Text;
                        if (string.IsNullOrWhiteSpace(participante)) { participante = ""; }

                        if (tipo == "FECHADO" && participante == "")
                        {
                            MessageBox.Show("Para evento fechado é necessário preencher o campo de participantes!");
                        }
                        else
                        {
                            DateTime date = DateTime.Parse(evento.GetData());
                            if (date < DateTime.Today)
                            {
                                MessageBox.Show("Data inválida, o evento só pode ser atualizado com a data a partir de hoje!");
                            }
                            else
                            {
                                evento.SetDescricao(textBox_desc.Text);
                                evento.SetTipo(comboBox_tipo.Text);
                                evento.SetParticipantes(textBox_participantes.Text);
                                evento.SetData(evento.GetData());
                                evento.SetInicio(maskedTextBox_ini.Text);
                                evento.SetFim(maskedTextBox_fim.Text);
                                evento.SetLocalId(local.GetLocal_id());
                                EventoController cartaC = new EventoController();
                                int flag = cartaC.AtualizarEvento(evento);
                                if (flag == 1)
                                {
                                    MessageBox.Show("Registro atualizado com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Ocorreu algum erro na atualização do registro.");
                                }

                                textBox_bloco.Text = "";
                                comboBox_andar.Text = "";
                                textBox_sala.Text = "";
                                textBox_desc.Text = "";
                                textBox_participantes.Text = "";
                                comboBox_tipo.Text = "";
                                maskedTextBox_ini.Text = "";
                                maskedTextBox_fim.Text = "";
                                button_excluir.Enabled = false;
                                button_atualizar.Enabled = false;
                                button_gravar.Enabled = true;
                                ListarEvento(DateTime.Today.ToString(), 1);
                            }
                        }





                    }

                }

            }
        }

        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewIndex index = new ViewIndex();
            index.Show();
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

        private void SelecionarData(object sender, DateRangeEventArgs e)
        {
          evento.SetData(monthCalendar_data.SelectionStart.ToString());
            dateTimePicker2.Value =Convert.ToDateTime(evento.GetData());


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(maskedTextBox_ini.Text.Replace(":",""));
            int b = Convert.ToInt32(maskedTextBox_fim.Text.Replace(":",""));

            if (a > b)
            {
                MessageBox.Show("Horário de início não pode ser maior do que o término do evento!");
            }else if (b > a)
            {

                EventoController eventoC = new EventoController();
                int flag;
                flag=eventoC.ValidarHoraEvento(textBox_sala.Text,evento.GetData(), maskedTextBox_ini.Text,maskedTextBox_fim.Text);
                if (flag==1)
                {
                    MessageBox.Show("Já existe um evento agendado para esta sala e dentro do horário estipulado, por favor tente outro horário! ");
                }
                else
                {
                    //permite a gravação
                    MessageBox.Show("Horario disponivel");
                }

            }
            else
            {
                MessageBox.Show("O horário do início não pode ser igual ao horário de término do evento!");

            }



        }
    }
}
