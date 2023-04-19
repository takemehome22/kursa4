using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.ВидыОпераций". При необходимости она может быть перемещена или удалена.
            this.видыОперацийTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.ВидыОпераций);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.Касса". При необходимости она может быть перемещена или удалена.
            this.кассаTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.Касса);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            кассаTableAdapter.Update(бахаев_АвтомастерскаяDataSet);
            File.Delete(@"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
            File.Copy("Бахаев Автомастерская.mdb", @"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            кассаBindingSource.RemoveCurrent();
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
            var row = бахаев_АвтомастерскаяDataSet.Касса.NewRow();
            row[0] = textBox2.Text;
            row[1] = dateTimePicker1.Text;
            row[2] = textBox4.Text;
            row[3] = comboBox2.Text;
            row[4] = comboBox3.Text;
            row[5] = textBox7.Text;
            бахаев_АвтомастерскаяDataSet.Касса.Rows.Add(row);
            this.кассаTableAdapter.Update(this.бахаев_АвтомастерскаяDataSet.Касса);
        }
    }
}
