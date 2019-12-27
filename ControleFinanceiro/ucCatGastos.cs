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
    public partial class ucCatGastos : ucPadrao
    {
        public ucCatGastos()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new CategoriaGastosDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            cbInOut.Enabled = txtDescricao.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            CategoriaGastosVO catGastos = new CategoriaGastosVO();
            catGastos.Id = Convert.ToInt32(txtId.Text);
            catGastos.Descricao = txtDescricao.Text;
            catGastos.InOut = cbInOut.SelectedIndex;
            return catGastos;
        }

        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    CategoriaGastosVO cg = o as CategoriaGastosVO;
                    txtId.Text = cg.Id.ToString();
                    txtDescricao.Text = cg.Descricao;
                    cbInOut.SelectedIndex = cg.InOut;
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

        private void ucCatGastos_Load(object sender, EventArgs e)
        {
            cbInOut.SelectedIndex = 0;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (frConsultaCatGastos frConsulta = new frConsultaCatGastos())
            {
                frConsulta.ShowDialog();
                if (frConsulta.IdSelecionado != 0)
                {
                    CategoriaGastosVO b = cadastroDAO.Consulta(frConsulta.IdSelecionado) as CategoriaGastosVO;
                    PreencheTela(b);
                }
            }
        }
    }
}
