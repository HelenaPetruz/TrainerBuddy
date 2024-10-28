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
            dgCaixa.Columns.Add("valor", "PREÇO DO PLANO");
            dgCaixa.Columns.Add("vencimento", "DATA DE VENCIMENTO DO PAGAMENTO");
            dgCaixa.Columns.Add("data_compra", "DATA DA COMPRA");
            dgCaixa.Columns.Add("total", "TOTAL");

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

            dgCaixa.Columns.Add("valor", "PREÇO DO PLANO");
            dgCaixa.Columns[3].Width = 100;

            dgCaixa.Columns[4].Width = 270;
            dgCaixa.Columns[4].HeaderText = "DATA DE VENCIMENTO DO PAGAMENTO";
            dgCaixa.Columns[4].DataPropertyName = "vencimento";

            dgCaixa.Columns[5].Width = 150;
            dgCaixa.Columns[5].HeaderText = "DATA DA COMPRA";
            dgCaixa.Columns[5].DataPropertyName = "data_compra";

            dgCaixa.Columns.Add("total", "TOTAL");
            dgCaixa.Columns[6].Width = 100;

            dgCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCaixa.AllowUserToAddRows = false;
            dgCaixa.AllowUserToDeleteRows = false;
            dgCaixa.MultiSelect = false;

            carregarGridView();
        }

        private void carregarGridView()
        {
            dgCaixa.DataSource = caixaControl.getAll();

            int cont;

            for (cont = 0; cont < dgCaixa.Rows.Count; cont++)
            {
                object valorCell = dgCaixa.Rows[cont].Cells[2].Value;
                int id_plano = Convert.ToInt32(valorCell);
                dgCaixa.Rows[cont].Cells[3].Value = caixaControl.getPrice(id_plano);
            }

            for (cont = 0; cont < dgCaixa.Rows.Count; cont++)
            {
                dgCaixa.Rows[cont].Cells[5].Value = "total ";
            }

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
