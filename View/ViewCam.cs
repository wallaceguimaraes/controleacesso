using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllAcess.View
{
    public partial class ViewCam : Form
    {


        public string Valor {
            get { return textBox1.Text; }
            set { textBox1.Text= value; }
        }
        

        byte[] foto;

       // private string path = @"C:\Users\Wallace Guimarães\source\repos\ControllAcess\ControllAcess\View";

        private bool dispositivos;

        private FilterInfoCollection meusDispositivos;

        private VideoCaptureDevice minhaCam;

        public ViewCam()
        {
            InitializeComponent();
        }

        private void ViewCam_Load(object sender, EventArgs e)
        {
            carregaDispositivos();

        }


        public void carregaDispositivos()
        {
            meusDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (meusDispositivos.Count > 0)
            {
                dispositivos = true;

                for (int i=0; i < meusDispositivos.Count;i++)
                {
                    comboBox1.Items.Add(meusDispositivos[i].Name.ToString());
                    comboBox1.Text = meusDispositivos[0].Name.ToString();

                }

            }
            else
            {
                dispositivos = false;
            }


        }

        private void button_gravar_Click(object sender, EventArgs e)
        {

         


        }


        private void FecharCam()
        {
            if (minhaCam != null && minhaCam.IsRunning)
            {
                minhaCam.SignalToStop();
                minhaCam = null;
                   
            }

        }



        private void SelecionaCam(object sender, EventArgs e)
        {

            FecharCam();
            int i = comboBox1.SelectedIndex;
            string nomeVideo = meusDispositivos[i].MonikerString;
            minhaCam = new VideoCaptureDevice(nomeVideo);
            minhaCam.NewFrame += new NewFrameEventHandler(Capturando);
            minhaCam.Start();
            button_gravar.Enabled = false;
            button_capturar.Enabled = true;
            button2.Enabled = true;

        }


        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagem = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_imagem1.Image = Imagem;

        }

        private void Fechar(object sender, FormClosedEventArgs e)
        {
            FecharCam();
          
        }

        private void Voltar(object sender, FormClosedEventArgs e)
        {
            FecharCam();
        }


        private string nomeRandon()
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
            string nome = new string(chars);
            return nome;
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

        private void button_capturar_Click(object sender, EventArgs e)
        {

            string nome=nomeRandon();

            if (minhaCam!=null && minhaCam.IsRunning)
            {
                pictureBox_imagem2.Image = pictureBox_imagem1.Image;
               // pictureBox_imagem2.Image.Save(path +DateTime.Now+""+nome+".jpg", ImageFormat.Jpeg);
               // foto = ImageToByteArray(pictureBox_imagem2.Image);


                Image imagemEscalonada=EscalaPercentual(pictureBox_imagem2.Image);

                //Image imagemEscalonada = pictureBox_imagem2.Image;

                foto = ImageToByteArray(imagemEscalonada);
                var str = System.Text.Encoding.Default.GetString(foto);
                textBox1.Text = str;

                pictureBox_imagem2.Visible = true;

                button1.Enabled = true;

            }
        }





        private Image EscalaPercentual(Image imgFoto)
        {
            float nPorcentagem = ((float)11 / 100);

            int fonteLargura = imgFoto.Width ;     //armazena a largura original da imagem origem
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





        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox_imagem2.Visible = false;
            button1.Enabled = false;
            button_capturar.Enabled = false;
            button2.Enabled = false;
            button_gravar.Enabled = true;
            FecharCam();
        }
    }
}
