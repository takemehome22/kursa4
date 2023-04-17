using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool vis = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "1" & textBox2.Text == "1")
            {
                glav gl = new glav();
                gl.Show();
                this.Hide();
            }

            else

            {
                MessageBox.Show("Не правильно введен логин или пароль");
            }
        }

 
        private void label4_Click(object sender, EventArgs e)
        {
            {
                if (vis)

                {
                    textBox2.UseSystemPasswordChar = false;
                    vis = false;
                }

                else

                {
                    textBox2.UseSystemPasswordChar = true;
                    vis = true;

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
