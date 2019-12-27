using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class frGrafico : Form
    {
        public int UsuarioId { get; set; }
        public frGrafico()
        {
            InitializeComponent();
        }

        private void frGrafico_Load(object sender, EventArgs e)
        {
            rbPorCategoria.Checked = true;
        }

        private void CarregaGrafico(int rb)
        {
            SqlParameter[] p =
            {
                new SqlParameter("usuarioid", UsuarioId),
                new SqlParameter("rb", rb)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet("SP_Grafico", p);
            chart1.DataSource = tabela;
            if (rb == 1)
                chart1.Series[0].Name = "Categoria";
            else
                chart1.Series[0].Name = "Saída";
            chart1.Series[0].XValueMember = tabela.Columns[1].ColumnName;
            chart1.Series[0].YValueMembers = "valor";                        
            chart1.DataBind();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbPorCategoria.Checked)
                CarregaGrafico(1);
            else if (rbPorMes.Checked)
                CarregaGrafico(2);
        }
    }
}
