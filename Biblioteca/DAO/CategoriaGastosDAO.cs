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
    public class CategoriaGastosDAO : PadraoDAO
    {
        public CategoriaGastosDAO()
        {
            Tabela = "tb_CatGastos";
            Chave = "catgastosid";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            CategoriaGastosVO categoriaGastos = o as CategoriaGastosVO;

            SqlParameter[] parametros =
            {
                new SqlParameter("catgastosid", categoriaGastos.Id),
                new SqlParameter("descricao", categoriaGastos.Descricao),
                new SqlParameter("entrada_saida", categoriaGastos.InOut)
            };
            
            return parametros;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirCatGastos";
        }

        protected override string NomeProcedureUpdate()
        {
            return "SP_AlterarCatGastos";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            CategoriaGastosVO cg = new CategoriaGastosVO();
            cg.Id = Convert.ToInt32(dr["catgastosid"]);
            cg.Descricao = dr["descricao"].ToString();
            cg.InOut = Convert.ToInt32(dr["entrada_saida"]);
            return cg;
        }

        public DataTable Lista(string descricao, int entrada_saida)
        {
            SqlParameter[] p =
            {
                new SqlParameter("descricao", descricao),
                new SqlParameter("entrada_saida", entrada_saida)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaCatGastos", p);            
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirCatGastos";
        }
    }
}
