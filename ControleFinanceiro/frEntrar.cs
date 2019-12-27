using Biblioteca;
using Biblioteca.DAO;
using Biblioteca.VO;
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
    public partial class frEntrar : Form
    {
        private UsuarioDAO cadastroDAO = new UsuarioDAO();

        public frEntrar()
        {
            InitializeComponent();
            txtId.Enabled = txtNome.Enabled = pictureBox1.Enabled = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioVO usuario = cadastroDAO.Consulta(Convert.ToInt32(txtId.Value)) as UsuarioVO;
                if(usuario.Senha == txtSenha.Text)
                {
                    using (frTransacao frTransacao = new frTransacao())
                    {
                        this.Close();
                        frTransacao.Usuario = usuario;
                        frTransacao.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Senha incorreta!");                
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Primeiro();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {                
                PadraoVO o = cadastroDAO.Anterior(Convert.ToInt32(txtId.Text));
                if (o != null)
                    PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Proximo(Convert.ToInt32(txtId.Text));
                if (o != null)
                    PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Ultimo();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    UsuarioVO u = o as UsuarioVO;
                    txtId.Text = u.Id.ToString();
                    txtNome.Text = u.Nome;
                    if ((o as UsuarioVO).Foto != null)
                    {                        
                        using (var stream = new MemoryStream(u.Foto))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {                        
                        pictureBox1.Image = null;
                    }                    
                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro.Message);
                //TrataErro(erro);
            }
        }

        private void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox || objeto is MaskedTextBox)
                objeto.Text = "";
            else if (objeto is NumericUpDown)
                (objeto as NumericUpDown).Value = 0;
            else if (objeto is PictureBox)
                (objeto as PictureBox).Image = null;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }

        private void frEntrar_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();
        }
    }
}
