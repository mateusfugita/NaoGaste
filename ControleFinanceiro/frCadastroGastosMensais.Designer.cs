namespace ControleFinanceiro
{
    partial class frCadastroGastosMensais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastroGastosMensais));
            this.ucGastosMensais1 = new ControleFinanceiro.ucGastosMensais();
            this.SuspendLayout();
            // 
            // ucGastosMensais1
            // 
            this.ucGastosMensais1.BackColor = System.Drawing.Color.Yellow;
            this.ucGastosMensais1.Location = new System.Drawing.Point(0, -81);
            this.ucGastosMensais1.Name = "ucGastosMensais1";
            this.ucGastosMensais1.Size = new System.Drawing.Size(466, 274);
            this.ucGastosMensais1.SugereProximoId = false;
            this.ucGastosMensais1.TabIndex = 0;
            // 
            // frCadastroGastosMensais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 190);
            this.Controls.Add(this.ucGastosMensais1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frCadastroGastosMensais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Gastos Mensais";
            this.Load += new System.EventHandler(this.frCadastroGastosMensais_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucGastosMensais ucGastosMensais1;
    }
}