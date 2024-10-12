using Control;
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
    public partial class frmGrafico : Form
    {
        private readonly FaturamentoControl caixaControl;
        public DataTable tblCaixa = new DataTable();
        private int modo = 0;

        public frmGrafico()
        {
            InitializeComponent();
            caixaControl = new FaturamentoControl();

        }

        private void frmGrafico_Load(object sender, EventArgs e)
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
            frmCaixa frm = new frmCaixa();
            this.Close();
            frm.Show();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
