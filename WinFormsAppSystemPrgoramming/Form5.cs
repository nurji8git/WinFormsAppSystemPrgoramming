using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsAppSystemPrgoramming
{
    public partial class Form5 : Form
    {
        Methods meth = new Methods();
        List<int> arr1;
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = meth.Task4_Solution(arr1);
            this.textBox3.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            int arr_length = int.Parse(this.textBox2.Text);
            arr1 = meth.FillArray(arr_length);
            foreach (int i in arr1) { str = str + " " + i; }
            this.textBox1.Text = str;
        }
    }
}
