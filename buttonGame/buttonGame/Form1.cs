using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonGame
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.numberOfButtons = Convert.ToInt32(textBox1.Text);
            secondForm.moreButtons = Convert.ToInt32(textBox1.Text) % 5;
            secondForm.Show();
            textBox1.Text="";   
        }
    }
}
