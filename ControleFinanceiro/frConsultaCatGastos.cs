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
    public partial class frConsultaCatGastos : frConsultaPadrao
    {
        public frConsultaCatGastos()
        {
            InitializeComponent();
        }

        private void frConsultaCatGastos_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaGastosDAO catGastosDAO = new CategoriaGastosDAO();
                dataGridView1.DataSource = catGastosDAO.Lista(txtDescricao.Text, cbInOut.SelectedIndex);
                cbInOut.SelectedIndex = -1;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
