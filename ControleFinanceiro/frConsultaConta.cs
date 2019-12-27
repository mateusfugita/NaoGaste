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
    public partial class frConsultaConta : frConsultaPadrao
    {
        public int UsuarioID { get; set; }

        public frConsultaConta()
        {
            InitializeComponent();
        }

        private void frConsultaConta_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ContaDAO contaDAO = new ContaDAO();
                dataGridView1.DataSource = contaDAO.ListaCompleta(UsuarioID,Convert.ToInt32(txtContaID.Value), Convert.ToInt32(cbBanco.SelectedValue),
                   Convert.ToInt32(cbTipoConta.SelectedValue));
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
