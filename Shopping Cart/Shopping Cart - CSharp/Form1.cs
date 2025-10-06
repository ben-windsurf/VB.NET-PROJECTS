using System;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (CheckBox1.Checked)
            {
                total += 50000;
            }
            if (CheckBox2.Checked)
            {
                total += 10000;
            }
            if (CheckBox3.Checked)
            {
                total += 8000;
            }

            TextBox1.Text = "Total is : ₹ " + total.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            TextBox1.Text = "Total is :";
        }
    }
}
