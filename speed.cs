﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bow_and_Arrow_1
{
    public partial class speed : Form
    {
        public speed()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.showspeed(1);
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.MultiplyBalloonSpeed(2);
            form1.showspeed(2);
            form1.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.showspeed(3);
            form1.MultiplyBalloonSpeed(4);
            form1.Show();
            this.Hide();
        }
    }
}
