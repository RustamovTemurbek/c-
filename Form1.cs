using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Betlash_CANON_3220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (textBox1.Text != " " && a > 500)
            {

                a = 0;

            }
            if (textBox1.Text != "" && a <= 500)
            {
                textBox3.Clear();

                if (textBox1.Text != "")
                {
                    a = int.Parse(textBox1.Text);
                }
                if (a % 4 == 0)
                {
                    for (int i = (a / 4) - 1; i >= 0; i--)
                    {
                        if (i != a / 4 - 1)
                        { textBox3.Text += ","; }
                        textBox3.Text += "" + (a - (2 * i));
                        textBox3.Text += "," + (i * 2 + 1);
                    }
                }
                else
                {
                    // x = " Kechirasiz betlash uchun togri kelmaydi";
                    MessageBox.Show("Kechirasiz betlash uchun to'g'ri kelmaydi");
                }
            }

            if (textBox1.Text != "" && a <= 500)
            {
                textBox2.Clear();

                a = int.Parse(textBox1.Text);
                if (a % 4 == 0)
                {
                    for (int i = a / 4 - 1; i >= 0; i--)
                    {
                        if (i != a / 4 - 1)
                        { textBox2.Text += ","; }

                        textBox2.Text += "" + (2 + (i * 2));
                        textBox2.Text += "," + (a - 1 - (i * 2));

                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://telegra.ph/Canon-3220-12-08");
        }
    }
}
