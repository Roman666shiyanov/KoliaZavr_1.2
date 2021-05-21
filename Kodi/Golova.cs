using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitrina
{
    public partial class Golova : Form
    {
        public Golova()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Vibor sp3 = new Vibor();
            this.Hide();
            sp3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GolovaBD qp3 = new GolovaBD();
            this.Hide();
            qp3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
