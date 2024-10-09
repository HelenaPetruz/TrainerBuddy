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
    public partial class frmPlanos : Form
    {

        private readonly PlanoControl planoControl;
        public DataTable tblPlanos = new DataTable();
        private int modo = 0;

        public frmPlanos()
        {
            InitializeComponent();
            planoControl = new PlanoControl();

            dgPlanos.Columns.Add("id_plano", "ID");
            dgPlanos.Columns.Add("nome_plano", "NOME PLANO");
            dgPlanos.Columns.Add("valor", "PREÇO");

            dgPlanos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPlanos.AllowUserToAddRows = false;
            dgPlanos.AllowUserToDeleteRows = false;
            dgPlanos.AllowUserToOrderColumns = true;
            dgPlanos.ReadOnly = true;

            tblPlanos = planoControl.getAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgPlanos.ColumnCount = 3;
            dgPlanos.AutoGenerateColumns = false;

            dgPlanos.Columns[0].Width = 20;
            dgPlanos.Columns[0].HeaderText = "ID";
            dgPlanos.Columns[0].DataPropertyName = "id_plano";

            dgPlanos.Columns[1].Width = 275;
            dgPlanos.Columns[1].HeaderText = "NOME PLANO";
            dgPlanos.Columns[1].DataPropertyName = "nome_plano";

            dgPlanos.Columns[2].Width = 275;
            dgPlanos.Columns[2].HeaderText = "PREÇO";
            dgPlanos.Columns[2].DataPropertyName = "valor";

            dgPlanos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPlanos.AllowUserToAddRows = false;
            dgPlanos.AllowUserToDeleteRows = false;
            dgPlanos.MultiSelect = false;

            carregaGridView();
        }

        private void carregaGridView()
        {
            dgPlanos.DataSource = planoControl.getAll();
            dgPlanos.Refresh();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            dgPlanos.ReadOnly = false;
            dgPlanos.AllowUserToAddRows = false;
            this.dgPlanos.EditMode = DataGridViewEditMode.EditOnEnter;
            lblAlterar.Visible = true;
        }

        private void dgPlanos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgPlanos.ReadOnly = false;
            dgPlanos.AllowUserToAddRows = false;
            dgPlanos.Columns[0].ReadOnly = true;
            this.dgPlanos.EditMode = DataGridViewEditMode.EditOnEnter;

            int rowIndex = e.RowIndex;
            //int columnIndex = e.ColumnIndex;
            string nome = dgPlanos.Rows[rowIndex].Cells[1].Value.ToString();
            double valor = Convert.ToDouble(dgPlanos.Rows[rowIndex].Cells[2].Value);
            int id = Convert.ToInt32(dgPlanos.Rows[rowIndex].Cells[0].Value);

            DialogResult resultado = MessageBox.Show("Você deseja realmente alterar esse plano?", "Confirmação de alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                planoControl.Update(id, nome, valor);
            }
            else
            {
                carregaGridView();
            }            
        }

        private void dgPlanos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }
        }
    }
}
