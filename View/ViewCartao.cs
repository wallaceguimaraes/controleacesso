using ControllAcess.Controller;
using ControllAcess.Model.Entity;
using System;
using System.Collections;
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
    public partial class ViewCartao : Form
    {
        public ViewCartao()
        {
            InitializeComponent();
            ListarCartao();
        }

        Cartao cartao = new Cartao();

        private void ListarCartao()
        {
            CartaoController cartaoC = new CartaoController();
            dgv_cartao.DataSource = cartaoC.ListarCartao();
            dgv_cartao.Columns[0].Visible = false;
        }

        private void SelecionarLinha(object sender, EventArgs e)
        {
            if (dgv_cartao.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_cartao.Rows[dgv_cartao.SelectedRows[0].Index].DataBoundItem;
                cartao.SetCartao_id(Convert.ToInt32(dr["codigo"]));
                cartao.SetDisponivel(dr["Disponível"].ToString());
                textBox_numero.Text = dr["Número"].ToString();
                comboBox_tipo.Text = dr["Tipo"].ToString();
                maskedTextBox_ini.Text = dr["Início"].ToString();
                maskedTextBox_fim.Text = dr["Fim"].ToString();
                comboBox_ativo.Text = dr["Ativo"].ToString();
                button_excluir.Enabled = true;
                button_atualizar.Enabled = true;
                button_gravar.Enabled = false;
                textBox_numero.Enabled = false;
            }
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            CartaoController cartaoC = new CartaoController();
            Cartao cartaol = new Cartao();
            int flag;

            if(string.IsNullOrWhiteSpace(textBox_numero.Text)||string.IsNullOrWhiteSpace(comboBox_tipo.Text)||!maskedTextBox_ini.MaskCompleted||!maskedTextBox_fim.MaskCompleted)
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                cartaol.SetNumero(textBox_numero.Text);
                cartaol.SetTipo(comboBox_tipo.Text);
                cartaol.SetPeriodoInicio(maskedTextBox_ini.Text+":00");
                cartaol.SetPeriodoFim(maskedTextBox_fim.Text+":00");
                flag = cartaoC.IncluirCartao(cartaol);
                if (flag == 1)
                {
                    MessageBox.Show("Cartão salvo com sucesso!");
                    ListarCartao();
                }
                else if (flag == 3)
                {
                    MessageBox.Show("Número de cartão já cadastrado anteriormente.");
                }
                else
                {
                    MessageBox.Show("Erro ao tentar cadastrar o novo cartão.");
                }
            }   
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            CartaoController cartaoC = new CartaoController();
            Cartao cartaol = new Cartao();
            cartaol.SetNumero(textBox_numero.Text);
            cartaol.SetAtivo(comboBox_ativo.Text);
            dgv_cartao.DataSource = cartaoC.Pesquisar(cartaol);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_numero.Text = "";
            maskedTextBox_ini.Text = "";
            maskedTextBox_fim.Text = "";
            comboBox_tipo.Text = "";
            comboBox_ativo.Text = "";
            button_excluir.Enabled = false;
            button_atualizar.Enabled = false;
            button_gravar.Enabled = true;
            textBox_numero.Enabled = true;

            ListarCartao();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            CartaoController cartaoC = new CartaoController();
            int flag;

            if (cartao.GetDisponivel().Equals("NÃO"))
            {
                MessageBox.Show("O cartão não pode ser excluído, pois ainda está sendo utilizado.");
            }
            else
            {

                if (MessageBox.Show("Tem certeza que deseja excluir o registro", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flag = cartaoC.ExcluirCartao(cartao.GetCartao_id());
                    if (flag == 1)
                    {
                        MessageBox.Show("Cartão excluído com sucesso!");
                        textBox_numero.Text = "";
                        maskedTextBox_ini.Text = "";
                        maskedTextBox_fim.Text = "";
                        comboBox_tipo.Text = "";
                        comboBox_ativo.Text = "";
                        button_excluir.Enabled = false;
                        button_atualizar.Enabled = false;
                        button_gravar.Enabled = true;
                        textBox_numero.Enabled = true;
                        ListarCartao();
                    }
                    else
                    {
                        MessageBox.Show("Cartão não excluído!");
                    }
                }
            }          
        }

        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewIndex index = new ViewIndex();
            index.Show();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox_numero.Text) || string.IsNullOrWhiteSpace(comboBox_tipo.Text) || !maskedTextBox_ini.MaskCompleted || !maskedTextBox_fim.MaskCompleted)
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
            else
            {
                cartao.SetNumero(textBox_numero.Text);
                cartao.SetTipo(comboBox_tipo.Text);
                cartao.SetPeriodoInicio(maskedTextBox_ini.Text+":00");
                cartao.SetPeriodoFim(maskedTextBox_fim.Text+":00");
                cartao.SetAtivo(comboBox_ativo.Text);
                CartaoController cartaC = new CartaoController();
                int flag = cartaC.AtualizarCartao(cartao);

                if (flag == 1)
                {
                    MessageBox.Show("Registro atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu algum erro na atualização do registro.");
                }
                textBox_numero.Text = "";
                maskedTextBox_ini.Text = "";
                maskedTextBox_fim.Text = "";
                comboBox_tipo.Text = "";
                comboBox_ativo.Text = "";
                button_excluir.Enabled = false;
                button_atualizar.Enabled = false;
                button_gravar.Enabled = true;
                textBox_numero.Enabled = true;
                ListarCartao();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ValidaTamanhoSenha();
            string caracteresPermitidos = "0123456789";
            int TamanhoDaSenha = 10;
            char[] chars = new char[TamanhoDaSenha];
            Random rd = new Random();
            for (int i = 0; i < TamanhoDaSenha; i++)
            {
                chars[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
            }
            textBox_numero.Text = new string(chars);
        }
    }
}
