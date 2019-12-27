namespace ControleFinanceiro
{
    partial class ucEntrar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.gbNavegacao.SuspendLayout();
            this.gbModificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucEntrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Name = "ucEntrar";
            this.Size = new System.Drawing.Size(465, 261);
            this.Load += new System.EventHandler(this.ucEntrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.gbNavegacao.ResumeLayout(false);
            this.gbModificacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
