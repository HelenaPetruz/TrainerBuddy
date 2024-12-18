﻿using Control;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

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

            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

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
            frmCaixa frm = new frmCaixa();
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

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            lblEixox.Visible = false;
            lblEixoy.Visible = false;
            btnImprimir.Visible = false;
            btnDownload.Visible = false;
            lblTituloGrafico.Visible = false;
        }

        private void btnGerarGrafico_Click(object sender, EventArgs e)
        {

            lblAno.Visible = true;
            txtAno.Visible = true;
            btnGerarGrafico.Visible = true;


            int ano = 0;
            try
            {
                ano = int.Parse(txtAno.Text);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Digite um ano!");
            }

            Dictionary<int, double> faturamentoMensal = caixaControl.ObterFaturamentoMensalPorAno(ano);

            if (faturamentoMensal != null && faturamentoMensal.Count > 0)
            {
                PreencherGrafico(faturamentoMensal);
                lblEixoy.Text = "Faturamento em R$";
                lblEixox.Text = "Meses";
                lblEixox.Visible = true;
                lblEixoy.Visible = true;
                btnImprimir.Visible = true;
                btnDownload.Visible = true;
                lblTituloGrafico.Text = "Faturamento Mensal do ano de " + txtAno.Text;
                lblTituloGrafico.Visible = true;
                txtAno.Clear();
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado para o ano selecionado.");
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblEixoy.Text = "Nº de usuários";
            lblEixox.Text = "Id do plano";
            lblEixox.Visible = true;
            lblEixoy.Visible = true;
            lblTituloGrafico.Text = "Quantidade de usuários por plano";
            lblTituloGrafico.Visible = true;
            btnGerarGrafico.Visible = false;
            lblAno.Visible = false;
            txtAno.Visible = false;
            btnImprimir.Visible = true;
            btnDownload.Visible = true;


            chartFaturamento.Series.Clear();
            Series planoMaisAdquirido = new Series("PlanoMaisAdquirido");
            planoMaisAdquirido.ChartType = SeriesChartType.Column;
            chartFaturamento.Series.Add(planoMaisAdquirido);
            Dictionary<int, int> planoMais = caixaControl.ObterPlanoMaisAdquirido();
            PreencherGrafico2(planoMais);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string titulo = lblTituloGrafico.Text;
            Font fonteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fonteEixos = new Font("Arial", 10, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float posTituloX = e.MarginBounds.Left + (e.MarginBounds.Width / 2) - 150;
            float posTituloY = e.MarginBounds.Top + 5;
            float posEixoY = e.MarginBounds.Left + 10;
            float posEixoX = e.MarginBounds.Bottom - 700;

            e.Graphics.DrawString(titulo, fonteTitulo, brush, posTituloX, posTituloY);

            using (Bitmap bitmap = new Bitmap(chartFaturamento.Width, chartFaturamento.Height))
            {
                chartFaturamento.DrawToBitmap(bitmap, new Rectangle(0, 0, chartFaturamento.Width, chartFaturamento.Height));
                float posGraficoY = posTituloY + 40;
                e.Graphics.DrawImage(bitmap, e.MarginBounds.Left, posGraficoY);
            }

            e.Graphics.DrawString(lblEixox.Text, fonteEixos, brush, e.MarginBounds.Left + (e.MarginBounds.Width / 2) + 260, posEixoX); // Eixo X
            e.Graphics.DrawString(lblEixoy.Text, fonteEixos, brush, posEixoY, e.MarginBounds.Top + 40); // Eixo Y
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF File|*.pdf";
                saveFileDialog.Title = "Salvar gráfico como PDF";
                saveFileDialog.FileName = "Grafico.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Configure o PrintDocument para desenhar em uma imagem ao invés de na tela
                    Bitmap bitmap = new Bitmap(printDocument1.DefaultPageSettings.PaperSize.Width, printDocument1.DefaultPageSettings.PaperSize.Height);
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        Rectangle area = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                        printDocument1.PrintController = new System.Drawing.Printing.StandardPrintController();
                        printDocument1.PrintPage += (s, ev) => ev.Graphics.DrawImage(bitmap, area);

                        // Simula a impressão para capturar o conteúdo
                        printDocument1.Print();

                        using (var memoryStream = new MemoryStream())
                        {
                            bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                            memoryStream.Seek(0, SeekOrigin.Begin);

                            // Cria o documento PDF
                            using (var pdfDocument = new PdfSharp.Pdf.PdfDocument())
                            {
                                PdfSharp.Pdf.PdfPage pdfPage = pdfDocument.AddPage();
                                XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
                                XImage xImage = XImage.FromStream(memoryStream);

                                // Adiciona a imagem ao PDF
                                xGraphics.DrawImage(xImage, 0, 0, pdfPage.Width, pdfPage.Height);
                                try
                                {
                                    pdfDocument.Save(filePath);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("erro");
                                }
                            }
                        }

                        MessageBox.Show("Gráfico salvo como PDF com sucesso!");
                    }
                }
            }
        }
    }
}
