
namespace view
{
    partial class frmGrafico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafico));
            this.panelCabecalho1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMaximizar1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFaturamentoMensal = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTituloGrafico = new System.Windows.Forms.Label();
            this.lblEixox = new System.Windows.Forms.Label();
            this.lblEixoy = new System.Windows.Forms.Label();
            this.btnGerarGrafico = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartFaturamento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelCabecalho1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho1
            // 
            this.panelCabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(169)))), ((int)(((byte)(33)))));
            this.panelCabecalho1.Controls.Add(this.panel1);
            this.panelCabecalho1.Controls.Add(this.btnMinimizar);
            this.panelCabecalho1.Controls.Add(this.lblTitulo);
            this.panelCabecalho1.Controls.Add(this.btnMaximizar1);
            this.panelCabecalho1.Controls.Add(this.btnFechar);
            this.panelCabecalho1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho1.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho1.Name = "panelCabecalho1";
            this.panelCabecalho1.Size = new System.Drawing.Size(800, 72);
            this.panelCabecalho1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(169)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::view.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(3, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(63, 50);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerar gráficos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = global::view.Properties.Resources.fechar3;
            this.btn_fechar.Location = new System.Drawing.Point(730, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(58, 50);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::view.Properties.Resources.MINIMIZAR;
            this.btnMinimizar.Location = new System.Drawing.Point(592, 14);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(63, 50);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(60, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "TrainnerBuddy";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnMaximizar1
            // 
            this.btnMaximizar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar1.FlatAppearance.BorderSize = 0;
            this.btnMaximizar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar1.Image = global::view.Properties.Resources.maximizar1;
            this.btnMaximizar1.Location = new System.Drawing.Point(661, 12);
            this.btnMaximizar1.Name = "btnMaximizar1";
            this.btnMaximizar1.Size = new System.Drawing.Size(63, 50);
            this.btnMaximizar1.TabIndex = 2;
            this.btnMaximizar1.UseVisualStyleBackColor = true;
            this.btnMaximizar1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::view.Properties.Resources.fechar3;
            this.btnFechar.Location = new System.Drawing.Point(730, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(58, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnFaturamentoMensal);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 409);
            this.panel2.TabIndex = 1;
            // 
            // btnFaturamentoMensal
            // 
            this.btnFaturamentoMensal.FlatAppearance.BorderSize = 0;
            this.btnFaturamentoMensal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFaturamentoMensal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnFaturamentoMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturamentoMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturamentoMensal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFaturamentoMensal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturamentoMensal.Location = new System.Drawing.Point(10, 6);
            this.btnFaturamentoMensal.Name = "btnFaturamentoMensal";
            this.btnFaturamentoMensal.Size = new System.Drawing.Size(170, 60);
            this.btnFaturamentoMensal.TabIndex = 1;
            this.btnFaturamentoMensal.Text = "Faturamento mensal";
            this.btnFaturamentoMensal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFaturamentoMensal.UseVisualStyleBackColor = true;
            this.btnFaturamentoMensal.Click += new System.EventHandler(this.btnFaturamentoMensal_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(10, 73);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(170, 57);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Plano mais adquirido";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTituloGrafico);
            this.panel3.Controls.Add(this.lblEixox);
            this.panel3.Controls.Add(this.lblEixoy);
            this.panel3.Controls.Add(this.btnGerarGrafico);
            this.panel3.Controls.Add(this.lblAno);
            this.panel3.Controls.Add(this.txtAno);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.chartFaturamento);
            this.panel3.Controls.Add(this.btnDownload);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(188, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 409);
            this.panel3.TabIndex = 2;
            // 
            // lblTituloGrafico
            // 
            this.lblTituloGrafico.AutoSize = true;
            this.lblTituloGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrafico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloGrafico.Location = new System.Drawing.Point(172, 74);
            this.lblTituloGrafico.Name = "lblTituloGrafico";
            this.lblTituloGrafico.Size = new System.Drawing.Size(143, 20);
            this.lblTituloGrafico.TabIndex = 11;
            this.lblTituloGrafico.Text = "Título do gráfico:";
            this.lblTituloGrafico.Visible = false;
            // 
            // lblEixox
            // 
            this.lblEixox.AutoSize = true;
            this.lblEixox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEixox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEixox.Location = new System.Drawing.Point(511, 322);
            this.lblEixox.Name = "lblEixox";
            this.lblEixox.Size = new System.Drawing.Size(54, 17);
            this.lblEixox.TabIndex = 10;
            this.lblEixox.Text = "Meses";
            this.lblEixox.Visible = false;
            // 
            // lblEixoy
            // 
            this.lblEixoy.AutoSize = true;
            this.lblEixoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEixoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEixoy.Location = new System.Drawing.Point(23, 102);
            this.lblEixoy.Name = "lblEixoy";
            this.lblEixoy.Size = new System.Drawing.Size(150, 17);
            this.lblEixoy.TabIndex = 9;
            this.lblEixoy.Text = "Faturamento em R$";
            this.lblEixoy.Visible = false;
            // 
            // btnGerarGrafico
            // 
            this.btnGerarGrafico.FlatAppearance.BorderSize = 0;
            this.btnGerarGrafico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGerarGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnGerarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarGrafico.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarGrafico.Location = new System.Drawing.Point(357, 36);
            this.btnGerarGrafico.Name = "btnGerarGrafico";
            this.btnGerarGrafico.Size = new System.Drawing.Size(136, 29);
            this.btnGerarGrafico.TabIndex = 8;
            this.btnGerarGrafico.Text = "Gerar gráfico";
            this.btnGerarGrafico.UseVisualStyleBackColor = true;
            this.btnGerarGrafico.Visible = false;
            this.btnGerarGrafico.Click += new System.EventHandler(this.btnGerarGrafico_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAno.Location = new System.Drawing.Point(110, 41);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(111, 20);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Digite o ano:";
            this.lblAno.Visible = false;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(224, 41);
            this.txtAno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(128, 20);
            this.txtAno.TabIndex = 6;
            this.txtAno.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(101, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gráficos para analisar o andamento do negócio!";
            // 
            // chartFaturamento
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFaturamento.ChartAreas.Add(chartArea1);
            this.chartFaturamento.Location = new System.Drawing.Point(18, 96);
            this.chartFaturamento.Margin = new System.Windows.Forms.Padding(2);
            this.chartFaturamento.Name = "chartFaturamento";
            this.chartFaturamento.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chartFaturamento.Size = new System.Drawing.Size(571, 251);
            this.chartFaturamento.TabIndex = 5;
            this.chartFaturamento.Text = "chartFaturamento";
            // 
            // btnDownload
            // 
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(283, 352);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(153, 51);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(442, 352);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 51);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCabecalho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainnerBuddy";
            this.Load += new System.EventHandler(this.frmGrafico_Load);
            this.panelCabecalho1.ResumeLayout(false);
            this.panelCabecalho1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaturamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnFaturamentoMensal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFaturamento;
        private System.Windows.Forms.Button btnGerarGrafico;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblEixox;
        private System.Windows.Forms.Label lblEixoy;
        private System.Windows.Forms.Label lblTituloGrafico;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

