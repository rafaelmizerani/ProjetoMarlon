namespace Projeto_Marlon
{
    partial class frmConversao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversao));
            this.btnConversao = new System.Windows.Forms.Button();
            this.gboNumeroEBase = new System.Windows.Forms.GroupBox();
            this.nmrBaseInicial = new System.Windows.Forms.NumericUpDown();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.gboNumeroEBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBaseInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConversao
            // 
            this.btnConversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversao.Location = new System.Drawing.Point(49, 130);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(175, 55);
            this.btnConversao.TabIndex = 2;
            this.btnConversao.Text = "Converter";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // gboNumeroEBase
            // 
            this.gboNumeroEBase.Controls.Add(this.nmrBaseInicial);
            this.gboNumeroEBase.Controls.Add(this.txtEntrada);
            this.gboNumeroEBase.Location = new System.Drawing.Point(13, 13);
            this.gboNumeroEBase.Name = "gboNumeroEBase";
            this.gboNumeroEBase.Size = new System.Drawing.Size(267, 101);
            this.gboNumeroEBase.TabIndex = 3;
            this.gboNumeroEBase.TabStop = false;
            this.gboNumeroEBase.Text = "Número Base";
            // 
            // nmrBaseInicial
            // 
            this.nmrBaseInicial.Location = new System.Drawing.Point(199, 45);
            this.nmrBaseInicial.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmrBaseInicial.Name = "nmrBaseInicial";
            this.nmrBaseInicial.Size = new System.Drawing.Size(53, 20);
            this.nmrBaseInicial.TabIndex = 3;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(14, 35);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(165, 30);
            this.txtEntrada.TabIndex = 2;
            // 
            // frmConversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 223);
            this.Controls.Add(this.gboNumeroEBase);
            this.Controls.Add(this.btnConversao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConversao";
            this.Text = "Conversão de Base";
            this.gboNumeroEBase.ResumeLayout(false);
            this.gboNumeroEBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBaseInicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConversao;
        private System.Windows.Forms.GroupBox gboNumeroEBase;
        private System.Windows.Forms.NumericUpDown nmrBaseInicial;
        private System.Windows.Forms.TextBox txtEntrada;
    }
}

