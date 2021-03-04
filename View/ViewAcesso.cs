using ControllAcess.Controller;
using ControllAcess.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllAcess.View
{
    public partial class ViewAcesso : Form
    {
        public ViewAcesso()
        {
            InitializeComponent();
            ListarLocal();
            ListarCartao();
            local.SetLocal_id(0);
            cartao.SetCartao_id(0);
            fotostring ="";
            primeiroCadastro = 0;
            ListarAcesso();
        }

        Local local = new Local();
        Cartao cartao = new Cartao();
        Pessoa pessoa = new Pessoa();
        int primeiroCadastro;
        string fotostring;
       
        private void ListarLocal()
        {
            LocalController localC = new LocalController();

                dgv_local.DataSource = localC.ListarLocal();
                dgv_local.Columns[0].Visible = false;
                dgv_local.Columns[4].Visible = false;
                dgv_local.Columns[6].Visible = false;
        }

        private void ListarAcesso()
        {
            AcessoController acessoC = new AcessoController();

            dgv_acesso.DataSource = acessoC.ListarAcessoHoje();
            dgv_acesso.Columns[0].Visible = false;
            dgv_acesso.Columns[4].Visible = false;
        }

        private void SelecionarLinhaLocal(object sender, EventArgs e)
        {
            if (dgv_local.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_local.Rows[dgv_local.SelectedRows[0].Index].DataBoundItem;

                if (MessageBox.Show("Local escolhido 'BLOCO/MÓDULO' " + dr["Bloco"].ToString() + " 'ANDAR " + dr["Andar"].ToString() + " 'SALA/APT' " + dr["Sala"].ToString() + "  Confirma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            dgv_local.Columns[0].Visible = false;
            dgv_local.Columns[4].Visible = false;
            dgv_local.Columns[6].Visible = false;
        }

        private void ListarCartao()
        {
            CartaoController cartaoC = new CartaoController();
            dgv_cartao.DataSource = cartaoC.ListarCartaoDisponivel();
            dgv_cartao.Columns[0].Visible = false;
        }

        private void SelecionarLinhaCartao(object sender, EventArgs e)
        {
            if (dgv_cartao.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_cartao.Rows[dgv_cartao.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show("Cartão escolhido: N°  " + dr["Número"].ToString() +"  Confirma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cartao.SetCartao_id(Convert.ToInt32(dr["codigo"]));
                    cartao.SetDisponivel(dr["Disponível"].ToString());
                    textBox_numero.Text = dr["Número"].ToString();
                    comboBox_tipo.Text = dr["Tipo"].ToString();
                }
            }
        }

        private void button_pesquisarCartao_Click(object sender, EventArgs e)
        {
            CartaoController cartaoC = new CartaoController();
            Cartao cartaol = new Cartao();
            cartaol.SetNumero(textBox_numero.Text);
            cartaol.SetTipo(comboBox_tipo.Text);
            dgv_cartao.DataSource = cartaoC.PesquisarDisponivel(cartaol);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SelecionarLinhaPessoa(object sender, EventArgs e)
        {
            if (dgv_pessoa.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgv_pessoa.Rows[dgv_pessoa.SelectedRows[0].Index].DataBoundItem;

                    pessoa.SetPessoa_id(Convert.ToInt32(dr["codigo"]));
                    textBox_nome.Text = dr["Nome"].ToString();
                    maskedTextBox_cpf.Text = dr["CPF"].ToString();
                    textBox_obs.Text = dr["obs"].ToString();
                    button_cadastrar.Text = "Finalizar";
                    primeiroCadastro = 1;
                textBox_nome.Enabled = false;
                maskedTextBox_cpf.Enabled = false;
                button_captura.Enabled = false;
                button_descarta.Visible = false;
                label13.Visible = false;
                pictureBox_x.Visible = false;
                pictureBox_check.Visible = true;
     
                pictureBox1.Image = null;
           

            }
        }




        //Imagens, camera, conversoes

        private void AbrirCam_Click(object sender, EventArgs e)
        {
            ViewCam cam = new ViewCam();

            cam.ShowDialog();

            if (cam.Valor == "1")
            {
                //Não faz nada
            }
            else
            {


                var s = System.Text.Encoding.Default.GetBytes(cam.Valor);
                pictureBox1.Image = ByteArrayToImage(s);
                /*
                PictureBox pb = new PictureBox();
                Image imagemEscalonada = ByteArrayToImage(s);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 52;
                pb.Width = 70;
                pb.Image = imagemEscalonada;
                flowLayoutPanel2.Controls.Add(pb);
                */

                fotostring = cam.Valor;

                //imagemPessoa = s;            
                pictureBox_x.Visible = false;
                pictureBox_check.Visible = true;
                button_descarta.Visible = true;
                button_captura.Enabled = false;
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private Image EscalaPercentual(Image imgFoto)
        {
            float nPorcentagem = ((float)208 / 100);

            int fonteLargura = imgFoto.Width;     //armazena a largura original da imagem origem
            int fonteAltura = imgFoto.Height;   //armazena a altura original da imagem origem
            int origemX = 0;        //eixo x da imagem origem
            int origemY = 0;        //eixo y da imagem origem

            int destX = 0;          //eixo x da imagem destino
            int destY = 0;          //eixo y da imagem destino
            //Calcula a altura e largura da imagem redimensionada
            int destWidth = (int)(fonteLargura * nPorcentagem);
            int destHeight = (int)(fonteAltura * nPorcentagem);

            //Cria um novo objeto bitmap
            Bitmap bmImagem = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);
            //Define a resolu~ção do bitmap.
            bmImagem.SetResolution(imgFoto.HorizontalResolution, imgFoto.VerticalResolution);
            //Crima um objeto graphics e defina a qualidade
            Graphics grImagem = Graphics.FromImage(bmImagem);
            grImagem.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //Desenha a imge usando o método DrawImage() da classe grafica
            grImagem.DrawImage(imgFoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(origemX, origemY, fonteLargura, fonteAltura),
                GraphicsUnit.Pixel);

            grImagem.Dispose();  //libera o objeto grafico
            return bmImagem;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DescartarFoto_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja deseja descartar a imagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pictureBox1.Image = null;
                pictureBox_check.Visible = false;
                pictureBox_x.Visible = true;
                button_descarta.Visible = false;
                button_captura.Enabled = true;
                fotostring ="";
            }
        }


        private void Voltar(object sender, FormClosingEventArgs e)
        {
            ViewIndex index = new ViewIndex();
            index.Show();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            UtilController utilC = new UtilController();
            //verificar cpf existente
            DataTable dado;
            string str = maskedTextBox_cpf.Text.Replace(",", ".");
            dado = utilC.PesquisarPessoaTipoPorCPF(str);
            string tipo;

            if (dado.Rows.Count==0) {
                tipo = "VISITANTE";
            }
            else
            {
                tipo = dado.Rows[0]["Tipo"].ToString();
            }

            if (dado.Rows.Count >= 1 && primeiroCadastro==0)
            {
                MessageBox.Show("CPF já cadastrado anteriormente!");
                return;
            }
            // ValidaCPF();

            int retorno;

            pessoa.SetObs(textBox_obs.Text);

            if (!string.IsNullOrWhiteSpace(textBox_nome.Text) && maskedTextBox_cpf.MaskCompleted && local.GetLocal_id() != 0 && cartao.GetCartao_id() != 0 && fotostring != "")
            {
                PessoaController pessoaC = new PessoaController();
                if (primeiroCadastro == 0)
                {
                    pessoa.SetNome(textBox_nome.Text);
                    pessoa.SetCpf(str);
                    pessoa.SetImagem(fotostring);
                    pessoa.SetObs(textBox_obs.Text);
                    pessoa.SetObs(textBox_obs.Text);
                    retorno = pessoaC.IncluirPessoa(pessoa);
                    if (retorno == 1)
                    {
                        pessoa.SetPessoa_id(utilC.retornaUltimoID());
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu algum erro!");
                        return;
                    }
                }                                
                    int eventoId = 0;
                    if (tipo=="VISITANTE" || primeiroCadastro==0) {
                        eventoId  = utilC.retornaEventoID(local.GetLocal_id());
                    }
                    CartaoController cartaoC = new CartaoController();
                    cartao.SetDisponivel("NÃO DISPONÍVEL");
                    cartaoC.AtualizarCartao(cartao);
                    ListarCartao();
                    Acesso acesso = new Acesso();
                    AcessoController acessoC = new AcessoController();
                    acesso.SetEventoId(eventoId);
                    acesso.SetCartaoId(cartao.GetCartao_id());
                    acesso.SetPessoa_id(pessoa.GetPessoa_id());
                    acesso.SetLocalId(local.GetLocal_id());
                    acesso.SetData(DateTime.Now.ToString());
                    string hora = DateTime.Now.ToString();
                    acesso.SetEntrada(hora);
                    int flag;
                    flag = acessoC.IncluirAcesso(acesso);
                    if (flag == 1)
                    {
                        MessageBox.Show("Entrada cadastrada na base de dados!");
                        pictureBox1.Image = null;
                        pictureBox_check.Visible = false;
                        pictureBox_x.Visible = true;
                        button_descarta.Visible = false;
                        button_captura.Enabled = true;
                        fotostring = "";
                        textBox_nome.Text = "";
                        maskedTextBox_cpf.Text = "";
                        textBox_numero.Text = "";
                        textBox_bloco.Text = "";
                        textBox_numero.Text = "";
                        textBox_obs.Text = "";
                        textBox_sala.Text = "";
                        comboBox_andar.Text = "";
                        comboBox_tipo.Text = "";
                        primeiroCadastro = 0;
                        textBox_nome.Enabled = true;
                        maskedTextBox_cpf.Enabled = true;
                        label13.Visible = true;
                        ListarAcesso();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao tentar cadastrar na base de acesso!");
                        primeiroCadastro = 0;
                    }        
            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
            }
        }


        private void ValidaCPF(object sender, EventArgs e)
        {

        }

        private void button_pesquisa_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = null;

            if (!maskedTextBox_cpf.MaskCompleted) { MessageBox.Show("Preencha o campo de CPF!"); return; }


            UtilController utilC = new UtilController();
            DataTable dado;
            string str = maskedTextBox_cpf.Text.Replace(",", ".");
            dado = utilC.PesquisarPessoaTipoPorCPF(str);

            if (dado.Rows.Count == 0)
            {
                label_tipo_pessoa.Text = "NÃO CADASTRADO";
                return;
            }

            dgv_pessoa.DataSource = dado;
            DataRowView dr = (DataRowView)dgv_pessoa.Rows[dgv_pessoa.Rows[0].Index].DataBoundItem;
            dgv_pessoa.Columns[0].Visible = false;
            dgv_pessoa.Columns[3].Visible = false;
            dgv_pessoa.Columns[4].Visible = false;
            //dado.Rows[0]["Tipo"];
            label_tipo_pessoa.Text = dr["Tipo"].ToString();
            fotostring= dr["Foto"].ToString();
            
            var s = System.Text.Encoding.Default.GetBytes(fotostring);
            Image imagemEscalonada = EscalaPercentual(ByteArrayToImage(s));

            pictureBox2.Image=imagemEscalonada;


        }



        byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_nome.Enabled = true;
            textBox_nome.Text = "";
            maskedTextBox_cpf.Enabled = true;
            maskedTextBox_cpf.Text = "";
            pessoa = null;
            button_captura.Enabled = true;
            local = null;
            cartao = null;
            pictureBox1.Image = null;
            label13.Visible = true;
            pictureBox_check.Visible = false;
            pictureBox_x.Visible = true;
            ListarCartao();
            ListarLocal();
        }
    }
}
