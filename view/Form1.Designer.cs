
namespace view
{
    partial class TrainnerBuddy1
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
            this.panelCabecalho1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMaximizar1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.btnEntrar1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblCadastro1 = new System.Windows.Forms.Label();
            this.panelCabecalho1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho1
            // 
            this.panelCabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(169)))), ((int)(((byte)(33)))));
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
            this.lblTitulo.Size = new System.Drawing.Size(356, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Login TrainnerBuddy";
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
            // txtUsuario1
            // 
            this.txtUsuario1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario1.Location = new System.Drawing.Point(272, 190);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(267, 26);
            this.txtUsuario1.TabIndex = 1;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha1.Location = new System.Drawing.Point(272, 288);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(267, 26);
            this.txtSenha1.TabIndex = 2;
            // 
            // btnEntrar1
            // 
            this.btnEntrar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEntrar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar1.FlatAppearance.BorderSize = 0;
            this.btnEntrar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEntrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar1.Location = new System.Drawing.Point(325, 335);
            this.btnEntrar1.Name = "btnEntrar1";
            this.btnEntrar1.Size = new System.Drawing.Size(158, 41);
            this.btnEntrar1.TabIndex = 5;
            this.btnEntrar1.Text = "Entrar";
            this.btnEntrar1.UseVisualStyleBackColor = false;
            this.btnEntrar1.Click += new System.EventHandler(this.btnEntrar1_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(369, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "E-mail";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(369, 245);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 25);
            this.label21.TabIndex = 7;
            this.label21.Text = "Senha";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(316, 389);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(109, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Não tem uma conta? ";
            // 
            // lblCadastro1
            // 
            this.lblCadastro1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadastro1.AutoSize = true;
            this.lblCadastro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro1.Location = new System.Drawing.Point(420, 389);
            this.lblCadastro1.Name = "lblCadastro1";
            this.lblCadastro1.Size = new System.Drawing.Size(63, 13);
            this.lblCadastro1.TabIndex = 10;
            this.lblCadastro1.Text = "Cadastre-se";
            this.lblCadastro1.Click += new System.EventHandler(this.lblCadastro1_Click);
            // 
            // TrainnerBuddy1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.lblCadastro1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEntrar1);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.panelCabecalho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainnerBuddy1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainnerBuddy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCabecalho1.ResumeLayout(false);
            this.panelCabecalho1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Button btnEntrar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblCadastro1;
    }
}

