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
    public partial class frConsultaGastosMensais : frConsultaPadrao
    {
        public int UsuarioID { get; set; }

        public frConsultaGastosMensais()
        {
            InitializeComponent();
        }

        private void frConsultaGastosMensais_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                GastosMensaisDAO gastosMensaisDAO = new GastosMensaisDAO();
                dataGridView1.DataSource = gastosMensaisDAO.Lista(UsuarioID, txtDescricao.Text, Convert.ToInt32(txtDia.Value));
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
