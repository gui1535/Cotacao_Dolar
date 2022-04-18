namespace CotacaoDolar
{
    partial class FormCotacaoDolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCotacaoDolar));
            this.lbDolar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lbCompra = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.lbVariacao = new System.Windows.Forms.Label();
            this.lbMstCompra = new System.Windows.Forms.Label();
            this.lbMstVenda = new System.Windows.Forms.Label();
            this.lbMsrVariacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDolar
            // 
            this.lbDolar.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbDolar.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lbDolar.ForeColor = System.Drawing.Color.Transparent;
            this.lbDolar.Location = new System.Drawing.Point(-2, 0);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(603, 103);
            this.lbDolar.TabIndex = 0;
            this.lbDolar.Text = "Dólar";
            this.lbDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(356, 398);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 57);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompra.Location = new System.Drawing.Point(57, 167);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(134, 34);
            this.lbCompra.TabIndex = 2;
            this.lbCompra.Text = "Compra:";
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenda.Location = new System.Drawing.Point(57, 243);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(114, 34);
            this.lbVenda.TabIndex = 3;
            this.lbVenda.Text = "Venda:";
            // 
            // lbVariacao
            // 
            this.lbVariacao.AutoSize = true;
            this.lbVariacao.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVariacao.Location = new System.Drawing.Point(57, 327);
            this.lbVariacao.Name = "lbVariacao";
            this.lbVariacao.Size = new System.Drawing.Size(149, 34);
            this.lbVariacao.TabIndex = 4;
            this.lbVariacao.Text = "Variação:";
            // 
            // lbMstCompra
            // 
            this.lbMstCompra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbMstCompra.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMstCompra.ForeColor = System.Drawing.Color.Black;
            this.lbMstCompra.Location = new System.Drawing.Point(219, 159);
            this.lbMstCompra.Name = "lbMstCompra";
            this.lbMstCompra.Size = new System.Drawing.Size(287, 52);
            this.lbMstCompra.TabIndex = 5;
            this.lbMstCompra.Text = "0,0";
            this.lbMstCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMstVenda
            // 
            this.lbMstVenda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbMstVenda.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMstVenda.ForeColor = System.Drawing.Color.Black;
            this.lbMstVenda.Location = new System.Drawing.Point(219, 233);
            this.lbMstVenda.Name = "lbMstVenda";
            this.lbMstVenda.Size = new System.Drawing.Size(287, 52);
            this.lbMstVenda.TabIndex = 6;
            this.lbMstVenda.Text = "0,0";
            this.lbMstVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMsrVariacao
            // 
            this.lbMsrVariacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbMsrVariacao.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsrVariacao.ForeColor = System.Drawing.Color.Black;
            this.lbMsrVariacao.Location = new System.Drawing.Point(219, 318);
            this.lbMsrVariacao.Name = "lbMsrVariacao";
            this.lbMsrVariacao.Size = new System.Drawing.Size(287, 52);
            this.lbMsrVariacao.TabIndex = 7;
            this.lbMsrVariacao.Text = "0,0";
            this.lbMsrVariacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 478);
            this.Controls.Add(this.lbMsrVariacao);
            this.Controls.Add(this.lbMstVenda);
            this.Controls.Add(this.lbMstCompra);
            this.Controls.Add(this.lbVariacao);
            this.Controls.Add(this.lbVenda);
            this.Controls.Add(this.lbCompra);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lbDolar);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lbCompra;
        private System.Windows.Forms.Label lbVenda;
        private System.Windows.Forms.Label lbVariacao;
        private System.Windows.Forms.Label lbMstCompra;
        private System.Windows.Forms.Label lbMstVenda;
        private System.Windows.Forms.Label lbMsrVariacao;
    }
}

