﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_grados_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gfa.Text = ((1.8 * double.Parse(gcel.Text)) + 32).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gcel.Text = ((double.Parse(gfa.Text) - 32) / 1.8).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gfa.Text = ""; gcel.Text = "";
            MessageBox.Show("Los valores han sido borrados");
        }
    }
}
