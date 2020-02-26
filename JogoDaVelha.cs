using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class JogoDaVelha : Form
    {
        public string jogador_atual = "X";

        public JogoDaVelha()
        {
            InitializeComponent();
        }

        private void JogoDaVelha_Load(object sender, EventArgs e)
        {

        }
        public String InverterJogador()
        {
            if (jogador_atual == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public void Zerar()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            jogador_atual = "X";
        }
        public void Ganhar()
        {
            MessageBox.Show("O jogador " + jogador_atual + " Ganhou");
            Zerar();
        }
        public bool verificar(String jogador)
        {
            if (button1.Text == jogador && button6.Text == jogador && button9.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button2.Text == jogador && button5.Text == jogador && button8.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button3.Text == jogador && button4.Text == jogador && button7.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button1.Text == jogador && button2.Text == jogador && button3.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button4.Text == jogador && button5.Text == jogador && button6.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button7.Text == jogador && button8.Text == jogador && button9.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button1.Text == jogador && button5.Text == jogador && button7.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button3.Text == jogador && button5.Text == jogador && button9.Text == jogador)
            {
                Ganhar();
                return true;
            }
            if (button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button4.Text.Length != 0 &&
                button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0 &&
                button7.Text.Length != 0)
            {
                MessageBox.Show("Deu Velha :(");
                Zerar();
                return true;
            }

            jogador_atual = InverterJogador();
            label1.Text = "Jogador Atual = " + jogador_atual;
            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = jogador_atual;
                verificar(jogador_atual);
            }
        }
    }
}
