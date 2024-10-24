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
using System.Windows.Forms.DataVisualization.Charting;

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

        private void ConfigurarGrafico()
        {
            chartFaturamento.Series.Clear();
            chartFaturamento.Series.Add("Faturamento");
            chartFaturamento.Series["Faturamento"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartFaturamento.Series["Faturamento"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartFaturamento.Series["Faturamento"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            // Aqui é pra definir o eixo X e Y
            chartFaturamento.ChartAreas[0].AxisX.Title = "Meses";
            chartFaturamento.ChartAreas[0].AxisY.Title = "Faturamento Total";

            chartFaturamento.Legends.Clear();
            chartFaturamento.Legends.Add("LegendaFaturamento");
            chartFaturamento.Legends["LegendaFaturamento"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            chartFaturamento.Legends["LegendaFaturamento"].Alignment = System.Drawing.StringAlignment.Center;
            chartFaturamento.Legends["LegendaFaturamento"].Title = "Legenda do Gráfico";

        }

        private void ConfigurarGrafico2()
        {
            chartFaturamento.Series.Clear();
            chartFaturamento.Series.Add("PlanoMaisAdquirido");
            chartFaturamento.Series["PlanoMaisAdquirido"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartFaturamento.Series["PlanoMaisAdquirido"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartFaturamento.Series["PlanoMaisAdquirido"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            // Aqui é pra definir o eixo X e Y
            chartFaturamento.ChartAreas[0].AxisX.Title = "id plano";
            chartFaturamento.ChartAreas[0].AxisY.Title = "pessoas";

            chartFaturamento.Legends.Clear();
            chartFaturamento.Legends.Add("LegendaFaturamento");
            chartFaturamento.Legends["LegendaFaturamento"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            chartFaturamento.Legends["LegendaFaturamento"].Alignment = System.Drawing.StringAlignment.Center;
            chartFaturamento.Legends["LegendaFaturamento"].Title = "Legenda do Gráfico";

        }

        private void PreencherGrafico(Dictionary<int, double> faturamentoMensal)
        {
            chartFaturamento.Series["Faturamento"].Points.Clear();
            foreach (var mesFaturamento in faturamentoMensal)
            {
                int mes = mesFaturamento.Key;
                double valorTotal = mesFaturamento.Value;
                chartFaturamento.Series["Faturamento"].Points.AddXY(mes, valorTotal);
            }
        }

        private void PreencherGrafico2(Dictionary<int, int> planoMaisAdquirido)
        {
            chartFaturamento.Series["PlanoMaisAdquirido"].Points.Clear();
            foreach (var idPlano in planoMaisAdquirido)
            {
                int id = idPlano.Key;
                int pessoa = idPlano.Value;
                chartFaturamento.Series["PlanoMaisAdquirido"].Points.AddXY(id, pessoa);
            }
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

        private void btnFaturamentoMensal_Click(object sender, EventArgs e)
        {
            chartFaturamento.Series.Clear();
            Series seriesFaturamento = new Series("Faturamento");
            seriesFaturamento.ChartType = SeriesChartType.Column;
            chartFaturamento.Series.Add(seriesFaturamento);

            lblAno.Visible = true;
            txtAno.Visible = true;
            btnGerarGrafico.Visible = true;
        }

        private void btnGerarGrafico_Click(object sender, EventArgs e)
        {
            lblAno.Visible = true;
            txtAno.Visible = true;
            btnGerarGrafico.Visible = true;

            int ano = int.Parse(txtAno.Text);

            Dictionary<int, double> faturamentoMensal = caixaControl.ObterFaturamentoMensalPorAno(ano);

            if (faturamentoMensal != null && faturamentoMensal.Count > 0)
            {
                PreencherGrafico(faturamentoMensal);
                lblEixox.Visible = true;
                lblEixoy.Visible = true;
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado para o ano selecionado.");
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblAno.Visible = false;
            txtAno.Visible = false;
            btnGerarGrafico.Visible = false;
            chartFaturamento.Series.Clear();
            Series planoMaisAdquirido = new Series("PlanoMaisAdquirido");
            planoMaisAdquirido.ChartType = SeriesChartType.Column;
            chartFaturamento.Series.Add(planoMaisAdquirido);
            Dictionary<int, int> planoMais = caixaControl.ObterPlanoMaisAdquirido();
            PreencherGrafico2(planoMais);
        }
    }
}
