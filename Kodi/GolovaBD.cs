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
    public partial class GolovaBD : Form
    {
        public GolovaBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Golova qp3 = new Golova();
            this.Hide();
            qp3.Show();
        }
    }
}
