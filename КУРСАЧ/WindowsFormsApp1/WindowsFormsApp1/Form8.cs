using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.Поставщики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            поставщикиTableAdapter.Update(бахаев_АвтомастерскаяDataSet);
            File.Delete(@"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
            File.Copy("Бахаев Автомастерская.mdb", @"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.RemoveCurrent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var row = бахаев_АвтомастерскаяDataSet.Поставщики.NewRow();
            row[0] = textBox2.Text;
            row[1] = textBox3.Text;
            row[2] = comboBox2.Text;
            row[3] = comboBox3.Text;
            row[4] = textBox6.Text;
            row[5] = maskedTextBox1.Text;
            бахаев_АвтомастерскаяDataSet.Поставщики.Rows.Add(row);
            this.поставщикиTableAdapter.Update(this.бахаев_АвтомастерскаяDataSet.Поставщики);
        }
    }
}
