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
    public partial class frConsultaPadrao : Form
    {
        public int IdSelecionado { get; private set; }

        public frConsultaPadrao()
        {
            InitializeComponent();
            if (this.DesignMode)
                return;
        }
        
        private void frConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                IdSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }
    }
}
