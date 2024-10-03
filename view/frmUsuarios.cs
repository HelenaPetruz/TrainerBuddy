using Control;
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
    public partial class TrainnerBuddy4 : Form
    {


        private readonly PessoaControl _pessoaControl;
        public DataTable tblPessoa = new DataTable();
        //sinaliza qual operação está em andamento
        //0 = nada
        //1 = inclusão (novo)
        //2 = alteração
        private int modo = 0; //sinaliza qual operação está em andamento

        public TrainnerBuddy4()
        {
            InitializeComponent();
            _pessoaControl = new PessoaControl();

           
            dgUsuarios.Columns.Add("idpessoa", "ID");
            dgUsuarios.Columns.Add("nome_usuario", "NOME USUARIO");
            dgUsuarios.Columns.Add("cpf", "CPF");
            dgUsuarios.Columns.Add("email", "EMAIL");

            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.AllowUserToOrderColumns = true;
            dgUsuarios.ReadOnly = true;

            tblPessoa = _pessoaControl.getAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgUsuarios.ColumnCount = 4;
            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.Columns[0].Width = 20;
            dgUsuarios.Columns[0].HeaderText = "ID";
            dgUsuarios.Columns[0].DataPropertyName = "idpessoa";

            dgUsuarios.Columns[1].Width = 275;
            dgUsuarios.Columns[1].HeaderText = "NOME USUARIO";
            dgUsuarios.Columns[1].DataPropertyName = "nome_usuario";

            dgUsuarios.Columns[2].Width = 300;
            dgUsuarios.Columns[2].HeaderText = "CPF";
            dgUsuarios.Columns[2].DataPropertyName = "cpf";

            dgUsuarios.Columns[3].Width = 300;
            dgUsuarios.Columns[3].HeaderText = "EMAIL";
            dgUsuarios.Columns[3].DataPropertyName = "email";

            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.MultiSelect = false;


            carregaGridView();
        }

        private void carregaGridView()
        {
            dgUsuarios.DataSource = _pessoaControl.getAll();
            dgUsuarios.Refresh();
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
