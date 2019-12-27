using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;

namespace ControleFinanceiro
{
    public partial class ucConta : ucPadrao
    {           
        public ucConta()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new ContaDAO();
            SugereProximoId = true;
            PreencheCombobox();            
            base.Inicializa();
            cbBanco.SelectedIndex = -1;
            cbTipoConta.SelectedIndex = -1;
            txtId.Value = 0;
            btnAltera.Enabled = btnExclui.Enabled = false;
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            cbTipoConta.Enabled = cbBanco.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            ContaVO conta = new ContaVO();
            conta.Id = Convert.ToInt32(txtId.Value);
            conta.BancoID = Convert.ToInt32(cbBanco.SelectedValue);
            conta.TipoContaID = Convert.ToInt32(cbTipoConta.SelectedValue);
            conta.UsuarioID = (this.Parent as frCadastroConta).UsuarioId;
            return conta;
        }

        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    ContaVO conta = o as ContaVO;
                    txtId.Value = conta.Id;
                    cbBanco.SelectedValue = conta.BancoID;
                    cbTipoConta.SelectedValue = conta.TipoContaID;
                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }

        private void ucBanco_Load(object sender, EventArgs e)
        {
            
        }
                
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (frConsultaConta frConsulta = new frConsultaConta())
            {
                frConsulta.UsuarioID = (this.Parent as frCadastroConta).UsuarioId;
                frConsulta.ShowDialog();                
                if (frConsulta.IdSelecionado != 0)
                {
                    ContaVO c = cadastroDAO.Consulta(frConsulta.IdSelecionado) as ContaVO;
                    PreencheTela(c);
                    btnAltera.Enabled = btnExclui.Enabled = true;
                }
            }
        }

        private void PreencheCombobox()
        {
            BancoDAO banco = new BancoDAO();
            cbBanco.DataSource = banco.Lista("");
            cbBanco.DisplayMember = "nome";
            cbBanco.ValueMember = "bancoid";
            TipoContaDAO tipoConta = new TipoContaDAO();
            cbTipoConta.DataSource = tipoConta.Lista("");
            cbTipoConta.DisplayMember = "descricao";
            cbTipoConta.ValueMember = "codtipo";
        }
    }
}
