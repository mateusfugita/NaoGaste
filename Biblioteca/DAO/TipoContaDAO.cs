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
    public class TipoContaDAO : PadraoDAO
    {
        public TipoContaDAO()
        {
            Tabela = "tb_TipoConta";
            Chave = "codtipo";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            TipoContaVO tipoConta = o as TipoContaVO;

            SqlParameter[] parametros =
            {
                new SqlParameter("codtipo", tipoConta.Id),
                new SqlParameter("descricao", tipoConta.Descricao)
            };
            return parametros;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirTipoConta";
        }

        protected override string NomeProcedureUpdate()
        {
            return "SP_AlterarTipoConta";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            TipoContaVO tipoConta = new TipoContaVO();
            tipoConta.Id = Convert.ToInt32(dr["codtipo"]);
            tipoConta.Descricao = dr["descricao"].ToString();
            return tipoConta;
        }

        public DataTable Lista(string descricao)
        {            
            SqlParameter[] p =
            {
                new SqlParameter("descricao", descricao)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaTipoConta", p);            
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirTipoConta";
        }
    }
}
