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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        int totaldeplayer;
        

        #region Quantidade de Players


        private void RB_P01_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_P01.Checked)
            {

                totaldeplayer = 1;

            }
        }

        private void RB_P02_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_P02.Checked)
            {
                totaldeplayer = 2;
            }
        }

        private void RB_P03_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_P03.Checked)
            {
                totaldeplayer = 3;
            }
        }

        private void RB_P04_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_P04.Checked)
            {
                totaldeplayer = 4;
            }
        }

        private void RB_P05_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_P05.Checked)
            {
                totaldeplayer = 5;
            }
        }

        private void RB_P06_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_P06.Checked)
            {
                totaldeplayer = 6;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Game = new Form2(totaldeplayer);
            Form3 Invetario = new Form3();
            Invetario.Show();
            Game.Show();
            
        }
    }
}
