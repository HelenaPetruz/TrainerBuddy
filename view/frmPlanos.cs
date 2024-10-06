using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class frmPlanos : Form
    {
        public frmPlanos()
        {
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
            TrainnerBuddy3 frm = new TrainnerBuddy3();
            this.Close();
            frm.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TrainnerBuddy3 frm = new TrainnerBuddy3();
            this.Close();
            frm.Show();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quer mesmo sair?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
