namespace ControleFinanceiro
{
    partial class ucPadrao
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
            this.gbNavegacao = new System.Windows.Forms.GroupBox();
            this.gbModificacao = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInclui = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.gbNavegacao.SuspendLayout();
            this.gbModificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNavegacao
            // 
            this.gbNavegacao.Controls.Add(this.btnUltimo);
            this.gbNavegacao.Controls.Add(this.btnPrimeiro);
            this.gbNavegacao.Controls.Add(this.btnAnterior);
            this.gbNavegacao.Controls.Add(this.btnProximo);
            this.gbNavegacao.Location = new System.Drawing.Point(4, 4);
            this.gbNavegacao.Name = "gbNavegacao";
            this.gbNavegacao.Size = new System.Drawing.Size(450, 75);
            this.gbNavegacao.TabIndex = 0;
            this.gbNavegacao.TabStop = false;
            this.gbNavegacao.Text = "Navegação";
            this.gbNavegacao.Enter += new System.EventHandler(this.gbNavegacao_Enter);
            // 
            // gbModificacao
            // 
            this.gbModificacao.Controls.Add(this.btnCancelar);
            this.gbModificacao.Controls.Add(this.btnInclui);
            this.gbModificacao.Controls.Add(this.btnPesquisa);
            this.gbModificacao.Controls.Add(this.btnAltera);
            this.gbModificacao.Controls.Add(this.btnExclui);
            this.gbModificacao.Controls.Add(this.btnGravar);
            this.gbModificacao.Location = new System.Drawing.Point(4, 85);
            this.gbModificacao.Name = "gbModificacao";
            this.gbModificacao.Size = new System.Drawing.Size(450, 71);
            this.gbModificacao.TabIndex = 1;
            this.gbModificacao.TabStop = false;
            this.gbModificacao.Text = "Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 185);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 20);
            this.txtId.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Image = global::ControleFinanceiro.Properties.Resources.icons8_excluir_filled_50;
            this.btnCancelar.Location = new System.Drawing.Point(279, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 43);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInclui
            // 
            this.btnInclui.BackColor = System.Drawing.Color.Black;
            this.btnInclui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInclui.Image = global::ControleFinanceiro.Properties.Resources.icons8_mais_filled_50;
            this.btnInclui.Location = new System.Drawing.Point(9, 19);
            this.btnInclui.Name = "btnInclui";
            this.btnInclui.Size = new System.Drawing.Size(51, 43);
            this.btnInclui.TabIndex = 43;
            this.btnInclui.UseVisualStyleBackColor = false;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.Black;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisa.Image = global::ControleFinanceiro.Properties.Resources.icons8_pesquisar_filled_50;
            this.btnPesquisa.Location = new System.Drawing.Point(383, 19);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(56, 43);
            this.btnPesquisa.TabIndex = 52;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.Color.Black;
            this.btnAltera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltera.Image = global::ControleFinanceiro.Properties.Resources.icons8_sincronizar_filled_50;
            this.btnAltera.Location = new System.Drawing.Point(73, 19);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(51, 43);
            this.btnAltera.TabIndex = 44;
            this.btnAltera.UseVisualStyleBackColor = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.Black;
            this.btnExclui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExclui.Image = global::ControleFinanceiro.Properties.Resources.icons8_excluir_filled_50__1_;
            this.btnExclui.Location = new System.Drawing.Point(135, 19);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(51, 43);
            this.btnExclui.TabIndex = 45;
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Black;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Image = global::ControleFinanceiro.Properties.Resources.icons8_salvar_32;
            this.btnGravar.Location = new System.Drawing.Point(222, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(51, 43);
            this.btnGravar.TabIndex = 50;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Black;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUltimo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUltimo.Image = global::ControleFinanceiro.Properties.Resources.icons8_último_1_filled_50;
            this.btnUltimo.Location = new System.Drawing.Point(182, 19);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(51, 43);
            this.btnUltimo.TabIndex = 49;
            this.btnUltimo.Text = " ";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.Color.Black;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimeiro.Image = global::ControleFinanceiro.Properties.Resources.icons8_primeiro_1_filled_50;
            this.btnPrimeiro.Location = new System.Drawing.Point(8, 19);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(51, 43);
            this.btnPrimeiro.TabIndex = 46;
            this.btnPrimeiro.Text = " ";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Black;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Image = global::ControleFinanceiro.Properties.Resources.icons8_voltar_filled_50;
            this.btnAnterior.Location = new System.Drawing.Point(65, 19);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 43);
            this.btnAnterior.TabIndex = 47;
            this.btnAnterior.Text = " ";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Black;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Image = global::ControleFinanceiro.Properties.Resources.icons8_avançar_filled_50;
            this.btnProximo.Location = new System.Drawing.Point(125, 19);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(51, 43);
            this.btnProximo.TabIndex = 48;
            this.btnProximo.Text = " ";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // ucPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gbModificacao);
            this.Controls.Add(this.gbNavegacao);
            this.Name = "ucPadrao";
            this.Size = new System.Drawing.Size(461, 231);
            this.Load += new System.EventHandler(this.ucPadrao_Load);
            this.gbNavegacao.ResumeLayout(false);
            this.gbModificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown txtId;
        protected System.Windows.Forms.Button btnPesquisa;
        protected System.Windows.Forms.Button btnExclui;
        protected System.Windows.Forms.GroupBox gbNavegacao;
        protected System.Windows.Forms.GroupBox gbModificacao;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGravar;
        protected System.Windows.Forms.Button btnUltimo;
        protected System.Windows.Forms.Button btnProximo;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.Button btnPrimeiro;
        protected System.Windows.Forms.Button btnAltera;
        protected System.Windows.Forms.Button btnInclui;
    }
}
