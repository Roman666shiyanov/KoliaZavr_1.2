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
    public partial class Kostumi : Form
    {
        public Kostumi()
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
            KostumiBD wp3 = new KostumiBD();
            this.Hide();
           wp3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
