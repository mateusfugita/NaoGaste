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
    public partial class ucBanco : ucPadrao
    {
        public ucBanco()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new BancoDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            txtNome.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            BancoVO banco = new BancoVO();
            banco.Id = Convert.ToInt32(txtId.Text);
            banco.Nome = txtNome.Text;           
            return banco;

        }

        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    BancoVO b = o as BancoVO;
                    txtId.Text = b.Id.ToString();
                    txtNome.Text = b.Nome;                    
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
            using (frConsultaBanco frConsulta = new frConsultaBanco())
            {
                frConsulta.ShowDialog();
                if (frConsulta.IdSelecionado != 0)
                {
                    BancoVO b = cadastroDAO.Consulta(frConsulta.IdSelecionado) as BancoVO;
                    PreencheTela(b);
                }
            }
        }
    }
}
