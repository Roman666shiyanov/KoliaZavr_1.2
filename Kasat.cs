using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelineinoe
{
    public partial class Kasat : Form
    {
        public Kasat()
        {
            InitializeComponent();
        }
        public Kasat(Glavn f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavn newForm1 = new Glavn();
            this.Hide();
            newForm1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            const double eps = 0.01;
            double fa = 2 * Math.Pow(a, 2) + 2 * a - 1;

            double fb = 2 * Math.Pow(b, 2) + 2 * b - 1;


            x = b - fb / (fb - fa) / (b - a);
            while (fa - fb >= eps) ;
            {
                x = b - fb / (fb - fa) / (b - a);
                if (ff(b) - ff(x) < 0)
                {
                    b = x;
                }
                else
                {
                    a = x;
                }



                
                textBox4.Text = x.ToString($"F{textBox3.Text}");
                




            }
        }
        public double ff(double x)
        {

            double f = 2 * Math.Pow(x, 2) + 2 * x - 1;


            return f;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Kasat_Load(object sender, EventArgs e)
        {

        }
    }
}
