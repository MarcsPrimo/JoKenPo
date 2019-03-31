using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPedraPapelTesoura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //COMANDO QUE DESATIVA O RESIZE MANUAL.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


        }
        //DECLARANDO VARIAVEIS GLOBAIS.
        Random rnd = new Random();
        int valor1 = 0;
        int valorCpu1 = 0;
        
        //MÉTODO QUE SETA AS REGRAS DO JOGO E DEFINE O FIM APÓS ACUMULADO 5 PONTOS.
        public void Teste()
        {

           
            if (valor1 == 1 && valorCpu1 == 1)
            {
                label1.Text = "**EMPATE**";
            }
            if (valor1 == 2 && valorCpu1 == 2)
            {
                label1.Text = "**EMPATE**";
            }
            if (valor1 == 3 && valorCpu1 == 3)
            {
                label1.Text = "**EMPATE**";
            }
            if (valor1 == 1 && valorCpu1 == 2)
            {
                label1.Text = "**GANHOU**";
                Saida1.Text = (int.Parse(Saida1.Text) + 1).ToString();
            }
            if (valor1 == 1 && valorCpu1 == 3)
            {
                label1.Text = "**PERDEU**";
                Saida2.Text = (int.Parse(Saida2.Text) + 1).ToString();
            }
            if (valor1 == 3 && valorCpu1 == 2)
            {
                label1.Text = "**PERDEU**";
                Saida2.Text = (int.Parse(Saida2.Text) + 1).ToString();
            }
            if (valor1 == 3 && valorCpu1 == 1)
            {
                label1.Text = "**GANHOU**";
                Saida1.Text = (int.Parse(Saida1.Text) + 1).ToString();
            }
            if (valor1 == 2 && valorCpu1 == 1)
            {
                label1.Text = "**PERDEU**";
                Saida2.Text = (int.Parse(Saida2.Text) + 1).ToString();
            }
            if (valor1 == 2 && valorCpu1 == 3)
            {
                label1.Text = "**GANHOU**";
                Saida1.Text = (int.Parse(Saida1.Text) + 1).ToString();
            }

            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;


            if (Saida1.Text == "5" | Saida2.Text == "5")
            {
                this.BackColor = Color.Green;
                Saida1.Text = "0";
                Saida2.Text = "0";

                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //GERA A JOGADA ALEÁTORIA DO ADVERSÁRIO.
            int x1 = rnd.Next(1, 4);

            pictureBox1.BackgroundImage = Image.FromFile("dado" + x1 + ".png");

            //GERA A JOGADO QUE O JOGADOR ESCOLHEU.
            pictureBox2.BackgroundImage = Image.FromFile("dado1.png");

            button2.Enabled = false;
           
            //SETA O VALOR DAS VARIAVEIS GLOBAIS.
            valor1 = 1;
            valorCpu1 = x1;

            //CHAMA O MÉTODO.
            Teste();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x2 = rnd.Next(1, 4);

            pictureBox1.BackgroundImage = Image.FromFile("dado" + x2 + ".png");

            pictureBox2.BackgroundImage = Image.FromFile("dado2.png");

            button3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            valor1 = 2;
            valorCpu1 = x2;

            Teste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x3 = rnd.Next(1, 4);

            pictureBox1.BackgroundImage = Image.FromFile("dado" + x3 + ".png");

            pictureBox2.BackgroundImage = Image.FromFile("dado3.png");
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;

            valor1 = 3;
            valorCpu1 = x3;

            Teste();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //REINICIA DO JOGO.
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            label1.Text = "ESPERANDO";

            this.BackColor = Color.SkyBlue;
        }
    }
}
