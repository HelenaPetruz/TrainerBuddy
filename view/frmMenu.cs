﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class TrainnerBuddy3 : Form
    {
        TrainnerBuddy4 frm;
        public TrainnerBuddy3()
        {
            frm = new TrainnerBuddy4();
            
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
       
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
           

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.ShowDialog();
        }
    }
}