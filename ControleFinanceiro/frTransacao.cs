using Biblioteca;
using Biblioteca.DAO;
using Biblioteca.VO;
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
    public partial class frTransacao : Form
    {
        public UsuarioVO Usuario { get; set; }
        public frTransacao()
        {
            InitializeComponent();
        }

        private void frTransacao_Load(object sender, EventArgs e)
        {
            label1.Text = "Olá, " + Usuario.Nome + "!";
            PreencheGastosMensais();
            PreencheContas();
            PreencheCatGastos();
            txtAno.Minimum = 1900;
            txtAno.Maximum = 10000;
            txtAno.Value = DateTime.Now.Year;
            cbMes.SelectedIndex = DateTime.Now.Month - 1;            
        }

        private void PreencheCatGastos()
        {
            CategoriaGastosDAO categoriaGastosDAO = new CategoriaGastosDAO();
            cbCatGastos.DataSource = categoriaGastosDAO.Lista("", -1);
            cbCatGastos.DisplayMember = "descricao";
            cbCatGastos.ValueMember = "catgastosid";
        }

        private void PreencheGastosMensais()
        {
            GastosMensaisDAO gastosMensaisDAO = new GastosMensaisDAO();
            dgGastosMensais.DataSource = gastosMensaisDAO.Lista(Usuario.Id, "", 0);
            dgGastosMensais.Columns[0].Visible = false;
            dgGastosMensais.Columns[1].HeaderText = "Descrição";
            dgGastosMensais.Columns[2].HeaderText = "Valor";            
            dgGastosMensais.Columns[3].HeaderText = "Data de vencimento";
            dgGastosMensais.Columns[4].Visible = false;
        }

        private void PreencheContas()
        {
            ContaDAO minhasContas = new ContaDAO();
            dgMinhasContas.DataSource = minhasContas.ListaCompleta(Usuario.Id, 0, 0, 0);
            cbContaID.DataSource = minhasContas.Lista(Usuario.Id);
            cbContaID.DisplayMember = "contaid";
            cbContaID.ValueMember = "contaid";
            dgMinhasContas.Columns[0].HeaderText = "ContaID";
            dgMinhasContas.Columns[1].HeaderText = "Banco";
            dgMinhasContas.Columns[2].HeaderText = "Tipo de conta";
            dgMinhasContas.Columns[3].HeaderText = "Saldo";
            dgMinhasContas.Columns[4].HeaderText = "Total projetado";            
        }

        private void btnCadastrarGastosMensais_Click(object sender, EventArgs e)
        {
            using (frCadastroGastosMensais frCadastro = new frCadastroGastosMensais())
            {
                frCadastro.UsuarioId = Usuario.Id;
                frCadastro.ShowDialog();                
                PreencheGastosMensais();
            }
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            using (frCadastroConta frCadastro = new frCadastroConta())
            {
                frCadastro.UsuarioId = Usuario.Id;
                frCadastro.ShowDialog();
                PreencheContas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TransacaoMestreVO transacaoMestre = new TransacaoMestreVO();
                transacaoMestre.ContaId = Convert.ToInt32(cbContaID.SelectedValue);
                transacaoMestre.Mes = cbMes.SelectedIndex + 1;
                transacaoMestre.Ano = Convert.ToInt32(txtAno.Value);
                TransacaoMestreDAO transacaoMestreDAO = new TransacaoMestreDAO();
                transacaoMestreDAO.Inserir(transacaoMestre);

                TransacaoDetalheVO transacaoDetalhe = new TransacaoDetalheVO();
                transacaoDetalhe.TranId = Convert.ToInt32(transacaoMestreDAO.Lista(Usuario.Id, transacaoMestre.ContaId, transacaoMestre.Mes, transacaoMestre.Ano).Rows[0][0]);
                transacaoDetalhe.Dia = Convert.ToInt32(txtDia.Value);
                transacaoDetalhe.Descricao = txtDescricao.Text;
                transacaoDetalhe.Valor = Convert.ToDouble(txtValor.Text);
                transacaoDetalhe.CatGastosId = Convert.ToInt32(cbCatGastos.SelectedValue);
                TransacaoDetalheDAO transacaoDetalheDAO = new TransacaoDetalheDAO();
                transacaoDetalheDAO.Inserir(transacaoDetalhe);
                MessageBox.Show("Salvo com sucesso!");
                PreencheContas();
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            using (frConsultaTransacao frConsulta = new frConsultaTransacao())
            {
                frConsulta.UsuarioId = Usuario.Id;
                frConsulta.ShowDialog();
                PreencheContas();
            }
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            using (frGrafico frGrafico = new frGrafico())
            {
                frGrafico.UsuarioId = Usuario.Id;
                frGrafico.ShowDialog();
            }
        }

        private void btnAtualizarTP_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos.ExecutaProcedure("Sp_atualizatotalprojetado", null);
                MessageBox.Show("Atualizado com sucesso!");
                PreencheContas();
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
