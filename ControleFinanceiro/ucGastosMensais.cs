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
    public partial class ucGastosMensais : ucPadrao
    {
        public ucGastosMensais()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new GastosMensaisDAO();
            SugereProximoId = true;
            base.Inicializa();
            txtId.Value = 0;
            txtDescricao.Text = txtValor.Text = txtVencimento.Text = "";
            btnAltera.Enabled = btnExclui.Enabled = false;
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            txtDescricao.Enabled = txtValor.Enabled = txtVencimento.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            GastosMensaisVO gastosMensais = new GastosMensaisVO();
            gastosMensais.Id = Convert.ToInt32(txtId.Text);
            gastosMensais.Descricao = txtDescricao.Text;
            gastosMensais.Valor = txtValor.Text != "" ? Convert.ToDouble(txtValor.Text) : 0;
            gastosMensais.Vencimento = txtVencimento.Text != "" ? Convert.ToInt32(txtVencimento.Text) : 0;
            gastosMensais.UsuarioId = (this.Parent as frCadastroGastosMensais).UsuarioId;
            return gastosMensais;

        }

        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    GastosMensaisVO g = o as GastosMensaisVO;
                    txtId.Text = g.Id.ToString();
                    txtDescricao.Text = g.Descricao;
                    txtValor.Text = g.Valor != 0 ? g.Valor.ToString() : "";
                    txtVencimento.Text = g.Vencimento != 0 ? g.Vencimento.ToString() : "";
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

        private void ucGastosMensais_Load(object sender, EventArgs e)
        {
            //GastosMensaisDAO gastosMensaisDAO = new GastosMensaisDAO();
            //int usuarioId = (this.Parent as frTransacao).Usuario.Id;
            //dataGridView1.DataSource = gastosMensaisDAO.Lista(usuarioId);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (frConsultaGastosMensais frConsulta = new frConsultaGastosMensais())
            {
                frConsulta.UsuarioID = (this.Parent as frCadastroGastosMensais).UsuarioId;
                frConsulta.ShowDialog();
                if (frConsulta.IdSelecionado != 0)
                {
                    GastosMensaisVO g = cadastroDAO.Consulta(frConsulta.IdSelecionado) as GastosMensaisVO;
                    PreencheTela(g);
                    btnAltera.Enabled = btnExclui.Enabled = true;
                }
            }
        }
    }
}
