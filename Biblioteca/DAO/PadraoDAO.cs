using Biblioteca.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Biblioteca.DAO
{
    public abstract class PadraoDAO
    {
        #region Métodos e Propriedades Abstratas       

        protected abstract string NomeProcedureInsert();
        protected abstract string NomeProcedureUpdate();

        protected abstract string NomeProcedureDelete();
        
        protected abstract SqlParameter[] CriaParametros(PadraoVO o);

        protected abstract PadraoVO MontaVO(DataRow dr);

        #endregion

        protected string Tabela { get; set; }
        protected string Chave { get; set; } = "id";
                
        protected virtual string NomeSQLConsultaSimples()
        {
            return "SP_ConsultaSimples";
        }


        /// <summary>
        /// Método  para inserir um registro no BD
        /// </summary>        
        public virtual void Inserir(PadraoVO o)
        {
            using (var transacao = new TransactionScope())
            {
                if (Consulta(o.Id) != null)
                    throw new Exception("Este código já está sendo utilizado!");

                Metodos.ExecutaProcedure(NomeProcedureInsert(), CriaParametros(o));
                transacao.Complete();
            }
        }


        /// <summary>
        /// Método  para alterar um regisstro
        /// </summary>        
        public virtual void Alterar(PadraoVO o)
        {
            using (var transacao = new TransactionScope())
            {
                Metodos.ExecutaProcedure(NomeProcedureUpdate(), CriaParametros(o));
                transacao.Complete();
            }
        }

        /// <summary>
        /// Método para excluir 
        /// </summary>        
        public virtual void Excluir(int Id)
        {
            using (var transacao = new TransactionScope())
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@id", Id);

                Metodos.ExecutaProcedure(NomeProcedureDelete(), parametros);
                transacao.Complete();
            }
        }
        
        /// <summary>
        /// Método para consultar 1 registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PadraoVO Consulta(int id)
        {            
            string sql = NomeSQLConsultaSimples();
            SqlParameter[] parametros =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@tabela", Tabela),
                new SqlParameter("@chave", Chave)
            };
            return ObjetoOuNull(Metodos.ExecutaProcResultSet(sql, parametros));
        }


        /// <summary>
        /// Obtem o próximo id disponível 
        /// </summary>
        /// <returns></returns>
        public virtual int ProximoId()
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),                
                new SqlParameter("chave", Chave)                
            };

            return Convert.ToInt32(Metodos.ExecutaProcResultSet("SP_ProximoID", parametros).Rows[0]["MAIOR"]);            
        }


        /// <summary>
        /// Primeiro registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Primeiro()
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave)
            };

            DataTable tabela = Metodos.ExecutaProcResultSet("SP_Primeiro", parametros);
            return ObjetoOuNull(tabela);            
        }



        /// <summary>
        /// Ultimo registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Ultimo()
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave)
            };

            DataTable tabela = Metodos.ExecutaProcResultSet("SP_Ultimo", parametros);
            return ObjetoOuNull(tabela);            
        }

        /// <summary>
        /// Próximo registro
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Proximo(int atual)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave),
                new SqlParameter("Atual", atual)
            };

            DataTable tabela = Metodos.ExecutaProcResultSet("SP_Proximo", parametros);
            return ObjetoOuNull(tabela);            
        }


        /// <summary>
        /// Registro anterior
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Anterior(int atual)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave),
                new SqlParameter("Atual", atual)
            };

            DataTable tabela = Metodos.ExecutaProcResultSet("SP_Anterior", parametros);
            return ObjetoOuNull(tabela);            
        }
                       
        private PadraoVO ObjetoOuNull(DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }

        //protected PadraoVO ExecutaSqlLocal(string sql, SqlParameter[] parametros)
        //{
        //    //DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
        //    DataTable tabela = Metodos.ExecutaProcResultSet(sql, parametros);

        //    if (tabela.Rows.Count == 0)
        //        return null;
        //    else
        //        return MontaVO(tabela.Rows[0]);
        //}
    }
}
