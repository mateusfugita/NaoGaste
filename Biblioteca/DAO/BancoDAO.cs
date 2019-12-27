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
    public class BancoDAO : PadraoDAO
    {
        public BancoDAO()
        {
            Tabela = "tb_banco";
            Chave = "bancoid";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            BancoVO banco = o as BancoVO;
            SqlParameter[] parametros =
            {
                new SqlParameter("bancoid", banco.Id),
                new SqlParameter("nome", banco.Nome)                
            };
            return parametros;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirBanco";
        }

        protected override string NomeProcedureUpdate()
        {
            return "SP_AlterarBanco";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            BancoVO banco = new BancoVO();
            banco.Id = Convert.ToInt32(dr["bancoid"]);
            banco.Nome = dr["nome"].ToString();
            return banco;
        }

        public DataTable Lista(string nome)
        {
            SqlParameter[] p =
            {
                new SqlParameter("nome", nome)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaBanco", p);            
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirBanco";
        }
    }
}
