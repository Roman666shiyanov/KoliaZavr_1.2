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
    public partial class obuvBD : Form
    {
        public obuvBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obuv we = new obuv();
            this.Hide();
            we.Show();
        }

        private void obuvBD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Обувь". При необходимости она может быть перемещена или удалена.
            this.обувьTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Обувь);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;

                for (int j = 0; j < dataGridView1.ColumnCount; j++)

                    if (dataGridView1.Rows[i].Cells[j].Value != null)

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))

                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                try
                {
                    MessageBox.Show("d");
                }
                catch { 




            }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 'Ё' || c == 'ё' || c == 8 || c == 46);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат данных");
            }
        }
    }
}
