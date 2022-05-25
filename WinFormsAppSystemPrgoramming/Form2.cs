using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppSystemPrgoramming
{
    public partial class Form2 : Form
    {
        Methods meth = new Methods();
        List<int> arr1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            int arr_length = int.Parse(this.textBox2.Text);
            arr1 = meth.FillArray(arr_length);
            foreach (int i in arr1)
            {
                str += " " + i;
            }
            this.textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = meth.MaxIndex(arr1);
            this.textBox4.Text = arr1.ElementAt<int>(index) + "";
            this.textBox3.Text = meth.Message(meth.BeforeMax(index, arr1), meth.AfterMax(index, arr1));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
