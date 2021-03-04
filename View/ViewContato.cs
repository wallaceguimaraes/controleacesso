using ControllAcess.Controller;
using ControllAcess.Model.Entity;
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

namespace ControllAcess.View
{
    public partial class ViewContato : Form
    {

        Local local = new Local();

        public ViewContato(Local local1)
        {
            InitializeComponent();
            local = local1;

            label_bloco.Text = local.GetBloco();
            label_andar.Text = local.GetAndar();
            label_sala.Text = local.GetSala();
            ListarContato();

        }

        Contato contato = new Contato();

        private void ListarContato()
        {
            ContatoController contatoC = new ContatoController();
            dgv_contato.DataSource = contatoC.BuscarContatosPorID(local.GetLocal_id());
            dgv_contato.Columns[0].Visible = false;
            dgv_contato.Columns[4].Visible = false;        
        }

        private void SelecionarLinhaContato(object sender, EventArgs e)
        {
            if (dgv_contato.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_contato.Rows[dgv_contato.SelectedRows[0].Index].DataBoundItem;
                contato.SetContato_id(Convert.ToInt32(dr["codigo"]));
                contato.SetAtivo(dr["Ativo"].ToString());
                textBox_contato.Text = dr["Contato"].ToString();
                comboBox_ativo.Text = dr["Ativo"].ToString();
                textBox_res.Text = dr["Responsável"].ToString();
                textBox_ramal.Text = dr["Ramal"].ToString();
                button_excluir.Enabled = true;
                button_atualizar.Enabled = true;
                button_grav.Enabled = false;
            }
        }


        private void button_gravar_Click(object sender, EventArgs e)
        {
            ContatoController contatoC = new ContatoController();
            Contato contatol = new Contato();

            int flag;

            if (string.IsNullOrWhiteSpace(textBox_contato.Text) || string.IsNullOrWhiteSpace(textBox_res.Text))
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                contatol.SetContato(textBox_contato.Text);
                contatol.SetResponsavel(textBox_res.Text);
                contatol.SetRamal(textBox_ramal.Text);
                contatol.SetLocalID(local.GetLocal_id());

                flag = contatoC.IncluirContato(contatol);

                if (flag == 1)
                {
                    MessageBox.Show("Contato salvo com sucesso!");
                    ListarContato();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar cadastrar o novo contato.");
                }

            }    
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            ContatoController contatoC = new ContatoController();
            Contato contatol = new Contato();
            contatol.SetContato(textBox_contato.Text);
            contatol.SetResponsavel(textBox_res.Text);
            contatol.SetRamal(textBox_ramal.Text);
            contatol.SetAtivo(comboBox_ativo.Text);
            contatol.SetLocalID(local.GetLocal_id());
            dgv_contato.DataSource = contatoC.Pesquisar(contatol);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_contato.Text = "";
            comboBox_ativo.Text = "";
            textBox_ramal.Text = "";
            textBox_res.Text = "";
         
            button_excluir.Enabled = false;
            button_atualizar.Enabled = false;
            button_grav.Enabled = true;
            ListarContato();
            //    ListarLocal();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            ContatoController contatoC = new ContatoController();

            int flag;

            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = contatoC.ExcluirContato(contato.GetContato_id());
                if (flag == 1)
                {
                    MessageBox.Show("Contato excluído com sucesso!");
                    textBox_contato.Text = "";
                    comboBox_ativo.Text = "";
                    textBox_ramal.Text = "";
                    textBox_res.Text = "";
                    button_excluir.Enabled = false;
                    button_atualizar.Enabled = false;
                    button_grav.Enabled = true;
                    ListarContato();
                }
                else
                {
                    MessageBox.Show("Contato não excluído!");
                }
            }

          
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_contato.Text) || string.IsNullOrWhiteSpace(textBox_res.Text))
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {

                contato.SetContato(textBox_contato.Text);
                contato.SetResponsavel(textBox_res.Text);
                contato.SetRamal(textBox_ramal.Text);
                contato.SetAtivo(comboBox_ativo.Text);
                contato.SetLocalID(local.GetLocal_id());
                ContatoController cartaC = new ContatoController();
                        int flag = cartaC.AtualizarContato(contato);
                        if (flag == 1)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu algum erro na atualização do registro.");
                        }
                textBox_contato.Text = "";
                comboBox_ativo.Text = "";
                textBox_ramal.Text = "";
                textBox_res.Text = "";
                button_excluir.Enabled = false;
                        button_atualizar.Enabled = false;
                        button_grav.Enabled = true;
                        ListarContato();
                    }
                }
        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewLocal local = new ViewLocal();
            local.Show();
        }
        }
        }

     

       
