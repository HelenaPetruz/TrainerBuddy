using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cond_pagamentoRepository
    {
        public string Insert(Cond_pagamento cond_Pagamento)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                MySqlCommand SqlCmd = new MySqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO cond_pagamento (id_cond_pagamento, numero_de_conta, nome, id_plano) VALUES (@pId_cond_pagamento, @pNumero_de_conta, @pNome,@pId_plano)",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("pId_cond_pagamento", cond_Pagamento.id_cond_pagamento);
                SqlCmd.Parameters.AddWithValue("pNumero_de_conta", cond_Pagamento.numero_de_conta);
                SqlCmd.Parameters.AddWithValue("pNome", cond_Pagamento.nome);
                SqlCmd.Parameters.AddWithValue("pId_plano", cond_Pagamento.id_plano);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public string Update(Cond_pagamento cond_pagamento)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                string updateSql = String.Format("UPDATE cond_pagamento SET" + " id_cond_pagamento = @pId_cond_pagamento, numero_de_conta = @pNumero_de_conta, nome = @pNome, id_plano = @pId_plano" + " WHERE id_cond_pagamento = @pId_cond_pagamento");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);

                SqlCmd.Parameters.AddWithValue("pId_cond_pagamento", cond_pagamento.id_cond_pagamento);
                SqlCmd.Parameters.AddWithValue("pNumero_de_conta", cond_pagamento.numero_de_conta);
                SqlCmd.Parameters.AddWithValue("pNome", cond_pagamento.nome);
                SqlCmd.Parameters.AddWithValue("pId_plano", cond_pagamento.id_plano);
                SqlCmd.Parameters.AddWithValue("pId_cond_pagamento", cond_pagamento.id_cond_pagamento);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }

            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;

        }

        public string Remove(int id_cond_pagamento)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                string updateSql = String.Format("DELETE FROM cond_pagamento" + " WHERE id_con_pagamento = @pId_cond_pagamento");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);


                SqlCmd.Parameters.AddWithValue("pId_con_pagamento", id_cond_pagamento);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;

        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from cond_pagamento";
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = Connection.SqlCon;
                SqlCmd.CommandText = sqlSelect;
                SqlCmd.CommandType = CommandType.Text;
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;

        }

        public DataTable FilterByName (string pNome)
        {
            DataTable DtResultado = new DataTable("cond_pagamento");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM cond_pagamento WHERE nome LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM cond_pagamento");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome))
                    SqlCmd.Parameters.AddWithValue("pNome", pNome);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
