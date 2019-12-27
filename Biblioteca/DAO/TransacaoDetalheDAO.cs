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
    public class TransacaoDetalheDAO : PadraoDAO
    {
        public TransacaoDetalheDAO()
        {
            Tabela = "tb_tranDetalhe";
            Chave = "tranDetalheId";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            TransacaoDetalheVO tranMestre = o as TransacaoDetalheVO;
            SqlParameter[] parametros =
            {
                //new SqlParameter("tranDetalheId", tranMestre.Id),
                new SqlParameter("tranId", tranMestre.TranId),
                new SqlParameter("descricao", tranMestre.Descricao),
                new SqlParameter("valor", tranMestre.Valor),
                new SqlParameter("dia", tranMestre.Dia),
                new SqlParameter("catgastosId", tranMestre.CatGastosId)
            };
            return parametros;
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            TransacaoDetalheVO tranMestre = new TransacaoDetalheVO();
            tranMestre.Id = Convert.ToInt32(dr["tranDetalheId"]);
            tranMestre.TranId = Convert.ToInt32(dr["tranId"]);
            tranMestre.Descricao = dr["descricao"].ToString();
            tranMestre.Valor = Convert.ToDouble(dr["valor"]);
            tranMestre.Dia = Convert.ToInt32(dr["dia"]);
            tranMestre.CatGastosId = Convert.ToInt32(dr["catgastosId"]);
            return tranMestre;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirTransacaoDetalhe";
        }

        protected override string NomeProcedureUpdate()
        {
            throw new NotImplementedException();
        }

        public DataTable Lista(int usuarioid, int contaid, int mes, int ano, int catgastosid)
        {
            SqlParameter[] p =
            {
                new SqlParameter("usuarioid", usuarioid),
                new SqlParameter("contaid", contaid),
                new SqlParameter("catgastosid", catgastosid),
                new SqlParameter("mes", mes),
                new SqlParameter("ano", ano)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaTranDetalhe", p);
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirTranDetalhe";
        }
    }
}
