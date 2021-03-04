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
    public partial class ViewEmpresa : Form
    {
        public ViewEmpresa()
        {
            InitializeComponent();
           // usu = Sessao.getInstance().getUsuario();
            string data = DateTime.Today.ToString();
            int flag = 1;
            ListarEmpresa();
            ListarLocal();

        }



        Empresa empresa = new Empresa();
        Local local = new Local();


        private void ListarLocal()
        {
            LocalController localC = new LocalController();
                dgv_local.DataSource = localC.ListarLocalNaoAlocado();
                dgv_local.Columns[0].Visible = false;
                dgv_local.Columns[4].Visible = false;
         
        }


        private void SelecionarLinhaLocal(object sender, EventArgs e)
        {
            if (dgv_local.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_local.Rows[dgv_local.SelectedRows[0].Index].DataBoundItem;



                if (dr["Locado"].ToString()=="SIM") { MessageBox.Show("O local selecionado já está locado!"); return; }



                if (MessageBox.Show("Local escolhido 'BLOCO/MÓDULO' " + dr["Bloco"].ToString() + " 'ANDAR " + dr["Andar"].ToString() + " 'SALA/APT' " + dr["Sala"].ToString() + "  Confirma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    local.SetLocal_id(Convert.ToInt32(dr["codigo"]));
                    local.SetDisponivel(dr["Disponível"].ToString());
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
            dgv_local.DataSource = localC.PesquisarLocalNaoAlocado(locall);
            dgv_local.Columns[0].Visible = false;

        }

        private void ListarEmpresa()
        {
            EmpresaController empresaC = new EmpresaController();
            dgv_empresa.DataSource = empresaC.ListarEmpresa();
            dgv_empresa.Columns[0].Visible = false;
            dgv_empresa.Columns[6].Visible = false;

        }

        private void SelecionarLinhaEmpresa(object sender, EventArgs e)
        {
            if (dgv_empresa.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_empresa.Rows[dgv_empresa.SelectedRows[0].Index].DataBoundItem;
                empresa.SetEmpresa_id(Convert.ToInt32(dr["codigo"]));
                empresa.SetAtivo(dr["Ativo"].ToString());
                textBox_empresa.Text = dr["Empresa"].ToString();
                textBox_razao.Text = dr["Razão"].ToString();
                textBox_cnpj.Text = dr["CNPJ"].ToString();
                maskedTextBox_data.Text = dr["Locação"].ToString();

                ListarLocalPorID(Convert.ToInt32(dr["local_id"].ToString()));
                button_excluir.Enabled = true;
                button_atualizar.Enabled = true;
                button_gravar.Enabled = false;



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
            EmpresaController empresaC = new EmpresaController();
            Empresa empresal = new Empresa();
          

            int flag;

            if ( string.IsNullOrWhiteSpace(textBox_empresa.Text) || string.IsNullOrWhiteSpace(textBox_cnpj.Text) || !maskedTextBox_data.MaskCompleted || local.GetLocal_id() == 0)
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                                     
                        empresal.SetEmpresa(textBox_empresa.Text);
                        empresal.SetRazaoSocial(textBox_razao.Text);
                        empresal.SetCnpj(textBox_cnpj.Text);
                        empresal.SetData(maskedTextBox_data.Text);                      
                        empresal.SetLocalId(local.GetLocal_id());
                        flag = empresaC.IncluirEmpresa(empresal);

                        if (flag == 1)
                        {
                            MessageBox.Show("Empresa cadastrada com sucesso!");
                            ListarEmpresa();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao tentar cadastrar a nova empresa.");
                        }
                    }
                }
      
        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            EmpresaController empresaC = new EmpresaController();
            Empresa empresal = new Empresa();
            empresal.SetEmpresa(textBox_empresa.Text);
            empresal.SetRazaoSocial(textBox_razao.Text);
            empresal.SetData(empresa.GetData());
            empresal.SetCnpj(textBox_cnpj.Text);
            empresal.SetAtivo(comboBox_ativo.Text);
            dgv_empresa.DataSource = empresaC.Pesquisar(empresal);
            empresa.SetData(null);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_bloco.Text = "";
            comboBox_ativo.Text = "";
            textBox_sala.Text = "";
            textBox_empresa.Text = "";
            textBox_razao.Text = "";
            textBox_cnpj.Text = "";

            comboBox_andar.Text = "";
            maskedTextBox_data.Text = "";
            button_excluir.Enabled = false;
            button_atualizar.Enabled = false;
            button_gravar.Enabled = true;
            ListarEmpresa();
            //    ListarLocal();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            EmpresaController empresaC = new EmpresaController();

            int flag;

            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = empresaC.ExcluirEmpresa(empresa.GetEmpresa_id());
                if (flag == 1)
                {
                    MessageBox.Show("Empresa excluída com sucesso!");
                    textBox_bloco.Text = "";
                    comboBox_ativo.Text = "";
                    textBox_sala.Text = "";

                    textBox_empresa.Text = "";
                    textBox_razao.Text = "";
                    comboBox_andar.Text = "";
                    maskedTextBox_data.Text = "";
                    textBox_cnpj.Text = "";

                    button_excluir.Enabled = false;
                    button_atualizar.Enabled = false;
                    button_gravar.Enabled = true;
                    ListarEmpresa();


                }
                else
                {
                    MessageBox.Show("Empresa não excluída!");
                }
            }

        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_empresa.Text) || string.IsNullOrWhiteSpace(textBox_cnpj.Text) || !maskedTextBox_data.MaskCompleted || local.GetLocal_id() == 0)
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {



                empresa.SetEmpresa(textBox_empresa.Text);
                empresa.SetRazaoSocial(textBox_razao.Text);
                empresa.SetCnpj(textBox_cnpj.Text);
                empresa.SetData(maskedTextBox_data.Text);
                empresa.SetLocalId(local.GetLocal_id());
                empresa.SetAtivo(comboBox_ativo.Text); 
                EmpresaController cartaC = new EmpresaController();
                        int flag = cartaC.AtualizarEmpresa(empresa);
                        if (flag == 1)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu algum erro na atualização do registro.");
                        }

                textBox_bloco.Text = "";
                comboBox_ativo.Text = "";
                textBox_sala.Text = "";

                textBox_empresa.Text = "";
                textBox_razao.Text = "";
                comboBox_andar.Text = "";
                maskedTextBox_data.Text = "";
                textBox_cnpj.Text = "";
                button_excluir.Enabled = false;
                        button_atualizar.Enabled = false;
                        button_gravar.Enabled = true;
                        ListarEmpresa();
                    }
                }
        
        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewIndex index = new ViewIndex();
            index.Show();
        }
    }
}
