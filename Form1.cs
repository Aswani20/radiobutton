using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        Form myform = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                this.BackColor = Color.HotPink;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(500, 500);
            this.CreateGraphics().DrawLine(Pens.Blue, pt1, pt2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myform.Show();
        }
    }
}
