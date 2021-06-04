using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Click += textBox1_TextChanged;
            textBox2.Click += textBox2_TextChanged;
            textBox1.MouseUp += textBox1_TextChanged;
            textBox2.MouseUp += textBox2_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = default;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = default;
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
            }
            if (textBox2.Text == null)
            {
                textBox2.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Hello admin");
            }
            else
            {
                label2.Text = "Invalid Username or Password";
                label2.ForeColor = Color.Red;
            }
        }

    }
}
