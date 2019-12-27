using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Enumeradores;
using Biblioteca.DAO;
using Biblioteca.VO;

namespace ControleFinanceiro
{
    public partial class ucTipoConta : ucPadrao
    {
        public ucTipoConta()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new TipoContaDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            txtDescricao.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            TipoContaVO tipoConta = new TipoContaVO();
            tipoConta.Id = Convert.ToInt32(txtId.Text);
            tipoConta.Descricao = txtDescricao.Text;            
            return tipoConta;
        }

        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    TipoContaVO tc = o as TipoContaVO;
                    txtId.Text = tc.Id.ToString();
                    txtDescricao.Text = tc.Descricao;                    
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

        private void ucTipoConta_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (frConsultaTipoConta frConsulta = new frConsultaTipoConta())
            {
                frConsulta.ShowDialog();
                if (frConsulta.IdSelecionado != 0)
                {
                    TipoContaVO b = cadastroDAO.Consulta(frConsulta.IdSelecionado) as TipoContaVO;
                    PreencheTela(b);
                }
            }
        }
    }
}
