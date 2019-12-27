using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class frConsultaTransacao : Form
    {
        public int UsuarioId { get; set; }

        public frConsultaTransacao()
        {
            InitializeComponent();
        }
                
        private void frConsultaTransacao_Load(object sender, EventArgs e)
        {            
            PreencheCatGastos();
            PreencheContas();
            cbMes.SelectedIndex = cbContaID.SelectedIndex = cbCatGastos.SelectedIndex = -1;
            txtAno.Value = 0;            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            TransacaoMestreDAO transacaoMestreDAO = new TransacaoMestreDAO();
            dgMestre.DataSource = transacaoMestreDAO.Lista(UsuarioId, Convert.ToInt32(cbContaID.SelectedValue), cbMes.SelectedIndex + 1, Convert.ToInt32(txtAno.Value));
            TransacaoDetalheDAO transacaoDetalheDAO = new TransacaoDetalheDAO();
            dgDetalhe.DataSource = transacaoDetalheDAO.Lista(UsuarioId, Convert.ToInt32(cbContaID.SelectedValue), cbMes.SelectedIndex + 1, Convert.ToInt32(txtAno.Value), Convert.ToInt32(cbCatGastos.SelectedValue));
            cbMes.SelectedIndex = cbContaID.SelectedIndex = cbCatGastos.SelectedIndex = -1;
            txtAno.Value = 0;
        }

        private void PreencheCatGastos()
        {
            CategoriaGastosDAO categoriaGastosDAO = new CategoriaGastosDAO();
            cbCatGastos.DataSource = categoriaGastosDAO.Lista("", -1);
            cbCatGastos.DisplayMember = "descricao";
            cbCatGastos.ValueMember = "catgastosid";
        }

        private void PreencheContas()
        {
            ContaDAO minhasContas = new ContaDAO();
            cbContaID.DataSource = minhasContas.Lista(UsuarioId);
            cbContaID.DisplayMember = "contaid";
            cbContaID.ValueMember = "contaid";
        }

        private void dgMestre_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if((Keys)e.KeyChar == Keys.Delete)
            {
                
            }
        }

        private void btnApagarMestre_Click(object sender, EventArgs e)
        {
            if (dgMestre.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja mesmo apagar esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TransacaoMestreDAO transacaoMestreDAO = new TransacaoMestreDAO();
                    transacaoMestreDAO.Excluir(Convert.ToInt32(dgMestre.CurrentRow.Cells["tranId"].Value));
                    dgMestre.DataSource = dgDetalhe.DataSource = null;
                }
            }
        }

        private void btnApagarDetalhe_Click(object sender, EventArgs e)
        {
            if (dgMestre.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja mesmo apagar esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TransacaoDetalheDAO transacaoDetalheDAO = new TransacaoDetalheDAO();
                    transacaoDetalheDAO.Excluir(Convert.ToInt32(dgDetalhe.CurrentRow.Cells[0].Value));
                    dgMestre.DataSource = dgDetalhe.DataSource = null;
                }
            }
        }
    }
}
