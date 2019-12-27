namespace ControleFinanceiro
{
    partial class ucConta
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.gbNavegacao.SuspendLayout();
            this.gbModificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // gbNavegacao
            // 
            this.gbNavegacao.Size = new System.Drawing.Size(452, 75);
            // 
            // gbModificacao
            // 
            this.gbModificacao.Size = new System.Drawing.Size(452, 71);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 219);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 55;
            this.lblNome.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tipo de conta";
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Location = new System.Drawing.Point(13, 293);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(148, 21);
            this.cbTipoConta.TabIndex = 58;
            // 
            // cbBanco
            // 
            this.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(12, 235);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(149, 21);
            this.cbBanco.TabIndex = 62;
            // 
            // ucConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.cbTipoConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Name = "ucConta";
            this.Size = new System.Drawing.Size(459, 333);
            this.Load += new System.EventHandler(this.ucBanco_Load);
            this.Controls.SetChildIndex(this.gbNavegacao, 0);
            this.Controls.SetChildIndex(this.gbModificacao, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbTipoConta, 0);
            this.Controls.SetChildIndex(this.cbBanco, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.gbNavegacao.ResumeLayout(false);
            this.gbModificacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoConta;
        private System.Windows.Forms.ComboBox cbBanco;
    }
}
