namespace ControleFinanceiro
{
    partial class frConsultaTransacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConsultaTransacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApagarMestre = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCatGastos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgMestre = new System.Windows.Forms.DataGridView();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbContaID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgDetalhe = new System.Windows.Forms.DataGridView();
            this.btnApagarDetalhe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApagarMestre);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbCatGastos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgMestre);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.cbContaID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mestre";
            // 
            // btnApagarMestre
            // 
            this.btnApagarMestre.BackColor = System.Drawing.Color.Black;
            this.btnApagarMestre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarMestre.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarMestre.ForeColor = System.Drawing.Color.Yellow;
            this.btnApagarMestre.Location = new System.Drawing.Point(499, 83);
            this.btnApagarMestre.Name = "btnApagarMestre";
            this.btnApagarMestre.Size = new System.Drawing.Size(93, 73);
            this.btnApagarMestre.TabIndex = 77;
            this.btnApagarMestre.Text = "Apagar";
            this.btnApagarMestre.UseVisualStyleBackColor = false;
            this.btnApagarMestre.Click += new System.EventHandler(this.btnApagarMestre_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Yellow;
            this.btnPesquisar.Location = new System.Drawing.Point(499, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 42);
            this.btnPesquisar.TabIndex = 75;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Categoria de gastos";
            // 
            // cbCatGastos
            // 
            this.cbCatGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatGastos.FormattingEnabled = true;
            this.cbCatGastos.Location = new System.Drawing.Point(367, 36);
            this.cbCatGastos.Name = "cbCatGastos";
            this.cbCatGastos.Size = new System.Drawing.Size(121, 21);
            this.cbCatGastos.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Mês";
            // 
            // dgMestre
            // 
            this.dgMestre.AllowUserToAddRows = false;
            this.dgMestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMestre.Location = new System.Drawing.Point(6, 71);
            this.dgMestre.Name = "dgMestre";
            this.dgMestre.ReadOnly = true;
            this.dgMestre.Size = new System.Drawing.Size(482, 96);
            this.dgMestre.TabIndex = 0;
            this.dgMestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgMestre_KeyPress);
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
            this.cbMes.Location = new System.Drawing.Point(114, 36);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(124, 21);
            this.cbMes.TabIndex = 73;
            // 
            // cbContaID
            // 
            this.cbContaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContaID.FormattingEnabled = true;
            this.cbContaID.Location = new System.Drawing.Point(19, 36);
            this.cbContaID.Name = "cbContaID";
            this.cbContaID.Size = new System.Drawing.Size(73, 21);
            this.cbContaID.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID da conta";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(270, 37);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(75, 20);
            this.txtAno.TabIndex = 69;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgDetalhe);
            this.groupBox2.Controls.Add(this.btnApagarDetalhe);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhe";
            // 
            // dgDetalhe
            // 
            this.dgDetalhe.AllowUserToAddRows = false;
            this.dgDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalhe.Location = new System.Drawing.Point(6, 19);
            this.dgDetalhe.Name = "dgDetalhe";
            this.dgDetalhe.ReadOnly = true;
            this.dgDetalhe.Size = new System.Drawing.Size(482, 97);
            this.dgDetalhe.TabIndex = 1;
            // 
            // btnApagarDetalhe
            // 
            this.btnApagarDetalhe.BackColor = System.Drawing.Color.Black;
            this.btnApagarDetalhe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarDetalhe.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarDetalhe.ForeColor = System.Drawing.Color.Yellow;
            this.btnApagarDetalhe.Location = new System.Drawing.Point(494, 30);
            this.btnApagarDetalhe.Name = "btnApagarDetalhe";
            this.btnApagarDetalhe.Size = new System.Drawing.Size(93, 71);
            this.btnApagarDetalhe.TabIndex = 76;
            this.btnApagarDetalhe.Text = "Apagar";
            this.btnApagarDetalhe.UseVisualStyleBackColor = false;
            this.btnApagarDetalhe.Click += new System.EventHandler(this.btnApagarDetalhe_Click);
            // 
            // frConsultaTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(622, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frConsultaTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Transação";
            this.Load += new System.EventHandler(this.frConsultaTransacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalhe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgMestre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgDetalhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbContaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCatGastos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnApagarMestre;
        private System.Windows.Forms.Button btnApagarDetalhe;
    }
}