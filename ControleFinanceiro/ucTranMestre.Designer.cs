namespace ControleFinanceiro
{
    partial class ucTranMestre
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.NumericUpDown();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbContaID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.gbNavegacao.SuspendLayout();
            this.gbModificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNavegacao
            // 
            this.gbNavegacao.Size = new System.Drawing.Size(348, 75);
            // 
            // gbModificacao
            // 
            this.gbModificacao.Size = new System.Drawing.Size(348, 71);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mês";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(197, 237);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(75, 20);
            this.txtAno.TabIndex = 56;
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(197, 184);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(124, 21);
            this.cbMes.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "ID da conta";
            // 
            // cbContaID
            // 
            this.cbContaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContaID.FormattingEnabled = true;
            this.cbContaID.Location = new System.Drawing.Point(13, 236);
            this.cbContaID.Name = "cbContaID";
            this.cbContaID.Size = new System.Drawing.Size(73, 21);
            this.cbContaID.TabIndex = 60;
            // 
            // ucTranMestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.cbContaID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.cbMes);
            this.Name = "ucTranMestre";
            this.Size = new System.Drawing.Size(362, 271);
            this.Load += new System.EventHandler(this.ucTranMestre_Load);
            this.Controls.SetChildIndex(this.gbNavegacao, 0);
            this.Controls.SetChildIndex(this.gbModificacao, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbMes, 0);
            this.Controls.SetChildIndex(this.txtAno, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbContaID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.gbNavegacao.ResumeLayout(false);
            this.gbModificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtAno;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbContaID;
    }
}
