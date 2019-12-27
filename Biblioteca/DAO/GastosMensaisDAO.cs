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
    public class GastosMensaisDAO : PadraoDAO
    {
        public GastosMensaisDAO()
        {
            Tabela = "tb_gastosMensais";
            Chave = "gastosid";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            GastosMensaisVO gastosMensais = o as GastosMensaisVO;

            SqlParameter[] parametros =
            {
                new SqlParameter("gastosid", gastosMensais.Id),
                new SqlParameter("descricao", gastosMensais.Descricao),
                new SqlParameter("valor", gastosMensais.Valor),
                new SqlParameter("diaVencimento", gastosMensais.Vencimento),
                new SqlParameter("usuarioid", gastosMensais.UsuarioId)
            };

            return parametros;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirGastosMensais";
        }

        protected override string NomeProcedureUpdate()
        {
            return "SP_AlterarGastosMensais";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            GastosMensaisVO gastosMensais = new GastosMensaisVO();
            gastosMensais.Id = Convert.ToInt32(dr["gastosid"]);
            gastosMensais.Descricao = dr["descricao"].ToString();
            gastosMensais.Valor = dr["valor"] != DBNull.Value ? Convert.ToDouble(dr["valor"]) : 0;
            gastosMensais.Vencimento = dr["diaVencimento"] != DBNull.Value ? Convert.ToInt32(dr["diaVencimento"]) : 0;
            gastosMensais.UsuarioId = Convert.ToInt32(dr["usuarioid"]);
            return gastosMensais;
        }

        public DataTable Lista(int usuarioId, string descricao, int dia)
        {
            SqlParameter[] p =
            {
                new SqlParameter("usuarioid", usuarioId),
                new SqlParameter("descricao", descricao),
                new SqlParameter("dia", dia)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaGastosMensais", p);
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirGastosMensais";
        }
    }
}
