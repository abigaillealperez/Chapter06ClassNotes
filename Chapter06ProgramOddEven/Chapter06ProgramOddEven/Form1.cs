using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06ProgramOddEven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output = "Numberis even";

            //Convert from text to number
            flag = int.TryParse(txtNumber.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Not a number.Re-enter.");
                txtNumber.Clear();
                txtNumber.Focus();
                return;
            }

            //See if odd or even
            if (val % 2 == 1)
                output = (val % 2 == 0) ? "Number is even" : "Number is odd";
            
            //Show result
            lblOutput.Text = output;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
