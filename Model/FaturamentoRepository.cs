
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Model
{
    public class FaturamentoRepository
    {
        public string Insert(Faturamento faturamento)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                MySqlCommand SqlCmd = new MySqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO Faturamento (id_Usuario, id_Plano, vencimento, data_compra) VALUES (@pId_Usuario, @pId_Plano, @pVencimento, @pData_compra)",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("pId_Usuario", faturamento.id_Usuario);
                SqlCmd.Parameters.AddWithValue("pId_Plano", faturamento.id_Plano);
                SqlCmd.Parameters.AddWithValue("pVencimento", faturamento.vencimento);
                SqlCmd.Parameters.AddWithValue("pData_compra", faturamento.data_compra);

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

        public string Update(Faturamento faturamento)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("UPDATE Faturamento SET " + " id_Usuario =  @pId_Usuario, id_Plano =  @pId_Plano, vencimento = @pVencimento, data_compra = @pData_compra" + " WHERE id_faturamento = @pId_faturamento ");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pId_Usuario", faturamento.id_Usuario);
                SqlCmd.Parameters.AddWithValue("pId_Plano", faturamento.id_Plano);
                SqlCmd.Parameters.AddWithValue("pVencimento", faturamento.vencimento);
                SqlCmd.Parameters.AddWithValue("pData_compra", faturamento.data_compra);
                SqlCmd.Parameters.AddWithValue("pId_faturamento", faturamento.id_faturamento);

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

        public string Remove(int id_faturamento)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("DELETE FROM Faturamento " +
                                    "WHERE id_faturamento = @pId_faturamento ");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pId_faturamento", id_faturamento);

                //executa o stored procedure
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
            DataTable DtResultado = new DataTable("Faturamento");
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from Faturamento";

                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = Connection.SqlCon;
                SqlCmd.CommandText = sqlSelect;
                SqlCmd.CommandType = CommandType.Text;
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public String getPrice(int id_plano)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                String sqlSelect = "select valor from plano where id_plano=@pId_plano"; ;

                MySqlCommand SqlCmd = new MySqlCommand(sqlSelect, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("@pId_plano", id_plano);
                object result = SqlCmd.ExecuteScalar();

                if (result != null)
                {
                    resp = result.ToString();
                }
                else
                {
                    resp = "Valor não encontrado";
                }
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

        public String getNomePlano(int id_plano)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                String sqlSelect = "select nome_plano from plano where id_plano=@pId_plano"; ;

                MySqlCommand SqlCmd = new MySqlCommand(sqlSelect, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("@pId_plano", id_plano);
                object result = SqlCmd.ExecuteScalar();

                if (result != null)
                {
                    resp = result.ToString();
                }
                else
                {
                    resp = "Valor não encontrado";
                }
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


        public Dictionary<int, double> ObterFaturamentoMensalPorAno(int ano)
        {
            Dictionary<int, double> faturamentoPorMes = new Dictionary<int, double>();
            try
            {
                Connection.getConnection();
                String sqlSelect = "SELECT MONTH(f.data_compra) AS mes, SUM(p.valor) AS totalMensal FROM Faturamento f JOIN plano p ON f.id_Plano = p.id_plano WHERE YEAR(f.data_compra) = @pAno GROUP BY MONTH (f.data_compra) ORDER BY MONTH (f.data_compra)";

                MySqlCommand cmd = new MySqlCommand(sqlSelect, Connection.SqlCon);
                cmd.Parameters.AddWithValue("@pAno", ano);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int mes = reader.GetInt32("mes");
                    double valorTotal = reader.GetDouble("totalMensal");
                    faturamentoPorMes[mes] = valorTotal;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
               faturamentoPorMes = null;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }

            return faturamentoPorMes;
        }

        public Dictionary<int, int> ObterPlanoMaisAdquirido()
        {
            Dictionary<int, int> planoMaisAdquirido = new Dictionary<int, int>();
            try
            {
                Connection.getConnection();
                String sqlSelect = "SELECT id_plano, COUNT(*) AS totalPessoas FROM pessoa where id_perfil = 1 group by id_plano;";

                MySqlCommand cmd = new MySqlCommand(sqlSelect, Connection.SqlCon);
               

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idPlano = reader.GetInt32("id_plano");
                    int totalPessoas = reader.GetInt32("totaPessoas");
                    planoMaisAdquirido[idPlano] = totalPessoas;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                planoMaisAdquirido = null;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }

            return planoMaisAdquirido;
        }
    }
}
