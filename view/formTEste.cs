using Control;
using FluentValidation.Results;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace view
{
    public partial class TrainnerBuddy2 : Form
    {


        private readonly PessoaControl _pessoaControl;
        TrainnerBuddy1 frm;
        public TrainnerBuddy2()
        {
            frm = new TrainnerBuddy1(1);
            _pessoaControl = new PessoaControl();
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            Pessoa pessoa = new Pessoa();
            pessoa.email = txtUsuario1.Text;

            if (txtSenha1.Text.Equals(txtRepita.Text))
            {
                pessoa.senha = txtSenha1.Text;
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos ", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(pessoa != null)
            {
                PessoaValidation validator = new PessoaValidation();
                ValidationResult results = validator.Validate(pessoa);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (_pessoaControl.Cadastro(txtUsuario1.Text, txtSenha1.Text, txtRepita.Text).Equals("SUCESSO"))
                    {
                        this.Close();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha inválidos ", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

          

        }
    }
}
