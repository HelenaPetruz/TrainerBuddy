
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMaximizar1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFaturamentoMensal = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGerarGrafico = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.chartFaturamento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::view.Properties.Resources.MINIMIZAR;
            this.button1.Location = new System.Drawing.Point(592, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 50);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::view.Properties.Resources.maximizar1;
            this.button2.Location = new System.Drawing.Point(661, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 50);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnFaturamentoMensal);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 409);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(16, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Assinaturas por ano";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGerarGrafico);
            this.panel3.Controls.Add(this.lblAno);
            this.panel3.Controls.Add(this.txtAno);
            this.panel3.Controls.Add(this.chartFaturamento);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(188, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 409);
            this.panel3.TabIndex = 2;
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
            this.btnGerarGrafico.Location = new System.Drawing.Point(358, 41);
            this.btnGerarGrafico.Name = "btnGerarGrafico";
            this.btnGerarGrafico.Size = new System.Drawing.Size(231, 42);
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
            this.lblAno.Location = new System.Drawing.Point(120, 52);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(111, 20);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Digite o ano:";
            this.lblAno.Visible = false;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(226, 54);
            this.txtAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(128, 20);
            this.txtAno.TabIndex = 6;
            this.txtAno.Visible = false;
            // 
            // chartFaturamento
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFaturamento.ChartAreas.Add(chartArea1);
            this.chartFaturamento.Location = new System.Drawing.Point(18, 97);
            this.chartFaturamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartFaturamento.Name = "chartFaturamento";
            this.chartFaturamento.Size = new System.Drawing.Size(571, 254);
            this.chartFaturamento.TabIndex = 5;
            this.chartFaturamento.Text = "chartFaturamento";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(283, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Download";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(442, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Imprimir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gráficos para analisar o andamento do negócio!";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnFaturamentoMensal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFaturamento;
        private System.Windows.Forms.Button btnGerarGrafico;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
    }
}

