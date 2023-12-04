using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, rslt;
            num1 = double.Parse(valuex.Text);
            num2 = double.Parse(valuey.Text);
            rslt = 1 / 2 * num1 * num2;
            textBox1.Text = rslt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valuex.Clear();
            valuey.Clear();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }
    }
}
