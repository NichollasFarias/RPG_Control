using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Control
{
    public partial class Form2 : Form
    {
        #region Iniciador
        public Form2()
        {
            InitializeComponent();
        }

        int ValorDePessoas;
        int cont = 1;

        public Form2(int Quantidade)
        {
            InitializeComponent();
            ValorDePessoas = Quantidade;
            PainelPersonagens();
        }
        #endregion

        #region Paineis
        public void PainelPersonagens()
        {
            if(ValorDePessoas == 1)
            {
                PN_Personagens.Size = new Size(395,185);
                
                PN_P2.Visible = false;
                PN_P3.Visible = false;
                PN_P4.Visible = false;
                PN_P5.Visible = false;
                PN_P6.Visible = false;

            }
            if (ValorDePessoas == 2)
            {
                PN_Personagens.Size = new Size(395,292);
                
                PN_P2.Visible = true;
                PN_P3.Visible = false;
                PN_P4.Visible = false;
                PN_P5.Visible = false;
                PN_P6.Visible = false;
            }
            if (ValorDePessoas == 3)
            {
                PN_Personagens.Size = new Size(395,398);
                
                PN_P2.Visible = true;
                PN_P3.Visible = true;
                PN_P4.Visible = false;
                PN_P5.Visible = false;
                PN_P6.Visible = false;
            }
            if (ValorDePessoas == 4)
            {
                PN_Personagens.Size = new Size(395,508);
                
                PN_P2.Visible = true;
                PN_P3.Visible = true;
                PN_P4.Visible = true;
                PN_P5.Visible = false;
                PN_P6.Visible = false;
            }
            if (ValorDePessoas == 5)
            {
                PN_Personagens.Size = new Size(395,618);
                
                PN_P2.Visible = true;
                PN_P3.Visible = true;
                PN_P4.Visible = true;
                PN_P5.Visible = true;
                PN_P6.Visible = false;
            }
            if (ValorDePessoas == 6)
            {
                PN_Personagens.Size = new Size(395,722);
                
                PN_P2.Visible = true;
                PN_P3.Visible = true;
                PN_P4.Visible = true;
                PN_P5.Visible = true;
                PN_P6.Visible = true;
            }
        }
        private void BT_Enviar_Click(object sender, EventArgs e)
        {

            if (cont >= ValorDePessoas)
            {
                PN_Names.Visible = false;
            }

            if (cont == 1)
                {
                    P1.Text = txt_NamePerso.Text;
                    Name01 = P1.Text;
                }
                if (cont == 2)
                {
                    P2.Text = txt_NamePerso.Text;
                Name02 = P2.Text;
                }
                if (cont == 3)
                {
                    P3.Text = txt_NamePerso.Text;
                Name03 = P3.Text;
                }
                if (cont == 4)
                {
                    P4.Text = txt_NamePerso.Text;
                Name04 = P4.Text;
                }
                if (cont == 5)
                {
                    P5.Text = txt_NamePerso.Text;
                Name05 = P5.Text;
                }
                if (cont == 6)
                {
                    P6.Text = txt_NamePerso.Text;
                Name06 = P6.Text;
                }


                txt_NamePerso.Clear();
                txt_NamePerso.Focus();
                cont++;
        }
        #endregion

        #region Dado
        private void BT_JogaDado_Click(object sender, EventArgs e)
        {
            Random Dado = new Random();
            int Vezes = 0, TipoDado = 0, Soma = 0, ValordoDado, i = 0;

            #region Verificação do Tipo do Dado
            if (RD_D4.Checked)
            {
                TipoDado = 5;
            }
            if (RD_D6.Checked)
            {
                TipoDado = 7;
            }
            if (RD_D8.Checked)
            {
                TipoDado = 9;
            }
            if (RD_D10.Checked)
            {
                TipoDado = 11;
            }
            if (RD_D12.Checked)
            {
                TipoDado = 13;
            }
            if (RD_D20.Checked)
            {
                TipoDado = 21;
            }
            #endregion

            #region Verificação de Quantas Vezes rodar
            if (RD_1x.Checked)
            {
                Vezes = 1;
            }
            if (RD_2x.Checked)
            {
                Vezes = 2;
            }
            if (RD_3x.Checked)
            {
                Vezes = 3;
            }
            if (RD_4x.Checked)
            {
                Vezes = 4;
            }
            if (RD_5x.Checked)
            {
                Vezes = 5;
            }
            if (RD_6x.Checked)
            {
                Vezes = 6;
            }
            #endregion

            do
            {

                ValordoDado = Dado.Next(1, TipoDado);

                Soma += ValordoDado;

                i++;
            } while (i <= Vezes);

            LB_ValorDado.Text = Soma.ToString();

        }

        #endregion

        #region Botão de Troca de Turno
        string Name01, Name02, Name03, Name04, Name05, Name06;
        int ValorTurno = 0;
        private void button15_Click(object sender, EventArgs e)
        {

            if (ValorTurno == 1)
            {
                LB_NomeJogadorTurno.Text = Name01;
            }
            if (ValorTurno == 2)
            {
                LB_NomeJogadorTurno.Text = Name02;
            }
            if (ValorTurno == 3)
            {
                LB_NomeJogadorTurno.Text = Name03;
            }
            if (ValorTurno == 4)
            {
                LB_NomeJogadorTurno.Text = Name04;
            }
            if (ValorTurno == 5)
            {
                LB_NomeJogadorTurno.Text = Name05;
            }
            if (ValorTurno == 6)
            {
                LB_NomeJogadorTurno.Text = Name06;
            }
            if (ValorTurno == ValorDePessoas)
            {
                ValorTurno = 0;
            }
            ValorTurno++;
        }
        #endregion

        #region Monstros
        public void Monstros()
        {


        }
        #endregion
    }
}
