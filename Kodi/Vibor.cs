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
    public partial class Vibor : Form
    {
        public Vibor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obuv sr1 = new obuv();
            this.Hide();
            sr1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shtani sr2 = new shtani();
            this.Hide();
            sr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kurtki sr3 = new Kurtki();
            this.Hide();
            sr3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kostumi sr4 = new Kostumi();
            this.Hide();
            sr4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Golova sr5 = new Golova();
            this.Hide();
            sr5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
