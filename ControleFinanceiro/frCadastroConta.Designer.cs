﻿namespace ControleFinanceiro
{
    partial class frCadastroConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastroConta));
            this.ucConta1 = new ControleFinanceiro.ucConta();
            this.SuspendLayout();
            // 
            // ucConta1
            // 
            this.ucConta1.BackColor = System.Drawing.Color.Yellow;
            this.ucConta1.Location = new System.Drawing.Point(0, -80);
            this.ucConta1.Name = "ucConta1";
            this.ucConta1.Size = new System.Drawing.Size(459, 333);
            this.ucConta1.SugereProximoId = false;
            this.ucConta1.TabIndex = 0;
            // 
            // frCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 251);
            this.Controls.Add(this.ucConta1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frCadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Conta";
            this.Load += new System.EventHandler(this.frCadastroConta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucConta ucConta1;
    }
}