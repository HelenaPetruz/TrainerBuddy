using System;
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
        frmPlanos frmPlanos;
        frmCaixa frmCaixa;
        public TrainnerBuddy3()
        {
            frm = new TrainnerBuddy4();
            frmPlanos = new frmPlanos();
            frmCaixa = new frmCaixa();
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quer mesmo sair?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPlanos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCaixa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
