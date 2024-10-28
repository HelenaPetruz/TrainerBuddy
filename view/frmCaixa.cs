using Control;
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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;

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

            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            caixaControl = new FaturamentoControl();

            dgCaixa.Columns.Add("id_faturamento", "ID");
            dgCaixa.Columns.Add("id_Usuario", "ID DO USUÁRIO");
            dgCaixa.Columns.Add("id_Plano", "ID DO PLANO");
            dgCaixa.Columns.Add("valor", "PREÇO DO PLANO");
            dgCaixa.Columns.Add("vencimento", "VENCIMENTO DO PAGAMENTO");
            dgCaixa.Columns.Add("data_compra", "DATA DA COMPRA");
            dgCaixa.Columns.Add("total", "SALDO FINAL");

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
            dgCaixa.Columns[0].ValueType = typeof(int);

            dgCaixa.Columns[1].Width = 100;
            dgCaixa.Columns[1].HeaderText = "ID DO USUÁRIO";
            dgCaixa.Columns[1].DataPropertyName = "id_Usuario";
            dgCaixa.Columns[1].ValueType = typeof(int);

            /* dgCaixa.Columns.Add("nome_plano", "NOME DO PLANO");
             dgCaixa.Columns[2].Width = 60;*/
            dgCaixa.Columns[2].Width = 80;
            dgCaixa.Columns[2].HeaderText = "ID DO PLANO";
            dgCaixa.Columns[2].DataPropertyName = "id_Plano";
            dgCaixa.Columns[2].ValueType = typeof(int);

            dgCaixa.Columns.Add("valor", "PREÇO DO PLANO");
            dgCaixa.Columns[3].Width = 120;

            dgCaixa.Columns[4].Width = 180;
            dgCaixa.Columns[4].HeaderText = "VENCIMENTO DO PAGAMENTO";
            dgCaixa.Columns[4].DataPropertyName = "vencimento";
            dgCaixa.Columns[4].ValueType = typeof(DateTime);

            dgCaixa.Columns[5].Width = 110;
            dgCaixa.Columns[5].HeaderText = "DATA DA COMPRA";
            dgCaixa.Columns[5].DataPropertyName = "data_compra";
            dgCaixa.Columns[5].ValueType = typeof(DateTime);

            dgCaixa.Columns.Add("total", "SALDO FINAL");
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

            //   NOME DO PLANO
            /*for (cont = 0; cont < dgCaixa.Rows.Count; cont++)
            {
                object valorCell = dgCaixa.Rows[cont].Cells[2].Value;
                int id_plano = Convert.ToInt32(valorCell);
                dgCaixa.Rows[cont].Cells[2].Value = caixaControl.getNomePlano(id_plano);
            }*/

            //   PREÇO DO PLANO
            for (cont = 0; cont < dgCaixa.Rows.Count; cont++)
            {
                object valorCell = dgCaixa.Rows[cont].Cells[2].Value;
                int id_plano = Convert.ToInt32(valorCell);
                dgCaixa.Rows[cont].Cells[3].Value = caixaControl.getPrice(id_plano);
            }

            //   TOTAL
            for (cont = 0; cont < dgCaixa.Rows.Count; cont++)
            {
                object valorCell = dgCaixa.Rows[cont].Cells[3].Value;
                if (cont == 1 || cont == 0)
                {
                    dgCaixa.Rows[cont].Cells[6].Value = valorCell;
                }
                else
                {
                    double preco = Convert.ToDouble(valorCell);
                    object totalAnterior = dgCaixa.Rows[cont - 1].Cells[6].Value;
                    double saldoAnterior = Convert.ToDouble(totalAnterior);
                    double total = saldoAnterior + preco;
                    dgCaixa.Rows[cont].Cells[6].Value = total;
                }
            }

            dgCaixa.Refresh();
        }

        private void dgCaixa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ocorreu um erro ao exibir os dados: " + e.Exception.Message, "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmGrafico frm = new frmGrafico();
            this.Close();
            frm.Show();
        }
        Bitmap bitmap;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Defina o documento a ser impresso
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int alturaLinha = 0;
            int alturaPagina = e.MarginBounds.Top;
            int margemEsquerda = e.MarginBounds.Left;
            int margemDireita = e.MarginBounds.Right;
            bool maisPaginas = false;

            Pen canetaBorda = new Pen(Color.Black); // Para desenhar as bordas

            // Desenhar cabeçalho do DataGridView
            foreach (DataGridViewColumn coluna in dgCaixa.Columns)
            {
                // Desenhar texto do cabeçalho
                e.Graphics.DrawString(coluna.HeaderText, dgCaixa.Font, Brushes.Black, margemEsquerda, alturaPagina);

                // Desenhar borda em torno do cabeçalho
                e.Graphics.DrawRectangle(canetaBorda, new Rectangle(margemEsquerda, alturaPagina, coluna.Width, dgCaixa.ColumnHeadersHeight));

                margemEsquerda += coluna.Width;
            }

            // Resetar a margem esquerda
            margemEsquerda = e.MarginBounds.Left;
            alturaPagina += dgCaixa.ColumnHeadersHeight;

            // Desenhar as linhas do DataGridView
            foreach (DataGridViewRow linha in dgCaixa.Rows)
            {
                alturaLinha = linha.Height;

                // Verificar se a linha cabe na página
                if (alturaPagina + alturaLinha >= e.MarginBounds.Bottom)
                {
                    maisPaginas = true;
                    break;
                }

                foreach (DataGridViewCell celula in linha.Cells)
                {
                    // Desenhar o conteúdo da célula
                    e.Graphics.DrawString(celula.Value?.ToString(), dgCaixa.Font, Brushes.Black, margemEsquerda, alturaPagina);

                    // Desenhar a borda da célula
                    e.Graphics.DrawRectangle(canetaBorda, new Rectangle(margemEsquerda, alturaPagina, dgCaixa.Columns[celula.ColumnIndex].Width, alturaLinha));

                    margemEsquerda += dgCaixa.Columns[celula.ColumnIndex].Width;
                }

                // Resetar a margem esquerda para a próxima linha
                margemEsquerda = e.MarginBounds.Left;
                alturaPagina += alturaLinha;
            }

            // Se ainda houver mais linhas para imprimir
            e.HasMorePages = maisPaginas;
        }

        private Bitmap CapturarDataGridComoImagem()
        {
            Bitmap imagem = new Bitmap(dgCaixa.Width, dgCaixa.Height);
            dgCaixa.DrawToBitmap(imagem, new Rectangle(0, 0, dgCaixa.Width, dgCaixa.Height));
            return imagem;
        }

        private void SalvarPDFdoDataGridView(Bitmap imagemDataGrid, string caminhoArquivo)
        {
            using (PdfDocument documentoPDF = new PdfDocument())
            {
                PdfPage pagina = documentoPDF.AddPage();
                pagina.Width = imagemDataGrid.Width;
                pagina.Height = imagemDataGrid.Height;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Converte o Bitmap para o formato de stream (PNG)
                    imagemDataGrid.Save(memoryStream, ImageFormat.Png);
                    memoryStream.Seek(0, SeekOrigin.Begin);

                    using (XGraphics grafico = XGraphics.FromPdfPage(pagina))
                    {
                        XImage imagemX = XImage.FromStream(memoryStream);
                        grafico.DrawImage(imagemX, 0, 0, pagina.Width, pagina.Height);
                    }
                }

                documentoPDF.Save(caminhoArquivo);
            }

            MessageBox.Show("PDF do DataGridView salvo com sucesso!");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarDialogo = new SaveFileDialog
            {
                Filter = "Arquivo PDF (*.pdf)|*.pdf",
                FileName = "DataGridViewExport.pdf"
            };

            if (salvarDialogo.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagemDataGrid = CapturarDataGridComoImagem();
                SalvarPDFdoDataGridView(imagemDataGrid, salvarDialogo.FileName);
            }
        }
    }
}