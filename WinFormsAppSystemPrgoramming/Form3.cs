using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsAppSystemPrgoramming
{
    public partial class Form3 : Form
    {
        Methods meth = new Methods();
        List<int> arr1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            int arr_length = int.Parse(this.textBox2.Text);
            arr1 = meth.FillArray(arr_length);
            foreach (int i in arr1) { str = str + " " + i; }
            this.textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> temp_list = meth.Task2_Solution(arr1);
            String str = "";
            foreach (int i in temp_list) { str = str + " " + i; }
            this.textBox3.Text = str;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
