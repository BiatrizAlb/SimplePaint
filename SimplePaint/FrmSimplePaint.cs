using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FrmSimplePaint : Form
    {


        private bool flagPintar = false;
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false;
        private Image imageASalvar;
        private Graphics graphicsImagemASalvar;

        public FrmSimplePaint()
        {
            InitializeComponent();


            //propriedade FlatStyle precisa está setada em flat
            //altera a cor do butao quando o cursor está sobre ele
            btnBorracha.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;

            for (int i = 2; i<=100; i += 2)
            {
                cmbEspessuraCaneta.Items.Add(i);
            }
            cmbEspessuraCaneta.Text = "10"; //Texto que irá aparecer na ComboBox Inicialmente
            cmbEspessuraCaneta.MaxDropDownItems = 5;//Define o número de itens a serem exibidos na combobox
            cmbEspessuraCaneta.IntegralHeight = false; //Necessario para que seja possivel definir a quantidade de itens na cmb

            //permite o desenho sobre o controle
            graphicsPainelPintura = pnlPintura.CreateGraphics();
            espessuraCaneta = float.Parse(cmbEspessuraCaneta.Text);
            corBorracha = pnlPintura.BackColor;

            //imagem para salvar
            imageASalvar = new Bitmap(pnlPintura.Width, pnlPintura.Height);
            //extraindo graphics da imagem para salvar de forma a podermos desenhar nela
            graphicsImagemASalvar = Graphics.FromImage(imageASalvar);
            graphicsImagemASalvar.Clear(pnlPintura.BackColor);
        }

        //metodo privado sem retorno
        //handler do evento de clique do botão 
        //Disparado quando o botao é clicado
        //Serve para manipular o que acontece quando o clique ocorre

        private void btnCorCaneta_Click(object sender, EventArgs e)
        {
            //Criando caixa de dialogo para seleção de cores
            var colorDialog = new ColorDialog();
            //Exibe na forma modal
            //app fica travada enquando o dialogo n é respondido
            var corEscolhida = colorDialog.ShowDialog();
            if(corEscolhida == DialogResult.OK)
            {
                btnCorCaneta.BackColor = colorDialog.Color;
            }

            

        }

        //quando clicar
        private void pnlPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        //quando soltar
        private void pnlPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        //Enquanto estiver se movendo
        private void pnlPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if(flagPintar)
            {
                if (!flagApagar)
                {
                    graphicsPainelPintura.DrawEllipse(new Pen(btnCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));


                    //desenha na imagem
                    graphicsImagemASalvar.DrawEllipse(new Pen(btnCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));

                }
                else
                {
                    //casting - transformando variavel float em inteira
                    graphicsPainelPintura.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));

                    graphicsImagemASalvar.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza disso? Todo Desenho será apagado.", "Apagar Desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White);
                graphicsImagemASalvar.Clear(Color.White);
            }
        }

        private void cmbEspessuraCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ocorre quando ele seleciona um item na cmb (sempre que o indice muda)
            espessuraCaneta = float.Parse(cmbEspessuraCaneta.SelectedItem.ToString());
        }

        private void btnBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)//Se clicar com botão direito
            {
                var colorDialog = new ColorDialog();
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color;
                }
            }
            else
            {   
                // O operador ! antes irá virar o valor 
                //da flagApagar ao contrário
                //se é true ficará false
                if (!flagApagar)
                {
                    flagApagar = true;
                    btnBorracha.BackColor = corBorracha;
                }
                else 
                { 
                    flagApagar = false;
                    btnBorracha.BackColor = Color.Black;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";
            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {

                //Definindo a extensão da Imagem que iremo salvar
                switch (saveFileDialog.FilterIndex) {

                    case 1:
                        imageASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imageASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }

            }
        }
    }
}
