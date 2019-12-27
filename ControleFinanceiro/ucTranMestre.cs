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
    public partial class ucTranMestre : ucPadrao
    {
        public ucTranMestre()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new TransacaoMestreDAO();
            SugereProximoId = true;            
            base.Inicializa();
            ContaDAO conta = new ContaDAO();
            cbContaID.DataSource = conta.Lista((this.Parent as frTransacao).Usuario.Id);
            cbContaID.ValueMember = cbContaID.DisplayMember = "contaid";
            txtAno.Minimum = 1900;
            txtAno.Maximum = 10000;
            txtAno.Value = DateTime.Now.Year;
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            cbMes.Enabled = cbContaID.Enabled = txtAno.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            TransacaoMestreVO tranMestre = new TransacaoMestreVO();
            tranMestre.Id = Convert.ToInt32(txtId.Text);
            tranMestre.ContaId = Convert.ToInt32(cbContaID.SelectedText);
            tranMestre.Mes = cbMes.SelectedIndex + 1;
            tranMestre.Ano = Convert.ToInt32(txtId.Value);
            return tranMestre;
        }

        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    TransacaoMestreVO t = o as TransacaoMestreVO;
                    txtId.Text = t.Id.ToString();
                    cbContaID.SelectedText = t.ContaId.ToString();
                    cbMes.SelectedIndex = t.Mes - 1;
                    txtAno.Value = t.Ano;
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

        private void ucTranMestre_Load(object sender, EventArgs e)
        {

        }
    }
}
