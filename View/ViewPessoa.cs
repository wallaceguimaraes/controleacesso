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
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllAcess.View
{
    public partial class ViewPessoa : Form
    {
        public ViewPessoa()
        {
            InitializeComponent();


            /*
             * Abre o formulario de selecao de arquivos
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { }
            */

            fotostring = "";
            ListarPessoas();

        }
        Pessoa pessoa = new Pessoa();
        string fotostring;
        Image Imagem;

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Selecionar Fotos";
            openFileDialog1.InitialDirectory = @"C:\Users\macoratti\Pictures";
            //filtra para exibir somente arquivos de imagens
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    textBox1.Text += arquivo;
                    // cria um PictureBox
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 114;
                        pb.Width = 146;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem: " + ex.Message);
                    }
                }
            }
    }

        private void Voltar(object sender, FormClosingEventArgs e)
        {

            ViewIndex ind = new ViewIndex();
            ind.Show();
            this.Hide();

        }




        public byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }


        private Image EscalaPercentual(Image imgFoto)
        {
            float nPorcentagem = ((float)20 / 100);

            int fonteLargura = imgFoto.Width;     //armazena a largura original da imagem origem
            int fonteAltura = imgFoto.Height;   //armazena a altura original da imagem origem
            int origemX = 0;        //eixo x da imagem origem
            int origemY = 0;        //eixo y da imagem origem

            int destX = 0;          //eixo x da imagem destino
            int destY = 0;          //eixo y da imagem destino
            //Calcula a altura e largura da imagem redimensionada
            int destWidth = 146;
            int destHeight = 114;

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



        public void ListarPessoas()
        {
            PessoaController pessoaC = new PessoaController();
            dgv_pessoa.DataSource= pessoaC.ListarPessoa();
            dgv_pessoa.Columns[0].Visible = false;
            dgv_pessoa.Columns[3].Visible = false;
            dgv_pessoa.Columns[4].Visible = false;
            dgv_pessoa.Columns[5].Visible = false;
            dgv_pessoa.Columns[6].Visible = false;


        }



        private void button_gravar_Click(object sender, EventArgs e)
        {


            UtilController utilC = new UtilController();
            //verificar cpf existente
            DataTable dado;
            string str = maskedTextBox_cpf.Text.Replace(",", ".");
            dado = utilC.PesquisarPessoaTipoPorCPF(str);
            if (dado.Rows.Count >= 1)
            {
                MessageBox.Show("CPF já cadastrado anteriormente!");
                return;
            }
            //Valida CPF

            if (Imagem != null)
            {
               Image Ima=EscalaPercentual(Imagem);

                var s = ImageToByteArray(Ima);
                fotostring = System.Text.Encoding.Default.GetString(s);


            }

            if (string.IsNullOrWhiteSpace(textBox_nome.Text) || !maskedTextBox_cpf.MaskCompleted || string.IsNullOrWhiteSpace(textBox_contato.Text) || fotostring=="")
            {
                MessageBox.Show("Existem campos obrigatórios que não foram preenchidos!");
                return;
            }

            if (maskedTextBox_nasc.MaskCompleted) { pessoa.SetDtNascimento(maskedTextBox_nasc.Text); }

            PessoaController pessoaC = new PessoaController();
            int retorno;

            pessoa.SetNome(textBox_nome.Text);
            pessoa.SetCpf(str);
            pessoa.SetEmail(textBox_email.Text);
            //converter imagem para byte array e depois para srting
            pessoa.SetImagem(fotostring);
            pessoa.SetContato(textBox_contato.Text);
            pessoa.SetObs(textBox_obs.Text);
            pessoa.SetRg(textBox_rg.Text);

            retorno=pessoaC.IncluirPessoa(pessoa);
            if (retorno == 1)
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                ListarPessoas();
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro!");
            }

        }
    }
}
