using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Numerics;

namespace Model
{
    public class PlanoRepository
    {
        public string Insert(Plano plano)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                MySqlCommand SqlCmd = new MySqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO plano (nome_plano, valor) VALUES (@pNome_plano, @pValor)",
                    CommandType = CommandType.Text,
                };
                SqlCmd.Parameters.AddWithValue("pNome_plano", plano.nome_plano);
                SqlCmd.Parameters.AddWithValue("pValor", plano.valor);

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

        public string Update(Plano plano)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                string updateSql = String.Format("UPDATE plano SET " + "nome_plano = @pNome_plano, valor = @pValor " + "WHERE id_plano = @pId_plano");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);

                SqlCmd.Parameters.AddWithValue("pNome_plano", plano.nome_plano);
                SqlCmd.Parameters.AddWithValue("pValor", plano.valor);
                SqlCmd.Parameters.AddWithValue("pId_plano", plano.id_plano);

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

        public string Remove(int id_plano)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                string updateSql = String.Format("DELETE FROM plano " + "WHERE id_plano = @pId_plano");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);

                SqlCmd.Parameters.AddWithValue("pId_plano", id_plano);

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
            DataTable dt = new DataTable("plano");
            try
            {
                Connection.getConnection();
                String sqlSelect = "SELECT * FROM plano";
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

        public DataTable FilterByName (string pNome_plano)
        {
            DataTable dt = new DataTable("plano");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome_plano))
                {
                    selectSql = String.Format("SELECT * FROM plano WHERE nome_plano LIKE @pNome_plano")
                    pNome_plano = '%' + pNome_plano + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM plano");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome_plano))
                    SqlCmd.Parameters.AddWithValue("pNome_plano",pNome_plano);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;

        }
    }
}
