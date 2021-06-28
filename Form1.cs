using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Витрина
{  
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ewrw.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ewrwDataSet.Обувь". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter3.Fill(this.ewrwDataSet.Обувь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ewrwDataSet1.Куртки". При необходимости она может быть перемещена или удалена.
            this.образованиеTableAdapter3.Fill(this.ewrwDataSet1.Куртки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ewrwDataSet1.Костюмы". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter2.Fill(this.ewrwDataSet1.Костюмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ewrwDataSet.Штаны". При необходимости она может быть перемещена или удалена.
            this.образованиеTableAdapter2.Fill(this.ewrwDataSet.Штаны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ewrwDataSet1.Головные убо-ры". При необходимости она может быть перемещена или удалена.
            this.личные_данныеTableAdapter3.Fill(this.ewrwDataSet1.Головные_уборы);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown1.Text);
            string query = "DELETE FROM Обувь WHERE [Id] ="+ kod ;
            string queryy = "DELETE FROM [Головные_уборы] WHERE [Id] =" + kod;
            string quer = "DELETE FROM Куртки WHERE [Id] =" + kod;
            string querye = "DELETE FROM Штаны WHERE [Id] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbCommand commandы = new OleDbCommand(quer, myConnection);
            OleDbCommand commandos = new OleDbCommand(querye, myConnection);
            OleDbCommand commandoss = new OleDbCommand(queryy, myConnection);
            command.ExecuteNonQuery();
            commandы.ExecuteNonQuery();
            commandos.ExecuteNonQuery();
            commandoss.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике удалены");
            this.абитуриентыTableAdapter3.Fill(this.ewrwDataSet.Обувьы);
            this.личные_данныеTableAdapter3.Fill(this.ewrwDataSet1.Головные_уборы);
            this.образованиеTableAdapter3.Fill(this.ewrwDataSet1.Штаны);
            this.родителиTableAdapter3.Fill(this.ewrwDataSet.Костюмы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown6.Text);
            string query = "UPDATE Обувь SET Наименование_товара='" + textBox3.Text + "' WHERE [Id] = "+ kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Название изменено на" + textBox3.Text);
            this.обувьTableAdapter3.Fill(this.ewrwDataSet.Обувь);
            Log.Logger("Название было изменено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fr ss = new fr();
            ss.Owner = this;
            ss.Show();
            
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.обувьTableAdapter3.Fill(this.ewrwDataSet.Обувь);
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dd sss = new dd();
            sss.Owner = this;
            sss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown2.Text);
            string query = "DELETE FROM [Головные_уборы] WHERE [Id] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            Log.Logger("Данные были удалены");
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown5.Text);
            string query = "UPDATE [Головные уборы] SET [Наименование_товара]='" + textBox1.Text + "' WHERE [Код абитуриента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Паспортные данные изменены на  " + textBox1.Text);
            this.головные_уборыTableAdapter3.Fill(this.ewrwDataSet1.Головные_уборы);
              Log.Logger("Данные были изменены");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown3.Text);
            string query = "DELETE FROM Куртки WHERE [Id] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
              Log.Logger("Данные были удалены");
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown7.Text);
            string query = "UPDATE обувь SET Наличие_товара='" + textBox2.Text + "' WHERE [Id] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Количество изменено " + textBox2.Text);
            this.обувьTableAdapter3.Fill(this.ewrwDataSet1.Обувь);
              Log.Logger("Количество обуви было изменено");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown4.Text);
            string query = "DELETE FROM Штаны WHERE [Id] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
              Log.Logger("Данные были удалены");
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.обувьTableAdapter3.Fill(this.ewrwDataSet.Обувь);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
    }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView2.Size.Width + 10, dataGridView2.Size.Height + 10);
            dataGridView2.DrawToBitmap(bmp, dataGridView2.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            printDocument3.Print();
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView3.Size.Width + 10, dataGridView3.Size.Height + 10);
            dataGridView3.DrawToBitmap(bmp, dataGridView3.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView4.Size.Width + 10, dataGridView4.Size.Height + 10);
            dataGridView4.DrawToBitmap(bmp, dataGridView4.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            printDocument4.Print();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(numericUpDown8.Text);
            string query = "UPDATE Обувь SET [Количество]='" + textBox4.Text + "' WHERE [Id] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Количество " + textBox4.Text);
            this.обувьTableAdapter3.Fill(this.ewrwDataSet.обувь);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.курткиTableAdapter3.Fill(this.ewrwDataSet1.Образование);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Головные_уборыTableAdapter3.Fill(this.ewrwDataSet1.Головные_уборы);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dg ssss = new dg();
            ssss.Owner = this;
            ssss.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            gh er= new gh();
            er.Owner = this;
            er.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            List<TimeSpan> times = new List<TimeSpan>();
            times.Add(new TimeSpan(0, 1, 23));
            times.Add(new TimeSpan(0, 1, 12));
            times.Add(new TimeSpan(0, 1, 28));
            times.Add(new TimeSpan(0, 1, 32));

            TimeSpan timeMax = times.Max();
            TimeSpan timeMin = times.Min();

            var data = times.Select((v, i) => new { index = i, value = v }).ToList();

            dataGridView1.DataSource = data;
        }
        // запись в файл
         private void button23_Click(object sender, EventArgs e)
        {
        FileStream fs = new FileStream(@"C:\1.txt", FileMode.Create);
                        StreamWriter streamWriter = new StreamWriter(fs);
 
                        try
                        {
                            for (int j = 0; j < dataBase.Rows.Count; j++)
                            {
                                for (int i = 0; i < dataBase.Rows[j].Cells.Count; i++)
                                {
                                    streamWriter.Write(dataBase.Rows[j].Cells[i].Value + "     ");
                                }
 
                                streamWriter.WriteLine();
                            }
 
                            streamWriter.Close();
                            fs.Close();
 
                            MessageBox.Show("Файл успешно сохранен");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка при сохранении файла!");
                        }
                        }
                        // чтение из файла
         private void button23_Click(object sender, EventArgs e)
        {
        StreamReader rd = new StreamReader(@"C:\EE.txt", Encoding.GetEncoding(1251));
            DataSet ds = new DataSet();
            ds.Tables.Add("Score");
            string header = rd.ReadLine();
            string[] col = System.Text.RegularExpressions.Regex.Split(header, ",");
            for (int c = 0; c < col.Length; c++)
            {
                ds.Tables[0].Columns.Add(col[c]);
            }
            string row = rd.ReadLine();
            while (row != null)
            {
                string[] rvalue = System.Text.RegularExpressions.Regex.Split(row, ",");
                ds.Tables[0].Rows.Add(rvalue);
                row = rd.ReadLine();
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        }
    }

