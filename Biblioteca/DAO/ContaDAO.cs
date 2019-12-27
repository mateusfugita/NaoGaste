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
    public class ContaDAO : PadraoDAO
    {
        public ContaDAO()
        {
            Tabela = "tb_conta";
            Chave = "contaid";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            ContaVO conta = o as ContaVO;
            SqlParameter[] parametros =
            {
                new SqlParameter("contaid", conta.Id),
                new SqlParameter("usuarioid", conta.UsuarioID),
                new SqlParameter("bancoid", conta.BancoID),
                new SqlParameter("tipoconta", conta.TipoContaID)
            };
            return parametros;
        }

        protected override string NomeProcedureInsert()
        {
            return "SP_IncluirConta";
        }

        protected override string NomeProcedureUpdate()
        {
            return "SP_AlterarConta";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            ContaVO conta = new ContaVO();
            conta.Id = Convert.ToInt32(dr["contaid"]);
            conta.UsuarioID = Convert.ToInt32(dr["usuarioid"]);
            conta.BancoID = Convert.ToInt32(dr["bancoid"]);
            conta.TipoContaID = Convert.ToInt32(dr["tipoconta"]);
            conta.Saldo = Convert.ToDouble(dr["saldo"]);
            conta.TotalProjetado = Convert.ToDouble(dr["totalprojetado"]);
            return conta;
        }

        public DataTable ListaCompleta(int usuario, int contaid, int bancoid, int tipoconta)
        {
            SqlParameter[] p =
            {
                new SqlParameter("usuarioid", usuario),
                new SqlParameter("contaid", contaid),
                new SqlParameter("bancoid", bancoid),
                new SqlParameter("tipoconta", tipoconta)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaContaCompleta", p);
        }

        public DataTable Lista(int usuario)
        {
            SqlParameter[] p =
            {
                new SqlParameter("usuarioid", usuario)
            };
            return Metodos.ExecutaProcResultSet("SP_ListaConta", p);
        }

        protected override string NomeProcedureDelete()
        {
            return "SP_ExcluirConta";
        }
    }
}
