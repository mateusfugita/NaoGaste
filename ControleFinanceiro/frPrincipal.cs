using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            using (frSobre frSobre = new frSobre())
            {
                frSobre.ShowDialog();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!File.Exists("BDconfig.txt"))
                CriarBanco();
            else
            {
                CarregarBanco();
                using (frCadastro frCadastro = new frCadastro())
                {
                    frCadastro.ShowDialog();
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!File.Exists("BDconfig.txt"))
                CriarBanco();
            using (frEntrar frEntrar = new frEntrar())
            {
                frEntrar.ShowDialog();
            }            
        }

        private void frPrincipal_Load(object sender, EventArgs e)
        {
            if (!File.Exists("BDconfig.txt"))
                CriarBanco();            
            else            
                CarregarBanco();            
        }

        private void CriarBanco()
        {
            using (frCriarBanco criaBanco = new frCriarBanco())
            {
                criaBanco.ShowDialog();
            }
        }

        private void CarregarBanco()
        {
            string[] linhas = File.ReadAllLines("BDconfig.txt");
            ConexaoBD.bdconfig.Nome = Encoding.UTF8.GetString(Convert.FromBase64String(linhas[0]));
            ConexaoBD.bdconfig.Usuario = Encoding.UTF8.GetString(Convert.FromBase64String(linhas[1]));
            ConexaoBD.bdconfig.Senha = Encoding.UTF8.GetString(Convert.FromBase64String(linhas[2]));
        }
    }
}
