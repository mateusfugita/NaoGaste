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
    public class TransacaoMestreDAO : PadraoDAO
    {
        public TransacaoMestreDAO()
        {
            Tabela = "tb_tran";
            Chave = "tranId";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            TransacaoMestreVO tranMestre = o as TransacaoMestreVO;
            SqlParameter[] parametros =
            {
                //new SqlParameter("tranId", tranMestre.Id),
                new SqlParameter("contaId", tranMestre.ContaId),
                new SqlParameter("mes", tranMestre.Mes),
                new SqlParameter("ano", tranMestre.Ano)
            };
            return parametros;
        }

        protected override string NomeProcedureInsert()
        {            
            return "SP_IncluirTransacaoMestre";
        }

        protected override string NomeProcedureUpdate()
        {
            throw new NotImplementedException();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            TransacaoMestreVO tranMestre = new TransacaoMestreVO();
            tranMestre.Id = Convert.ToInt32(dr["tranId"]);
            tranMestre.ContaId = Convert.ToInt32(dr["contaId"]);
            tranMestre.Mes = Convert.ToInt32(dr["mes"]);
            tranMestre.Ano = Convert.ToInt32(dr["ano"]);
            return tranMestre;
        }

        public DataTable Lista(int usuarioid, int contaid, int mes, int ano)
        {
            SqlParameter[] p =
            {
                new SqlParameter("usuarioid", usuarioid),
                new SqlParameter("contaid", contaid),
                new SqlParameter("mes", mes),
                new SqlParameter("ano", ano)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaTranMestre", p);
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirTran";
        }
    }
}
