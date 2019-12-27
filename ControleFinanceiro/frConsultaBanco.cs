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
    public partial class frConsultaBanco : frConsultaPadrao
    {
        public frConsultaBanco()
        {
            InitializeComponent();
        }

        private void frConsultaBanco_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                BancoDAO bancoDAO = new BancoDAO();
                dataGridView1.DataSource = bancoDAO.Lista(txtNome.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
