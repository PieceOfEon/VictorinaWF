using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victorina
{
    public partial class Form1 : Form
    {
        public int money = 0;
        public int HP = 3;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton6.Checked = false;
            label2.Text = "Money = 0";
            label3.Text = "HP = 3";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Верно!");
                money += 1000;
                label2_Click(money,e);
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                label1.Visible = false;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                label4.Visible = true;

            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if(HP==0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Money = " + Convert.ToString(money);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }
       
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                MessageBox.Show("Верно!");
                money += 4000;
                label2_Click(money, e);
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                label4.Visible = false;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                label5.Visible = true;

            }
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                MessageBox.Show("Верно!");
                money *= 10;
                label2_Click(money, e);
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                label5.Visible = false;
                radioButton13.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                radioButton16.Visible = true;
                label6.Visible = true;

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                MessageBox.Show("Ne Верно!");
                HP -= 1;
                label3.Text = "HP = " + HP;
                if (HP == 0)
                {
                    MessageBox.Show("Вы проиграли!");
                    Close();
                }
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                MessageBox.Show("Верно!");
                money *= 20;
                label2_Click(money, e);
                pictureBox1.Visible = true;
                label7.Visible = true;


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
