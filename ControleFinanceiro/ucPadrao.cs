using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.VO;
using Biblioteca.Enumeradores;
using Biblioteca.DAO;

namespace ControleFinanceiro
{
    public partial class ucPadrao : UserControl
    {
        public ucPadrao()
        {
            InitializeComponent();
        }

        protected PadraoDAO cadastroDAO;

        public bool SugereProximoId { get; set; } = false;

        protected bool ModoDeDesign()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            return designMode;
        }


        protected virtual void PreencheTela(PadraoVO o)
        {
            //preencher nos filhos         
        }

        //protected void TrataErro(Exception erro) { if (erro is FormatException) { Metodos.Mensagem("Campo numérico inválido!", TipoMensagemEnum.erro); } else if (erro is SqlException) { Metodos.Mensagem("Ocorreu um erro no banco de dados.", TipoMensagemEnum.erro); } else if (erro is Exception) { Metodos.Mensagem(erro.Message, TipoMensagemEnum.erro); } }
        

        private void AlteraParaModo(EnumModoOperacao modo)
        {
            btnInclui.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAltera.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnExclui.Enabled = (modo == EnumModoOperacao.Navegacao) && txtId.Text.Length > 0;

            btnPrimeiro.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAnterior.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnProximo.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnUltimo.Enabled = (modo == EnumModoOperacao.Navegacao);

            btnGravar.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnPesquisa.Enabled = (modo == EnumModoOperacao.Navegacao);

            if (modo == EnumModoOperacao.Inclusao)
            {
                txtId.Enabled = true;
                LimpaCampos(this);
                txtId.Focus();
            }
            else
                txtId.Enabled = false;
            
            ControlaCamposTela(modo);
        }


        protected virtual void ControlaCamposTela(EnumModoOperacao modo)
        {
            // deve ser sobrescrito 
        }

        protected void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox || objeto is MaskedTextBox)
                objeto.Text = "";
            else if (objeto is NumericUpDown)
                (objeto as NumericUpDown).Value = 0;
            else if (objeto is PictureBox)
                (objeto as PictureBox).Image = null;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Alteracao);
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
            if (SugereProximoId)
                txtId.Value = cadastroDAO.ProximoId();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            //if (Metodos.ValidaInt(txtId.Text) == false) { Metodos.Mensagem("Digite apenas números no campo ID.", TipoMensagemEnum.alerta); return; }            
            if (MessageBox.Show("Deseja apagar esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cadastroDAO.Excluir(Convert.ToInt32(txtId.Text));
                    btnPrimeiro.PerformClick();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    //TrataErro(erro);
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO obj = PreencheObj();

                if (txtId.Enabled)
                    cadastroDAO.Inserir(obj);
                else
                    cadastroDAO.Alterar(obj);

                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //TrataErro(erro);
            }
        }

        protected virtual PadraoVO PreencheObj() { return null; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Enabled)
                PreencheTela(cadastroDAO.Primeiro());
            else
                PreencheTela(cadastroDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Anterior(Convert.ToInt32(txtId.Text));
                if (o != null)
                    PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //TrataErro(erro);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Primeiro();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //TrataErro(erro);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Proximo(Convert.ToInt32(txtId.Text));
                if (o != null)
                    PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //TrataErro(erro);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Ultimo();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //TrataErro(erro);
            }
        }        

        public virtual void Inicializa()
        {
            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void gbNavegacao_Enter(object sender, EventArgs e)
        {

        }

        private void ucPadrao_Load(object sender, EventArgs e)
        {
            //if (!ModoDeDesign())
            //    Inicializa();
            if (!this.DesignMode)
                Inicializa();
            else
                return;
        }        
    }    
}

