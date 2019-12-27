namespace ControleFinanceiro
{
    partial class frTransacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarGastosMensais = new System.Windows.Forms.Button();
            this.dgGastosMensais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbContaID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCatGastos = new System.Windows.Forms.ComboBox();
            this.txtDia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.dgMinhasContas = new System.Windows.Forms.DataGridView();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarTP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGastosMensais)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDia)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMinhasContas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastrarGastosMensais);
            this.groupBox1.Controls.Add(this.dgGastosMensais);
            this.groupBox1.Location = new System.Drawing.Point(420, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lembrete do mês";
            // 
            // btnCadastrarGastosMensais
            // 
            this.btnCadastrarGastosMensais.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarGastosMensais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarGastosMensais.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarGastosMensais.ForeColor = System.Drawing.Color.Yellow;
            this.btnCadastrarGastosMensais.Location = new System.Drawing.Point(147, 175);
            this.btnCadastrarGastosMensais.Name = "btnCadastrarGastosMensais";
            this.btnCadastrarGastosMensais.Size = new System.Drawing.Size(112, 23);
            this.btnCadastrarGastosMensais.TabIndex = 60;
            this.btnCadastrarGastosMensais.Text = "Cadastrar";
            this.btnCadastrarGastosMensais.UseVisualStyleBackColor = false;
            this.btnCadastrarGastosMensais.Click += new System.EventHandler(this.btnCadastrarGastosMensais_Click);
            // 
            // dgGastosMensais
            // 
            this.dgGastosMensais.AllowUserToAddRows = false;
            this.dgGastosMensais.AllowUserToDeleteRows = false;
            this.dgGastosMensais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGastosMensais.Location = new System.Drawing.Point(7, 19);
            this.dgGastosMensais.Name = "dgGastosMensais";
            this.dgGastosMensais.ReadOnly = true;
            this.dgGastosMensais.Size = new System.Drawing.Size(355, 137);
            this.dgGastosMensais.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbMes);
            this.groupBox2.Controls.Add(this.cbContaID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mês";
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
            this.cbMes.Location = new System.Drawing.Point(112, 37);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(124, 21);
            this.cbMes.TabIndex = 67;
            // 
            // cbContaID
            // 
            this.cbContaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContaID.FormattingEnabled = true;
            this.cbContaID.Location = new System.Drawing.Point(17, 37);
            this.cbContaID.Name = "cbContaID";
            this.cbContaID.Size = new System.Drawing.Size(73, 21);
            this.cbContaID.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "ID da conta";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(268, 38);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(75, 20);
            this.txtAno.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Ano";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtDescricao);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbCatGastos);
            this.groupBox3.Controls.Add(this.txtDia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(18, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 164);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(125, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(163, 20);
            this.txtDescricao.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 89);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Categoria de gastos";
            // 
            // cbCatGastos
            // 
            this.cbCatGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatGastos.FormattingEnabled = true;
            this.cbCatGastos.Location = new System.Drawing.Point(189, 88);
            this.cbCatGastos.Name = "cbCatGastos";
            this.cbCatGastos.Size = new System.Drawing.Size(121, 21);
            this.cbCatGastos.TabIndex = 1;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(15, 37);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(62, 20);
            this.txtDia.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Dia";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAtualizarTP);
            this.groupBox4.Controls.Add(this.btnCadastrarConta);
            this.groupBox4.Controls.Add(this.dgMinhasContas);
            this.groupBox4.Location = new System.Drawing.Point(420, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 225);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minhas contas";
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarConta.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConta.ForeColor = System.Drawing.Color.Yellow;
            this.btnCadastrarConta.Location = new System.Drawing.Point(49, 176);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(112, 43);
            this.btnCadastrarConta.TabIndex = 61;
            this.btnCadastrarConta.Text = "Cadastrar";
            this.btnCadastrarConta.UseVisualStyleBackColor = false;
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // dgMinhasContas
            // 
            this.dgMinhasContas.AllowUserToAddRows = false;
            this.dgMinhasContas.AllowUserToDeleteRows = false;
            this.dgMinhasContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMinhasContas.Location = new System.Drawing.Point(7, 20);
            this.dgMinhasContas.Name = "dgMinhasContas";
            this.dgMinhasContas.ReadOnly = true;
            this.dgMinhasContas.Size = new System.Drawing.Size(355, 150);
            this.dgMinhasContas.TabIndex = 0;
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.Black;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGraficos.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.Color.Yellow;
            this.btnGraficos.Location = new System.Drawing.Point(224, 273);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(112, 23);
            this.btnGraficos.TabIndex = 61;
            this.btnGraficos.Text = "Gráficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Black;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorico.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Yellow;
            this.btnHistorico.Location = new System.Drawing.Point(42, 273);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(112, 23);
            this.btnHistorico.TabIndex = 62;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGraficos);
            this.groupBox5.Controls.Add(this.btnHistorico);
            this.groupBox5.Location = new System.Drawing.Point(12, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 322);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            // 
            // btnAtualizarTP
            // 
            this.btnAtualizarTP.BackColor = System.Drawing.Color.Black;
            this.btnAtualizarTP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarTP.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarTP.ForeColor = System.Drawing.Color.Yellow;
            this.btnAtualizarTP.Location = new System.Drawing.Point(195, 176);
            this.btnAtualizarTP.Name = "btnAtualizarTP";
            this.btnAtualizarTP.Size = new System.Drawing.Size(133, 43);
            this.btnAtualizarTP.TabIndex = 62;
            this.btnAtualizarTP.Text = "Atualizar total projetado";
            this.btnAtualizarTP.UseVisualStyleBackColor = false;
            this.btnAtualizarTP.Click += new System.EventHandler(this.btnAtualizarTP_Click);
            // 
            // frTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "frTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transação";
            this.Load += new System.EventHandler(this.frTransacao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGastosMensais)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMinhasContas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgGastosMensais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarGastosMensais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgMinhasContas;
        private System.Windows.Forms.Button btnCadastrarConta;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.ComboBox cbContaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.NumericUpDown txtDia;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCatGastos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAtualizarTP;
    }
}