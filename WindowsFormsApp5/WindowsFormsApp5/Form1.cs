﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Готов к работе";
            BackColor = Color.AntiqueWhite;
        }
    }
}
