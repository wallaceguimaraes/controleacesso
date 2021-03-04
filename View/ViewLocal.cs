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
    public partial class ViewLocal : Form
    {
        public ViewLocal()
        {
            InitializeComponent();
            LocalController localC = new LocalController();
            localC.VerificaAtualizaLocal();
            ListarLocal();
        }

        Local local = new Local();

        private void ListarLocal()
        {
            LocalController localC = new LocalController();
            dgv_local.DataSource = localC.ListarLocal();
            dgv_local.Columns[0].Visible = false;
        }

        private void SelecionarLinha(object sender, EventArgs e)
        {
            if (dgv_local.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_local.Rows[dgv_local.SelectedRows[0].Index].DataBoundItem;
                local.SetLocal_id(Convert.ToInt32(dr["codigo"]));
                local.SetDisponivel(dr["Disponível"].ToString());
                local.SetLocado(dr["Locado"].ToString());
                local.SetBloco(dr["Bloco"].ToString());
                local.SetAndar(dr["Andar"].ToString());
                local.SetSala(dr["Sala"].ToString());
                textBox_bloco.Text = dr["Bloco"].ToString();
                comboBox_andar.Text = dr["Andar"].ToString();
                textBox_sala.Text = dr["Sala"].ToString();
                comboBox_ativo.Text = dr["Ativo"].ToString();
                button_excluir.Enabled = true;
                button_atualizar.Enabled = true;
                button_gravar.Enabled = false;
                textBox_sala.Enabled = false;
            }
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            LocalController localC = new LocalController();
            Local locall = new Local();
            int flag;

            if (string.IsNullOrWhiteSpace(comboBox_andar.Text) || string.IsNullOrWhiteSpace(textBox_sala.Text))
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                locall.SetBloco(textBox_bloco.Text);
                locall.SetAndar(comboBox_andar.Text);
                locall.SetSala(textBox_sala.Text);
                flag = localC.IncluirLocal(locall);

                if (flag == 1)
                {
                    MessageBox.Show("Local salvo com sucesso!");
                    ListarLocal();
                }
                else if (flag == 3)
                {
                    MessageBox.Show("Sala já cadastrada anteriormente.");
                }
                else
                {
                    MessageBox.Show("Erro ao tentar cadastrar a nova sala.");
                }
            }
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            LocalController localC = new LocalController();
            Local locall = new Local();
            locall.SetBloco(textBox_bloco.Text);
            locall.SetAndar(comboBox_andar.Text);
            locall.SetSala(textBox_sala.Text);
            locall.SetAtivo(comboBox_ativo.Text);
            dgv_local.DataSource = localC.Pesquisar(locall);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_bloco.Text = "";
            comboBox_andar.Text = "";
            textBox_sala.Text = "";
            comboBox_ativo.Text = "";
            button_excluir.Enabled = false;
            button_atualizar.Enabled = false;
            button_gravar.Enabled = true;
            textBox_sala.Enabled = true;
            ListarLocal();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            LocalController localC = new LocalController();

            int flag;

            if (local.GetDisponivel().Equals("NÃO") || local.GetLocado().Equals("NÃO"))
            {
                MessageBox.Show("O local não pode ser excluído, pois ainda está locado ou com eventos futuros.");
            }
            else if (local == null)
            {
                MessageBox.Show("Selecione o registro para excluir!");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flag = localC.ExcluirLocal(local.GetLocal_id());
                    if (flag == 1)
                    {
                        MessageBox.Show("Local excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Local não excluído!");
                    }
                }
            }
            textBox_bloco.Text = "";
            comboBox_andar.Text = "";
            textBox_sala.Text = "";
            comboBox_ativo.Text = "";
            button_excluir.Enabled = false;
            button_atualizar.Enabled = false;
            button_gravar.Enabled = true;
            textBox_sala.Enabled = true;
            ListarLocal();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_andar.Text) || string.IsNullOrWhiteSpace(textBox_sala.Text))
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                local.SetBloco(textBox_bloco.Text);
                local.SetAndar(comboBox_andar.Text);
                local.SetSala(textBox_sala.Text);
                local.SetAtivo(comboBox_ativo.Text);
                LocalController cartaC = new LocalController();
                int flag = cartaC.AtualizarLocal(local);

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
                comboBox_ativo.Text = "";
                button_excluir.Enabled = false;
                button_atualizar.Enabled = false;
                button_gravar.Enabled = true;
                textBox_sala.Enabled = true;
                ListarLocal();
            }
        }

        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewIndex index = new ViewIndex();
            index.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (local == null || local.GetLocal_id()==0)
            {
                MessageBox.Show("Para adicionar o contato selecione o local!");
            }
            else
            {
                ViewContato contato = new ViewContato(local);
                contato.Show();
                this.Hide();
            }
        }
    }
}