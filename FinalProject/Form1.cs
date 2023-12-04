using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string letter;
        private int length = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form  = new Form2();
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
