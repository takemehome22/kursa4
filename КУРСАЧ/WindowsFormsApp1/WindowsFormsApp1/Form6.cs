using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бахаев_АвтомастерскаяDataSet.КатегорииПоставщиков". При необходимости она может быть перемещена или удалена.
            this.категорииПоставщиковTableAdapter.Fill(this.бахаев_АвтомастерскаяDataSet.КатегорииПоставщиков);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            glav gl = new glav();
            gl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            категорииПоставщиковTableAdapter.Update(бахаев_АвтомастерскаяDataSet);
            File.Delete(@"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
            File.Copy("Бахаев Автомастерская.mdb", @"..\..\..\WindowsFormsApp1\Бахаев Автомастерская.mdb");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            категорииПоставщиковBindingSource.RemoveCurrent();
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
    }
}
