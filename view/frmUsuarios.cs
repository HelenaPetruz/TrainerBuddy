using Control;
using Model;
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
            dgUsuarios.Columns.Add("id_perfil", "STATUS");

            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.AllowUserToOrderColumns = true;
            dgUsuarios.ReadOnly = false;

            tblPessoa = _pessoaControl.getUsuáriosAtivos();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgUsuarios.ColumnCount = 5;
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

            dgUsuarios.Columns[4].Width = 300;
            dgUsuarios.Columns[4].HeaderText = "STATUS";
            dgUsuarios.Columns[4].DataPropertyName = "id_perfil";

            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.MultiSelect = false;

          
            carregaGridView();
        }

        private void dgUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dgUsuarios.Rows[e.RowIndex];
            int isActive = Convert.ToInt32(row.Cells["id_perfil"].Value); // Supondo que a coluna de status se chama "status"

            if (isActive == 3)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray; // Cor para usuários inativos
                row.DefaultCellStyle.ForeColor = Color.DarkGray;  // Cor do texto para usuários inativos
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White; // Cor padrão para usuários ativos
                row.DefaultCellStyle.ForeColor = Color.Black; // Cor do texto padrão para usuários ativos
            }
        }

        private void carregaGridView()
        {
            dgUsuarios.DataSource = _pessoaControl.getUsuáriosAtivos();
            dgUsuarios.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgUsuarios_RowPrePaint);
            dgUsuarios.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quer mesmo sair?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
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
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            int id;
            string id1;
            DialogResult dialog = new DialogResult();

            if (dgUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor, selecione exatamente uma linha para atualizar.");
                return;
            }
            else
            {

                dialog = MessageBox.Show("Deseja mesmo atualizar este usuario?", "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    id1 = dgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    id = System.Convert.ToInt32(id1);
                    pessoa.idpessoa = id;
                    pessoa.nome_usuario = dgUsuarios.CurrentRow.Cells[1].Value.ToString();
                    pessoa.cpf = dgUsuarios.CurrentRow.Cells[2].Value.ToString();
                    pessoa.email = dgUsuarios.CurrentRow.Cells[3].Value.ToString();

                    string resultado = _pessoaControl.Update(pessoa.idpessoa, pessoa.nome_usuario, pessoa.cpf, pessoa.email);
                    if (resultado.Equals("SUCESSO"))
                    {
                        MessageBox.Show("Usuario atualizado com sucesso");
                        carregaGridView();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o usuario \n " + resultado);
                        carregaGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o usuario FALHA NA AUTENTICACAO");
                    carregaGridView();
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
       
            int id;
            string id1;
            DialogResult dialog = new DialogResult();

            if (dgUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor, selecione exatamente uma linha para desativar.");
                return;
            }
            else
            {

                dialog = MessageBox.Show("Deseja mesmo desativar este usuario?", "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    id1 = dgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    id = System.Convert.ToInt32(id1);
               
                   

                    string resultado = _pessoaControl.Desativar(id);
                    if (resultado.Equals("SUCESSO"))
                    {
                        MessageBox.Show("Usuario desativado com sucesso");
                        carregaGridView();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao desativar o usuario \n " + resultado);
                        carregaGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao desativar o usuario FALHA NA AUTENTICACAO");
                    carregaGridView();
                }
            }
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
                string nome = txtBuscar.Text;
                dgUsuarios.DataSource = _pessoaControl.filterByName(nome);
                dgUsuarios.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgUsuarios_RowPrePaint);
                dgUsuarios.Refresh();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            string id1;
            DialogResult dialog = new DialogResult();

            if (dgUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor, selecione exatamente uma linha para reativar.");
                return;
            }
            else
            {

                dialog = MessageBox.Show("Deseja mesmo reativar este usuario?", "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    id1 = dgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    id = System.Convert.ToInt32(id1);



                    string resultado = _pessoaControl.Reativar(id);
                    if (resultado.Equals("SUCESSO"))
                    {
                        MessageBox.Show("Usuario reativado com sucesso");
                        carregaGridView();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao reativar o usuario \n " + resultado);
                        carregaGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao reativar o usuario FALHA NA AUTENTICACAO");
                    carregaGridView();
                }
            }
        }
    }
}
