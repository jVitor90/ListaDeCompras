namespace ListaDeCompras
{
    partial class Form1
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
            this.LstbListaDeCompras = new System.Windows.Forms.ListBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtbCadastrar = new System.Windows.Forms.TextBox();
            this.LblAviso = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstbListaDeCompras
            // 
            this.LstbListaDeCompras.ForeColor = System.Drawing.Color.Black;
            this.LstbListaDeCompras.FormattingEnabled = true;
            this.LstbListaDeCompras.ItemHeight = 14;
            this.LstbListaDeCompras.Location = new System.Drawing.Point(12, 12);
            this.LstbListaDeCompras.Name = "LstbListaDeCompras";
            this.LstbListaDeCompras.Size = new System.Drawing.Size(573, 438);
            this.LstbListaDeCompras.TabIndex = 0;
            this.LstbListaDeCompras.DoubleClick += new System.EventHandler(this.LstbListaDeCompras_DoubleClick);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastrar.BackgroundImage = global::ListaDeCompras.Properties.Resources.Sem_Título_2;
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCadastrar.Location = new System.Drawing.Point(733, 91);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(252, 81);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.BackgroundImage = global::ListaDeCompras.Properties.Resources.Sem_Título_2;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpar.Location = new System.Drawing.Point(733, 205);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(252, 88);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "Limpar lista";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtbCadastrar
            // 
            this.TxtbCadastrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbCadastrar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbCadastrar.Location = new System.Drawing.Point(733, 44);
            this.TxtbCadastrar.Multiline = true;
            this.TxtbCadastrar.Name = "TxtbCadastrar";
            this.TxtbCadastrar.Size = new System.Drawing.Size(252, 18);
            this.TxtbCadastrar.TabIndex = 4;
            this.TxtbCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtbCadastrar_KeyDown_1);
            this.TxtbCadastrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbCadastrar_KeyPress);
            // 
            // LblAviso
            // 
            this.LblAviso.AutoSize = true;
            this.LblAviso.BackColor = System.Drawing.Color.White;
            this.LblAviso.ForeColor = System.Drawing.Color.Red;
            this.LblAviso.Location = new System.Drawing.Point(376, 425);
            this.LblAviso.Name = "LblAviso";
            this.LblAviso.Size = new System.Drawing.Size(199, 14);
            this.LblAviso.TabIndex = 5;
            this.LblAviso.Text = "Clique duas vezes para excluir algum item ";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.BackgroundImage = global::ListaDeCompras.Properties.Resources.Sem_Título_2;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Black;
            this.BtnSair.Location = new System.Drawing.Point(733, 325);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(252, 88);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ListaDeCompras.Properties.Resources.Fundolistadecompras4_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 485);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblAviso);
            this.Controls.Add(this.TxtbCadastrar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.LstbListaDeCompras);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstbListaDeCompras;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtbCadastrar;
        private System.Windows.Forms.Label LblAviso;
        private System.Windows.Forms.Button BtnSair;
    }
}

