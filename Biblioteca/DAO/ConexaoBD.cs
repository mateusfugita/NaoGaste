using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class ConexaoBD
    {
        public static BDconfig bdconfig = new BDconfig();

        public static SqlConnection GetConexao()
        {
            //string strCon = $"Data Source=LOCALHOST;Initial Catalog={bdconfig.Nome};Integrated Security=True";            
            string strCon = $"Data Source=LOCALHOST;Initial Catalog={bdconfig.Nome};user id={bdconfig.Usuario}; password={bdconfig.Senha}";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }

        public static SqlConnection CriarBanco()
        {
            //string strCon = "Data Source=LOCALHOST;Initial Catalog=master;Integrated Security=True";
            string strCon = $"Data Source=LOCALHOST;Initial Catalog=master;user id={bdconfig.Usuario}; password={bdconfig.Senha}";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
