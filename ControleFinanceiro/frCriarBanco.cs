using Biblioteca;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class frCriarBanco : Form
    {        
        public frCriarBanco()
        {
            InitializeComponent();
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeBD.Text.Trim().Length == 0 || txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
                    throw new Exception("Preencha todos os campos corretamente!");

                ConexaoBD.bdconfig.Nome = txtNomeBD.Text;
                ConexaoBD.bdconfig.Usuario = txtUsuario.Text;
                ConexaoBD.bdconfig.Senha = txtSenha.Text;
             
                Metodos.ExecutaSQLCriaBanco();
                string[] path = Path.GetDirectoryName(Application.ExecutablePath).Split('\\');
                string caminho = "";
                for (int i = 0; i < 6; i++)
                    caminho += path[i] + "\\";
                caminho += "SQL.txt";
                
                string arquivo = File.ReadAllText(caminho);
                string[] separadores = { "##" };
                string[] comandos = arquivo.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
                foreach (string comando in comandos)
                    Metodos.ExecutaSQL(comando);
                                
                string texto = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtNomeBD.Text)) + Environment.NewLine +
                            Convert.ToBase64String(Encoding.UTF8.GetBytes(txtUsuario.Text)) + Environment.NewLine +
                            Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSenha.Text));
                File.WriteAllText("BDconfig.txt", texto);
                
                MessageBox.Show("Banco de dados criado com sucesso!");                
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);                
            }
        }

        private void frCriarBanco_Load(object sender, EventArgs e)
        {
            
        }
    }
}
