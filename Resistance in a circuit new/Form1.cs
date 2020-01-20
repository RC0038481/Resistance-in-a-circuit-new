using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistance_in_a_circuit_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Resistance1;
            try
            {
                Resistance1 = double.Parse(ResistanceA.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance1 = 0.0;
                //
            }

            double Resistance2;
            try
            {
                Resistance2 = double.Parse(ResistanceB.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance2 = 0.0;
            }
            double ResistanceTotal1 = Resistance1 + Resistance2;
            ResistanceTotalA.Text = ResistanceTotal1.ToString("0");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Resistance3;
            try
            {
                Resistance3 = double.Parse(ResistanceC.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance3 = 0.0;
            }

            double Resistance4;
            try
            {
                Resistance4 = double.Parse(ResistanceD.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance4 = 0.0;
            }
            double ResistanceTotal2 = 1.0 / (1.0 / Resistance3 + 1.0 / Resistance4);
            ResistanceTotalB.Text = ResistanceTotal2.ToString("0");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double Resistance5;
            try
            {
                Resistance5 = double.Parse(ResistanceE.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance5 = 0.0;
            }
            double Resistance6;
            try
            {
                Resistance6 = double.Parse(ResistanceF.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance6 = 0.0;
            }
            double Resistance7;
            try
            {
                Resistance7 = double.Parse(ResistanceG.Text);
            }
            catch
            {
                MessageBox.Show("R3 is not a valid value");
                Resistance7 = 0.0;
            }
            double ResistanceTotal3 = Resistance5 + Resistance6 + Resistance7;
            ResistanceTotalC.Text = ResistanceTotal3.ToString("0");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double Resistance8;
            try
            {
                Resistance8 = double.Parse(ResistanceH.Text);
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance8 = 0.0;
            }

            double Resistance9;
            try
            {
                Resistance9 = double.Parse(ResistanceI.Text);
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance9 = 0.0;
            }

            double Resistance10;
            try
            {
                Resistance10 = double.Parse(ResistanceJ.Text);
            }
            catch
            {
                MessageBox.Show("R3 is not a valid value");
                Resistance10 = 0.0;
            }
            double ResistanceTotal3 = 1.0 / (1.0 / Resistance8 + 1.0 / Resistance9 + 1.0 / Resistance10);
            ResistanceTotalD.Text = ResistanceTotal3.ToString("0");
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label26_Click(object sender, EventArgs e)
        {

        }

        private void Label31_Click(object sender, EventArgs e)
        {

        }
    }
}
