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
    public partial class frCadastro : Form
    {
        private TabControl tabControl2 = new TabControl();
        private UsuarioVO usuario = new UsuarioVO();

        public frCadastro()
        {
            InitializeComponent();
        }

        private void frCadastro_Load(object sender, EventArgs e)
        {            
            //foreach(TabPage tp in tabControl1.TabPages)
            //{
            //    tabControl2.Controls.Add(tp);
            //}
            //tabControl1.Controls.Add(tpUsuario);
        }

        //private void btnAvancar_Click(object sender, EventArgs e)
        //{
        //    Control[] ct = ucUsuario1.Controls.Find("txtId", true);
        //    UsuarioDAO usuarioDAO = new UsuarioDAO();
        //    usuario = usuarioDAO.Consulta(Convert.ToInt32((ct[0] as NumericUpDown).Value)) as UsuarioVO;

        //    tabControl2.Controls.Add(tpUsuario);
        //    tabControl1.Controls.Add(tpBanco);
        //}

        private void ucUsuario1_Load(object sender, EventArgs e)
        {

        }
    }
}
