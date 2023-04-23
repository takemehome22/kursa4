using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.Покупатели);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            покупателиTableAdapter.Update(бахаев_АвтомастерскаяDataSet);
            File.Delete(@"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
            File.Copy("Бахаев Автомастерская.mdb", @"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            покупателиBindingSource.RemoveCurrent();
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
            var row = бахаев_АвтомастерскаяDataSet.Покупатели.NewRow();
            row[0] = textBox2.Text;
            row[1] = textBox3.Text;
            row[2] = textBox4.Text;
            row[3] = maskedTextBox1.Text;
            бахаев_АвтомастерскаяDataSet.Покупатели.Rows.Add(row);
            this.покупателиTableAdapter.Update(this.бахаев_АвтомастерскаяDataSet.Покупатели);
        }
    }
}
