namespace ScrapFII
{
    partial class frmPrincipal
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
            this.cmbListaFIIS = new System.Windows.Forms.ComboBox();
            this.lblNomeFii = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbListaFIIS
            // 
            this.cmbListaFIIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbListaFIIS.FormattingEnabled = true;
            this.cmbListaFIIS.Location = new System.Drawing.Point(51, 12);
            this.cmbListaFIIS.Name = "cmbListaFIIS";
            this.cmbListaFIIS.Size = new System.Drawing.Size(393, 26);
            this.cmbListaFIIS.TabIndex = 0;
            this.cmbListaFIIS.SelectedIndexChanged += new System.EventHandler(this.cmbListaFIIS_SelectedIndexChanged);
            // 
            // lblNomeFii
            // 
            this.lblNomeFii.AutoSize = true;
            this.lblNomeFii.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNomeFii.Location = new System.Drawing.Point(13, 15);
            this.lblNomeFii.Name = "lblNomeFii";
            this.lblNomeFii.Size = new System.Drawing.Size(23, 18);
            this.lblNomeFii.TabIndex = 1;
            this.lblNomeFii.Text = "FII";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 323);
            this.Controls.Add(this.lblNomeFii);
            this.Controls.Add(this.cmbListaFIIS);
            this.Name = "frmPrincipal";
            this.Text = "ScrapFII";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListaFIIS;
        private System.Windows.Forms.Label lblNomeFii;
    }
}

