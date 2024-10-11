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
    public partial class frmCaixa : Form
    {
        private readonly FaturamentoControl caixaControl;
        public DataTable tblCaixa = new DataTable();
        private int modo = 0;

        public frmCaixa()
        {
            InitializeComponent();
            caixaControl = new FaturamentoControl();

            dgCaixa.Columns.Add("id_faturamento", "ID");
            dgCaixa.Columns.Add("id_Usuario", "ID DO USUÁRIO");
            dgCaixa.Columns.Add("id_Plano", "ID DO PLANO");
            dgCaixa.Columns.Add("vencimento", "DATA DE VENCIMENTO DO PAGAMENTO");
            dgCaixa.Columns.Add("data_compra", "DATA DA COMPRA");

            dgCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCaixa.AllowUserToAddRows = false;
            dgCaixa.AllowUserToDeleteRows = false;
            dgCaixa.AllowUserToOrderColumns = true;

            tblCaixa = caixaControl.getAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgCaixa.ColumnCount = 5;
            dgCaixa.AutoGenerateColumns = false;

            dgCaixa.Columns[0].Width = 20;
            dgCaixa.Columns[0].HeaderText = "ID";
            dgCaixa.Columns[0].DataPropertyName = "id_faturamento";

            dgCaixa.Columns[1].Width = 60;
            dgCaixa.Columns[1].HeaderText = "ID DO USUÁRIO";
            dgCaixa.Columns[1].DataPropertyName = "id_Usuario";

            dgCaixa.Columns[2].Width = 60;
            dgCaixa.Columns[2].HeaderText = "ID DO PLANO";
            dgCaixa.Columns[2].DataPropertyName = "id_Plano";

            dgCaixa.Columns[3].Width = 270;
            dgCaixa.Columns[3].HeaderText = "DATA DE VENCIMENTO DO PAGAMENTO";
            dgCaixa.Columns[3].DataPropertyName = "vencimento";

            dgCaixa.Columns[4].Width = 270;
            dgCaixa.Columns[4].HeaderText = "DATA DA COMPRA";
            dgCaixa.Columns[4].DataPropertyName = "data_compra";

            dgCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCaixa.AllowUserToAddRows = false;
            dgCaixa.AllowUserToDeleteRows = false;
            dgCaixa.MultiSelect = false;

            carregarGridView();
        }

        private void carregarGridView()
        {
            dgCaixa.DataSource = caixaControl.getAll();
            dgCaixa.Refresh();
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
            this.Close();
        }
    }
}
