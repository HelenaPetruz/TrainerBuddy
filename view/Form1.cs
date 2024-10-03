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
    public partial class TrainnerBuddy1 : Form
    {
        //private TrainnerBuddy2 frm;

        private readonly PessoaControl _pessoaControl;

        public TrainnerBuddy1()
        {

            _pessoaControl = new PessoaControl();
            //frm = new TrainnerBuddy2();

            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            thread.Abort();
        }

        public TrainnerBuddy1(int gambi)
        {
            InitializeComponent();
        }



        private void splashScreen()
        {
           Application.Run(new SplashScreen());
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

        private void lblCadastro1_Click(object sender, EventArgs e)
        {
            //frm.Show();
            TrainnerBuddy2 frm = new TrainnerBuddy2();
            frm.Show();
            this.Hide();
        
        }

        private void btnEntrar1_Click(object sender, EventArgs e)
        {
            DataTable pessoa;
         pessoa = _pessoaControl.filterByEmail(txtUsuario1.Text);

          
                TrainnerBuddy3 frm = new TrainnerBuddy3();
                frm.Show();
                this.Hide();
            }
        }
    }
