using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDado
{
    public partial class frmJogoDoDado : Form
    {
        private int jogador1;
        private int jogador2;

        public frmJogoDoDado() 
        {
            InitializeComponent();
        }
        private void btnJogador1_Click(object sender, EventArgs e)
        {
            String jogada = btnJogador01.Tag.ToString(); //bnt do jogador 1, gerar numero do dado aleatório
            Random rnd = new Random();
            int valorDado = rnd.Next(1, 7);
            selecionarODado(valorDado);
            switch (jogada)
            {
                case "1": 
                    txtJogada1Jogador1.Text = valorDado.ToString();
                    btnJogador01.Tag = "2";
                    btnJogador01.Enabled = false;
                    btnJogador2.Enabled = true;

                    break;

                case "2": 
                    txtJogada2Jogador1.Text = valorDado.ToString();
                    btnJogador01.Tag = "3";
                    btnJogador01.Enabled = false;
                    btnJogador2.Enabled = true;

                    break;

                case "3": 
                    txtJogada3Jogador1.Text = valorDado.ToString();
                    btnJogador01.Enabled = false;
                    btnJogador2.Enabled = true;
                    break;
            }      
        }
        private void btnJogador2_Click(object sender, EventArgs e)
        {
            String jogada = btnJogador2.Tag.ToString(); //botao do jogador 2, gerar numero do dado aleatório
            Random rnd = new Random();
            int valorDado = rnd.Next(1, 7);
            selecionarODado(valorDado);
            switch (jogada)
            {
                case "1":
                    txtJogada1Jogador2.Text = valorDado.ToString();
                    btnJogador2.Tag = "2";
                    btnJogador2.Enabled = false;
                    btnJogador01.Enabled = true;

                    break;

                case "2":
                    txtJogada2Jogador2.Text = valorDado.ToString();
                    btnJogador2.Tag = "3";
                    btnJogador2.Enabled = false;
                    btnJogador01.Enabled = true;
                    verificaQuemGanhou(jogada);

                    break;

                case "3":
                    txtJogada3Jogador2.Text = valorDado.ToString();
                    btnJogador2.Enabled = false;
                    verificaQuemGanhou(jogada);

                    break;
            }
        }
        private void verificaQuemGanhou(string jogada)
        {
            switch (jogada) //jogada 1
                //se o valor do jogador 1 for maior que do jogador 2 entao jogador 1 +=1 senao se for menor jogador 2 +=1;
                            
            {
                case "2":
                    if (Int32.Parse(txtJogada1Jogador1.Text) > Int32.Parse(txtJogada1Jogador2.Text))
                    {
                        jogador1 += 1;
                    }
                    else if (Int32.Parse(txtJogada1Jogador1.Text) < Int32.Parse(txtJogada1Jogador2.Text))
                    {
                        jogador2 += 1;
                    }
                    //jogada 2
                    if (Int32.Parse(txtJogada2Jogador1.Text) > Int32.Parse(txtJogada2Jogador2.Text)) 
                    {
                        jogador1 += 1;
                    }
                    else if (Int32.Parse(txtJogada2Jogador1.Text) < Int32.Parse(txtJogada2Jogador2.Text))
                    {
                        jogador2 += 1;
                    }
                    if (jogador1 > jogador2 && jogador1 > 1) //se um jogador vencer as duas primeira- vencedor.
                    {
                        MessageBox.Show("JOGADOR 1 É O VENCEDOR!");
                        Application.Exit();
                    }
                    else if (jogador2 > jogador1 && jogador2 > 1) //senao jogador 2 obtiver numero maior que jogador 1 e jogador 2 maior que 1- venceu.
                    {
                        MessageBox.Show("JOGADOR 2 É O VENCEDOR!");
                        Application.Exit();
                    }
                    break;

                case "3": //se um jogador ganhar a primeira partida e outro ganhar a segunda partida então ir para a ultima partida.
                    if (Int32.Parse(txtJogada3Jogador1.Text) > Int32.Parse(txtJogada3Jogador2.Text))
                    {
                            jogador1 += 1;
                    }
                    else if (Int32.Parse(txtJogada3Jogador1.Text) < Int32.Parse(txtJogada3Jogador2.Text))
                    {
                             jogador2 += 1;
                    }
                    if (jogador1 > jogador2)
                    {
                            MessageBox.Show("PARABENS JOGADOR 1 VENCEDOR!");
                            Application.Exit();
                    }
                    else if (jogador2 > jogador1)
                    {
                            MessageBox.Show("PARABENS JOGADOR 2 VENCEDOR!");
                            Application.Exit();
                    }
                    else if (jogador2 == jogador1) //se na jogada 1 2 e 3 os valores forem os mesmos, então mostrar empate.
                    {
                            MessageBox.Show("Jogador 1 e Jogador 2 EMPATE!");
                            Application.Exit();
                    }
                    break;
            }
        }
        private void selecionarODado(int valorDado)
        {
            switch (valorDado) //aqui deve ser mostrado cada img com o valor do dado gerado em cada jogada
            {
                case 1: imgDado.Image = JogoDado.Properties.Resources._1;
                    break;
                case 2: imgDado.Image = JogoDado.Properties.Resources._2;
                    break;
                case 3: imgDado.Image = JogoDado.Properties.Resources._3;
                    break;
                case 4: imgDado.Image = JogoDado.Properties.Resources._4;
                    break;
                case 5: imgDado.Image = JogoDado.Properties.Resources._5;
                    break;
                case 6: imgDado.Image = JogoDado.Properties.Resources._6;
                    break;
            }
        }
        private void frmJogoDado_Load(object sender, EventArgs e)
        {

        }
        private void txtbLance1Jogador1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblJogada1_Click(object sender, EventArgs e)
        {

        }

        private void imgDado_Click(object sender, EventArgs e)
        {

        }
    }
}
