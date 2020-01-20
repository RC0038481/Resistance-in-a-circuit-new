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
            double Resistance1; //This turns the value of Resistance1 into a number that this program can read.
            try
            {
                Resistance1 = double.Parse(ResistanceA.Text); 
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance1 = 0.0;
                //If R1 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R1 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double Resistance2; //This turns the value of Resistance2 into a number that this program can read.
            try
            {
                Resistance2 = double.Parse(ResistanceB.Text);
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance2 = 0.0;
                //If R2 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R2 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double ResistanceTotal1 = Resistance1 + Resistance2;
            //This adds up the two values to make a different value.

            ResistanceTotalA.Text = ResistanceTotal1.ToString("0");
            //Finally this line allows the program to convert the integer back into string and displays the value in the textbox.
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Resistance3; //This turns the value of Resistance3 into a number that this program can read.
            try
            {
                Resistance3 = double.Parse(ResistanceC.Text);
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance3 = 0.0;
                //If R1 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R1 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double Resistance4; //This turns the value of Resistance4 into a number that this program can read.
            try
            {
                Resistance4 = double.Parse(ResistanceD.Text);
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance4 = 0.0;
                //If R2 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R2 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double ResistanceTotal2 = 1.0 / (1.0 / Resistance3 + 1.0 / Resistance4);
            //This adds up the two values to make a different value.

            ResistanceTotalB.Text = ResistanceTotal2.ToString("0");
            //Finally this line allows the program to convert the integer back into string and displays the value in the textbox.
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double Resistance5; //This turns the value of Resistance5 into a number that this program can read.
            try
            {
                Resistance5 = double.Parse(ResistanceE.Text);
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R1 is not a valid value");
                Resistance5 = 0.0;
                //If R1 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R1 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double Resistance6; //This turns the value of Resistance6 into a number that this program can read.
            try
            {
                Resistance6 = double.Parse(ResistanceF.Text);
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R2 is not a valid value");
                Resistance6 = 0.0;
                //If R2 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R2 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double Resistance7; //This turns the value of Resistance7 into a number that this program can read.
            try
            {
                Resistance7 = double.Parse(ResistanceG.Text);
                //This converts the string representation of a number inside the textbox into its 32-bit signed integer equivalent.
            }
            catch
            {
                MessageBox.Show("R3 is not a valid value");
                Resistance7 = 0.0;
                //If R3 is an invalid value (e.g. A letter or punctuation symbol), it will give you a messagebox stating that R3 was incorrect. 
                //It will change the value back to 0.
            }
            //Try/Catch lets the program read whatever value you typed in and find if it is correct or not.

            double ResistanceTotal3 = Resistance5 + Resistance6 + Resistance7;
            //This adds up the two values to make a different value

            ResistanceTotalC.Text = ResistanceTotal3.ToString("0");
            //Finally this line allows the program to convert the integer back into string and displays the value in the textbox.
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
