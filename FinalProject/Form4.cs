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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = double.Parse(Width.Text);
            num2 = double.Parse(Length.Text);
            result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Width.Clear();
            Length.Clear();
            textBox3.Clear();
        }
    }
}
