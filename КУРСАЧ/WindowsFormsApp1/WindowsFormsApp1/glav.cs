using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class glav : Form
    {
        public glav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 видыопераций = new Form2();
            видыопераций.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 заказы = new Form3();
            заказы.Show();
            this.Hide();
        } 
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 касса = new Form4();
            касса.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 категория_поставщиков = new Form6();
            категория_поставщиков.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form7 покупатели = new Form7();
            покупатели.Show();
            this.Hide();
        }  
        private void button10_Click(object sender, EventArgs e)
        {
            Form8 поставщики = new Form8();
            поставщики.Show();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form9 склад = new Form9();
            склад.Show();
            this.Hide();

        } 
        private void button8_Click(object sender, EventArgs e)
        {
            Form10 Справочники_о_товаре = new Form10();
            Справочники_о_товаре.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 страны = new Form11();
            страны.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void glav_Load(object sender, EventArgs e)
        {

        }
    }
}
