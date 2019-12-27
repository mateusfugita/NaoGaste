﻿using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Metodos
    {
        public static DataTable ExecutaProcResultSet(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(procedure, cx))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }

        public static void ExecutaProcedure(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(procedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static string ExecutaProcedureComRetorno(string procedure, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(procedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);

                    comando.Parameters.Add("retorno", SqlDbType.VarChar);
                    comando.Parameters["retorno"].Direction = ParameterDirection.ReturnValue;
                    comando.ExecuteNonQuery();
                    return comando.Parameters["retorno"].Value.ToString();
                }
            }
        }
        
        public static void ExecutaSQLCriaBanco()
        {
            string sql = "create database " + ConexaoBD.bdconfig.Nome;
            using (SqlConnection conexao = ConexaoBD.CriarBanco())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {                    
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        public static void ExecutaSQL(string sql)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
    }
}
