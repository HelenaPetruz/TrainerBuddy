using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class PessoaRepository
    {
        public PessoaRepository()
        {
        }

        public string Insert (Pessoa pessoa)
        {
           string resp="";
            try
            {
                Connection.getConnection();
                MySqlCommand SqlCmd = new MySqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO pessoa (nome_usuario,cpf,email,senha,id_plano,id_perfil) VALUES (@pNome_usuario,@pCpf,@pEmail,@pSenha,@pId_plano,@pId_perfil)",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("pNome_usuario", pessoa.nome_usuario);
                SqlCmd.Parameters.AddWithValue("pCpf", pessoa.cpf);
                SqlCmd.Parameters.AddWithValue("pEmail", pessoa.email);
                SqlCmd.Parameters.AddWithValue("pSenha", pessoa.senha);
                SqlCmd.Parameters.AddWithValue("pId_plano", pessoa.id_plano);
                SqlCmd.Parameters.AddWithValue("pId_perfil", pessoa.id_perfil);

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

        public string Update(Pessoa pessoa)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                string updateSql = String.Format("UPDATE pessoa SET" +" nome_usuario = @pNome_usuario, cpf = @pCpf, email = @pEmail"  + " WHERE idpessoa = @pIdpessoa");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);


                SqlCmd.Parameters.AddWithValue("pNome_usuario", pessoa.nome_usuario);
                SqlCmd.Parameters.AddWithValue("pCpf", pessoa.cpf);
                SqlCmd.Parameters.AddWithValue("pEmail", pessoa.email);
                SqlCmd.Parameters.AddWithValue("@pIdpessoa", pessoa.idpessoa);


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

        public string Remove (int idpessoa)
        {
            string resp = "";
            try
            {
                Connection.getConnection();
                string updateSql = String.Format("DELETE FROM pessoa" + "WHERE idpessoa = @pIdpessoa");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);


                SqlCmd.Parameters.AddWithValue("pIdpessoa", idpessoa);

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
            DataTable DtResultado = new DataTable("pessoa");
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from pessoa";
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


        public DataTable FilterByName (string pNome_usuario)
        {
            DataTable DtResultado = new DataTable("pessoa");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome_usuario))
                {
                    selectSql = String.Format("SELECT * FROM pessoa WHERE nome_usuario LIKE @pNome_usuario");
                    pNome_usuario = '%' + pNome_usuario + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM pessoa");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome_usuario))
                    SqlCmd.Parameters.AddWithValue("pNome_usuario", pNome_usuario);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable FilterByEmail(string pEmail)
        {
            DataTable DtResultado = new DataTable("pessoa");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pEmail))
                {
                    selectSql = String.Format("SELECT * FROM pessoa WHERE email LIKE @pEmail");
                    pEmail = '%' + pEmail + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM pessoa");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pEmail))
                    SqlCmd.Parameters.AddWithValue("pEmail", pEmail);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public string ValidaEntrada(string pEmail, string pSenha)
        {
            string selectSql;
            string resp = "";

            try
            {
                Connection.getConnection();
                selectSql = "SELECT COUNT(*) FROM pessoa WHERE email = @pEmail AND senha = @pSenha";

                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);

                SqlCmd.Parameters.AddWithValue("@pEmail", pEmail);
                SqlCmd.Parameters.AddWithValue("@pSenha", pSenha);

             

                int count = Convert.ToInt32(SqlCmd.ExecuteScalar());

               

                resp = count > 0 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = "Erro: " + ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public string Cadastro(string pEmail, string pSenha, string Repita)
        {
            string resp = "";
            if (pSenha == Repita)
            {

                try
                {
                    Connection.getConnection();
                    MySqlCommand SqlCmd = new MySqlCommand
                    {
                        Connection = Connection.SqlCon,
                        CommandText = "INSERT INTO pessoa (email,senha,id_plano,id_perfil) VALUES (@pEmail,@pSenha,1,2)",
                        CommandType = CommandType.Text
                    };
                    SqlCmd.Parameters.AddWithValue("pEmail", pEmail);
                    SqlCmd.Parameters.AddWithValue("pSenha", pSenha);
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
            }
            else
            {
                resp = "FALHA";
            }
            return resp;

        }

    }
}
