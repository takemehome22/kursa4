using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            заказыTableAdapter.Update(бахаев_АвтомастерскаяDataSet);
            File.Delete(@"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
            File.Copy("Бахаев Автомастерская.mdb", @"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказыBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
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
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var row = бахаев_АвтомастерскаяDataSet.Заказы.NewRow();
            row[0] = textBox2.Text;
            row[1] = textBox3.Text;
            row[2] = textBox4.Text;
            row[3] = textBox5.Text;
            row[4] = textBox6.Text;
            row[5] = textBox7.Text;
            row[6] = textBox8.Text;
            row[7] = textBox9.Text;
            row[8] = textBox10.Text;
            бахаев_АвтомастерскаяDataSet.Заказы.Rows.Add(row);
            this.заказыTableAdapter.Update(this.бахаев_АвтомастерскаяDataSet.Заказы);
        }
    }
}
