﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaySafeGen_v._2__Premium_
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToString(random.Next(1000, 9999))) + " " + (Convert.ToString(random.Next(1000, 9999))) + " " + (Convert.ToString(random.Next(1000, 9999))) + " " + (Convert.ToString(random.Next(1000, 9999)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
