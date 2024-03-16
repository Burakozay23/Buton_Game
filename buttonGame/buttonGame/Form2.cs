using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonGame
{
    public partial class Form2 : Form
    { 
        int butonCounter = 1;
        public int numberOfButtons,moreButtons;
        int butonNameCounter = 1,counterx=0,countery=0;
        int temp,j,i;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < numberOfButtons ; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(40 * counterx, 40 * countery);
                btn.Size = new Size(40, 40);
                btn.Text = butonNameCounter.ToString();
                btn.Name = butonNameCounter.ToString();
                btn.BackColor = Color.White;
                this.Controls.Add(btn);
                butonNameCounter++;
                btn.Click += new EventHandler(this.Btn_Click);
                counterx++;
                if (counterx == 5)
                {
                    counterx = 0;
                    countery++;
                }
            }    
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            if (btn.BackColor==Color.SkyBlue)
            {
                btn.BackColor= Color.White;
                butonCounter--;
            }
            else
            {
                btn.BackColor = Color.SkyBlue;
                butonCounter++;
            }
            if (butonCounter==butonNameCounter)
            {
                label1.Visible=true;
            }
        }
    }
}

