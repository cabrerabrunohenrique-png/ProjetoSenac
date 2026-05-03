namespace ProjetoSenac
{
    partial class FormEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPaginaIncialE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPaginaIncialE
            // 
            this.btPaginaIncialE.Location = new System.Drawing.Point(617, 335);
            this.btPaginaIncialE.Name = "btPaginaIncialE";
            this.btPaginaIncialE.Size = new System.Drawing.Size(142, 72);
            this.btPaginaIncialE.TabIndex = 0;
            this.btPaginaIncialE.Text = "Voltar para Pagina Inicial";
            this.btPaginaIncialE.UseVisualStyleBackColor = true;
            this.btPaginaIncialE.Click += new System.EventHandler(this.btPaginaIncialE_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPaginaIncialE);
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPaginaIncialE;
    }
}