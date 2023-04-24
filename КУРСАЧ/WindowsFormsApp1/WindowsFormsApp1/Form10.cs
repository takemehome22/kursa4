using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.КатегорииПоставщиков". При необходимости она может быть перемещена или удалена.
            this.категорииПоставщиковTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.КатегорииПоставщиков);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.СправочникТоваров". При необходимости она может быть перемещена или удалена.
            this.справочникТоваровTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.СправочникТоваров);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            справочникТоваровTableAdapter.Update(бахаев_АвтомастерскаяDataSet);
            File.Delete(@"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
            File.Copy("Бахаев Автомастерская.mdb", @"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            справочникТоваровBindingSource.RemoveCurrent();
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
            var row = бахаев_АвтомастерскаяDataSet.СправочникТоваров.NewRow();
            row[0] = textBox2.Text;
            row[1] = comboBox1.Text;
            row[2] = textBox3.Text;
            row[3] = textBox4.Text;
            бахаев_АвтомастерскаяDataSet.СправочникТоваров.Rows.Add(row);
            this.справочникТоваровTableAdapter.Update(this.бахаев_АвтомастерскаяDataSet.СправочникТоваров);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }



        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}

