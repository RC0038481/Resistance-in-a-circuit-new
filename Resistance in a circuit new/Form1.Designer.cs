namespace Resistance_in_a_circuit_new
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ResistanceH = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ResistanceA = new System.Windows.Forms.TextBox();
            this.ResistanceC = new System.Windows.Forms.TextBox();
            this.ResistanceE = new System.Windows.Forms.TextBox();
            this.ResistanceB = new System.Windows.Forms.TextBox();
            this.ResistanceTotalA = new System.Windows.Forms.TextBox();
            this.ResistanceD = new System.Windows.Forms.TextBox();
            this.ResistanceTotalB = new System.Windows.Forms.TextBox();
            this.ResistanceG = new System.Windows.Forms.TextBox();
            this.ResistanceF = new System.Windows.Forms.TextBox();
            this.ResistanceTotalC = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ResistanceTotalA);
            this.tabPage1.Controls.Add(this.ResistanceB);
            this.tabPage1.Controls.Add(this.ResistanceA);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Series #1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResistanceTotalB);
            this.tabPage2.Controls.Add(this.ResistanceD);
            this.tabPage2.Controls.Add(this.ResistanceC);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parrallel #1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResistanceTotalC);
            this.tabPage3.Controls.Add(this.ResistanceF);
            this.tabPage3.Controls.Add(this.ResistanceG);
            this.tabPage3.Controls.Add(this.ResistanceE);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Series #2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.ResistanceH);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(780, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Parrallel #2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Resistance_in_a_circuit_new.Properties.Resources.resistor_res27__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Resistance_in_a_circuit_new.Properties.Resources.resistor_res27_111;
            this.pictureBox2.Location = new System.Drawing.Point(0, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(784, 359);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Resistance_in_a_circuit_new.Properties.Resources.resistor_res27__1_;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(784, 380);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Resistance_in_a_circuit_new.Properties.Resources.resistor_res27;
            this.pictureBox4.Location = new System.Drawing.Point(0, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(784, 365);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ResistanceH
            // 
            this.ResistanceH.Location = new System.Drawing.Point(317, 214);
            this.ResistanceH.Name = "ResistanceH";
            this.ResistanceH.Size = new System.Drawing.Size(100, 20);
            this.ResistanceH.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(507, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(674, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(674, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // ResistanceA
            // 
            this.ResistanceA.Location = new System.Drawing.Point(349, 125);
            this.ResistanceA.Name = "ResistanceA";
            this.ResistanceA.Size = new System.Drawing.Size(100, 20);
            this.ResistanceA.TabIndex = 2;
            // 
            // ResistanceC
            // 
            this.ResistanceC.Location = new System.Drawing.Point(410, 229);
            this.ResistanceC.Name = "ResistanceC";
            this.ResistanceC.Size = new System.Drawing.Size(100, 20);
            this.ResistanceC.TabIndex = 2;
            this.ResistanceC.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // ResistanceE
            // 
            this.ResistanceE.Location = new System.Drawing.Point(345, 104);
            this.ResistanceE.Name = "ResistanceE";
            this.ResistanceE.Size = new System.Drawing.Size(100, 20);
            this.ResistanceE.TabIndex = 2;
            this.ResistanceE.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // ResistanceB
            // 
            this.ResistanceB.Location = new System.Drawing.Point(598, 226);
            this.ResistanceB.Name = "ResistanceB";
            this.ResistanceB.Size = new System.Drawing.Size(100, 20);
            this.ResistanceB.TabIndex = 3;
            this.ResistanceB.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // ResistanceTotalA
            // 
            this.ResistanceTotalA.Location = new System.Drawing.Point(674, 10);
            this.ResistanceTotalA.Name = "ResistanceTotalA";
            this.ResistanceTotalA.Size = new System.Drawing.Size(100, 20);
            this.ResistanceTotalA.TabIndex = 4;
            // 
            // ResistanceD
            // 
            this.ResistanceD.Location = new System.Drawing.Point(636, 229);
            this.ResistanceD.Name = "ResistanceD";
            this.ResistanceD.Size = new System.Drawing.Size(100, 20);
            this.ResistanceD.TabIndex = 3;
            // 
            // ResistanceTotalB
            // 
            this.ResistanceTotalB.Location = new System.Drawing.Point(665, 10);
            this.ResistanceTotalB.Name = "ResistanceTotalB";
            this.ResistanceTotalB.Size = new System.Drawing.Size(100, 20);
            this.ResistanceTotalB.TabIndex = 4;
            // 
            // ResistanceG
            // 
            this.ResistanceG.Location = new System.Drawing.Point(345, 333);
            this.ResistanceG.Name = "ResistanceG";
            this.ResistanceG.Size = new System.Drawing.Size(100, 20);
            this.ResistanceG.TabIndex = 3;
            // 
            // ResistanceF
            // 
            this.ResistanceF.Location = new System.Drawing.Point(585, 216);
            this.ResistanceF.Name = "ResistanceF";
            this.ResistanceF.Size = new System.Drawing.Size(100, 20);
            this.ResistanceF.TabIndex = 4;
            // 
            // ResistanceTotalC
            // 
            this.ResistanceTotalC.Location = new System.Drawing.Point(674, 9);
            this.ResistanceTotalC.Name = "ResistanceTotalC";
            this.ResistanceTotalC.Size = new System.Drawing.Size(100, 20);
            this.ResistanceTotalC.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ResistanceTotalA;
        private System.Windows.Forms.TextBox ResistanceB;
        private System.Windows.Forms.TextBox ResistanceA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ResistanceTotalB;
        private System.Windows.Forms.TextBox ResistanceD;
        private System.Windows.Forms.TextBox ResistanceC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox ResistanceE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ResistanceH;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox ResistanceTotalC;
        private System.Windows.Forms.TextBox ResistanceF;
        private System.Windows.Forms.TextBox ResistanceG;
    }
}

