using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System.IO;

namespace ControleFinanceiro
{
    public partial class ucUsuario : ucPadrao
    {
        byte[] cacheImagem;
        public ucUsuario()
        {
            InitializeComponent();
        }

        public override void Inicializa()
        {
            cadastroDAO = new UsuarioDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            btnAdicionaFoto.Enabled = txtSenha.Visible = lblSenha.Visible = txtNome.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        protected override PadraoVO PreencheObj()
        {
            UsuarioVO usuario = new UsuarioVO();
            usuario.Id = Convert.ToInt32(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Foto = cacheImagem;
            cacheImagem = null;
            return usuario;

        }

        protected override void PreencheTela(PadraoVO o)
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
                        cacheImagem = (o as UsuarioVO).Foto;
                        using (var stream = new MemoryStream(u.Foto))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                        //cacheImagem = null;
                    }
                    else
                    {
                        cacheImagem = null;
                        pictureBox1.Image = null;
                    }
                    txtSenha.Text = u.Senha;
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (frConsultaUsuario frConsulta = new frConsultaUsuario())
            {
                frConsulta.ShowDialog();
                if (frConsulta.IdSelecionado != 0)
                {
                    UsuarioVO u = cadastroDAO.Consulta(frConsulta.IdSelecionado) as UsuarioVO;
                    PreencheTela(u);
                }
            }
        }

        private void btnAdicionaFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                cacheImagem = File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

        private void ucUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
