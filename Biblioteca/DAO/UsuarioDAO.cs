using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class UsuarioDAO : PadraoDAO
    {
        public UsuarioDAO()
        {
            Tabela = "tb_usuario";
            Chave = "usuarioid";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            UsuarioVO usuario = o as UsuarioVO;
            
            SqlParameter[] parametros =
            {
                new SqlParameter("usuarioid", usuario.Id),
                new SqlParameter("nome", usuario.Nome),
                new SqlParameter("foto", usuario.Foto),
                new SqlParameter("senha", usuario.Senha)
            };

            return parametros;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirUsuario";
        }

        protected override string NomeProcedureUpdate()
        {
            return "SP_AlterarUsuario";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            UsuarioVO usuario = new UsuarioVO();
            usuario.Id = Convert.ToInt32(dr["usuarioid"]);
            usuario.Nome = dr["nome"].ToString();
            usuario.Foto = dr["foto"] as byte[];
            usuario.Senha = dr["senha"].ToString();            
            return usuario;
        }
        
        public DataTable Lista(string nome)
        {            
            SqlParameter[] p =
            {
                new SqlParameter("nome", nome)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaUsuario", p);            
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirUsuario";
        }
    }
}
