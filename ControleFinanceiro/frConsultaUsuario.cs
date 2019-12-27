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
    public partial class frConsultaUsuario : frConsultaPadrao
    {
        public frConsultaUsuario()
        {
            InitializeComponent();
        }

        private void frConsultaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {                
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                dataGridView1.DataSource = usuarioDAO.Lista(txtNome.Text);
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
