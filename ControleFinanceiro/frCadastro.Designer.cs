namespace ControleFinanceiro
{
    partial class frCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.ucUsuario1 = new ControleFinanceiro.ucUsuario();
            this.tpBanco = new System.Windows.Forms.TabPage();
            this.ucBanco1 = new ControleFinanceiro.ucBanco();
            this.tpTipoConta = new System.Windows.Forms.TabPage();
            this.ucTipoConta1 = new ControleFinanceiro.ucTipoConta();
            this.tpCatGastos = new System.Windows.Forms.TabPage();
            this.ucCatGastos1 = new ControleFinanceiro.ucCatGastos();
            this.tabControl1.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            this.tpBanco.SuspendLayout();
            this.tpTipoConta.SuspendLayout();
            this.tpCatGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUsuario);
            this.tabControl1.Controls.Add(this.tpBanco);
            this.tabControl1.Controls.Add(this.tpTipoConta);
            this.tabControl1.Controls.Add(this.tpCatGastos);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpUsuario
            // 
            this.tpUsuario.BackColor = System.Drawing.Color.Yellow;
            this.tpUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpUsuario.Controls.Add(this.ucUsuario1);
            this.tpUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(472, 400);
            this.tpUsuario.TabIndex = 0;
            this.tpUsuario.Text = "Usuário";
            // 
            // ucUsuario1
            // 
            this.ucUsuario1.BackColor = System.Drawing.Color.Yellow;
            this.ucUsuario1.Location = new System.Drawing.Point(6, 6);
            this.ucUsuario1.Name = "ucUsuario1";
            this.ucUsuario1.Size = new System.Drawing.Size(459, 386);
            this.ucUsuario1.SugereProximoId = false;
            this.ucUsuario1.TabIndex = 0;
            this.ucUsuario1.Load += new System.EventHandler(this.ucUsuario1_Load);
            // 
            // tpBanco
            // 
            this.tpBanco.BackColor = System.Drawing.Color.Yellow;
            this.tpBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBanco.Controls.Add(this.ucBanco1);
            this.tpBanco.Location = new System.Drawing.Point(4, 22);
            this.tpBanco.Name = "tpBanco";
            this.tpBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanco.Size = new System.Drawing.Size(472, 400);
            this.tpBanco.TabIndex = 1;
            this.tpBanco.Text = "Banco";
            // 
            // ucBanco1
            // 
            this.ucBanco1.BackColor = System.Drawing.Color.Yellow;
            this.ucBanco1.Location = new System.Drawing.Point(6, 6);
            this.ucBanco1.Name = "ucBanco1";
            this.ucBanco1.Size = new System.Drawing.Size(456, 231);
            this.ucBanco1.SugereProximoId = false;
            this.ucBanco1.TabIndex = 0;
            // 
            // tpTipoConta
            // 
            this.tpTipoConta.BackColor = System.Drawing.Color.Yellow;
            this.tpTipoConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpTipoConta.Controls.Add(this.ucTipoConta1);
            this.tpTipoConta.Location = new System.Drawing.Point(4, 22);
            this.tpTipoConta.Name = "tpTipoConta";
            this.tpTipoConta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTipoConta.Size = new System.Drawing.Size(472, 400);
            this.tpTipoConta.TabIndex = 3;
            this.tpTipoConta.Text = "Tipo de conta";
            // 
            // ucTipoConta1
            // 
            this.ucTipoConta1.BackColor = System.Drawing.Color.Yellow;
            this.ucTipoConta1.Location = new System.Drawing.Point(6, 6);
            this.ucTipoConta1.Name = "ucTipoConta1";
            this.ucTipoConta1.Size = new System.Drawing.Size(463, 386);
            this.ucTipoConta1.SugereProximoId = false;
            this.ucTipoConta1.TabIndex = 0;
            // 
            // tpCatGastos
            // 
            this.tpCatGastos.BackColor = System.Drawing.Color.Yellow;
            this.tpCatGastos.Controls.Add(this.ucCatGastos1);
            this.tpCatGastos.Location = new System.Drawing.Point(4, 22);
            this.tpCatGastos.Name = "tpCatGastos";
            this.tpCatGastos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCatGastos.Size = new System.Drawing.Size(472, 400);
            this.tpCatGastos.TabIndex = 4;
            this.tpCatGastos.Text = "Categoria de Gastos";
            // 
            // ucCatGastos1
            // 
            this.ucCatGastos1.BackColor = System.Drawing.Color.Yellow;
            this.ucCatGastos1.Location = new System.Drawing.Point(4, 7);
            this.ucCatGastos1.Name = "ucCatGastos1";
            this.ucCatGastos1.Size = new System.Drawing.Size(461, 231);
            this.ucCatGastos1.SugereProximoId = false;
            this.ucCatGastos1.TabIndex = 0;
            // 
            // frCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(481, 430);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frCadastro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            this.tpBanco.ResumeLayout(false);
            this.tpTipoConta.ResumeLayout(false);
            this.tpCatGastos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUsuario;
        private System.Windows.Forms.TabPage tpBanco;
        private System.Windows.Forms.TabPage tpTipoConta;
        private ucUsuario ucUsuario1;
        private ucBanco ucBanco1;
        private ucTipoConta ucTipoConta1;
        private System.Windows.Forms.TabPage tpCatGastos;
        private ucCatGastos ucCatGastos1;
    }
}