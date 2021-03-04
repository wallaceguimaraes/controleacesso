using AcessoControle.DAO;
using AcessoControle.Model.Entity;
using ControllAcess.Model.Entity;
using ControllAcess.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.DAO
{
    public class EventoDao
    {
        Usuario usu = new Usuario();

        public EventoDao()
        {
            usu = Sessao.getInstance().getUsuario();
        }



        public int ValidarHoraEvento(string sala, string data,string inicio, string final)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            string ini =inicio+":00";
            string fim = final + ":00";

            comando.CommandText = " SELECT e.evento_id, " +
                "CASE" +
                " WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id " +
                        "WHERE l.sala = '"+sala+"' AND e.data = str_to_date('"+data+"','%d/%m/%Y') AND STR_TO_DATE('"+ini+"', '%H:%i:%s') <= e.hora_inicio AND STR_TO_DATE('"+fim+"', '%H:%i:%s') <= e.hora_fim AND STR_TO_DATE('"+fim+"', '%H:%i:%s') >= e.hora_inicio) >= 1 " +
                "then 1 " +
                        "WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id " +
                                "WHERE l.sala = '"+sala+ "' AND e.data = str_to_date('" + data + "','%d/%m/%Y') AND STR_TO_DATE('" + ini+"', '%H:%i:%s') <= e.hora_inicio AND STR_TO_DATE('"+fim+"', '%H:%i:%s') >= e.hora_fim " +
                                "AND STR_TO_DATE('"+fim+"', '%H:%i:%s') >= e.hora_inicio) >= 1 " +
                "then 1 " +
                        "WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id WHERE l.sala = '"+sala+ "' AND e.data = str_to_date('" + data + "','%d/%m/%Y') AND " +
                                "STR_TO_DATE('"+ini+"', '%H:%i:%s') <= e.hora_inicio AND STR_TO_DATE('"+fim+"', '%H:%i:%s') = e.hora_inicio) >= 1 " +
                "then 1 " +
                        "WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id " +
                                "WHERE l.sala = '"+sala+ "' AND e.data = str_to_date('" + data + "','%d/%m/%Y') AND STR_TO_DATE('" + ini+"', '%H:%i:%s') = e.hora_inicio AND STR_TO_DATE('"+fim+"', '%H:%i:%s') <= e.hora_fim) >= 1 " +
                "then 1" +
                        " WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id WHERE l.sala = '"+sala+ "' AND e.data = str_to_date('" + data + "','%d/%m/%Y') AND " +
                                "STR_TO_DATE('"+ini+"', '%H:%i:%s') = e.hora_inicio AND STR_TO_DATE('"+fim+"', '%H:%i:%s') >= e.hora_fim) >= 1 " +
                "then 1 " +
                        "WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id WHERE l.sala = '"+sala+ "' AND e.data = str_to_date('" + data + "','%d/%m/%Y') AND " +
                                "STR_TO_DATE('"+ini+"', '%H:%i:%s') > e.hora_inicio AND STR_TO_DATE('"+ini+"', '%H:%i:%s') <= e.hora_fim " +
                                "AND STR_TO_DATE('"+fim+"', '%H:%i:%s') >= e.hora_fim) >= 1 " +
                "then 1 " +
                "WHEN (SELECT count(e.evento_id) from evento e INNER JOIN local l ON e.local_id = l.local_id WHERE l.sala = '" + sala + "' AND e.data = str_to_date('" + data + "','%d/%m/%Y') AND " +
                                "STR_TO_DATE('" + ini + "', '%H:%i:%s') >= e.hora_inicio AND STR_TO_DATE('" + fim + "', '%H:%i:%s') <= e.hora_fim ) >= 1 " +
                "then 1 " +
                "ELSE 2 END AS horario FROM evento e  ";
           try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                DataTable dados = new DataTable();
                int flag;
                Mysqldap.Fill(dados);
                flag =Convert.ToInt32(dados.Rows[0]["horario"]);
                return flag;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }


        }        

        public int ExcluirEvento(int eventoID)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update evento set ativo = 'NÃO' where evento_id= ?evento_id";
            Mysqlcom.Parameters.AddWithValue("?evento_id", eventoID);
            try
            {
                Mysqlcon.Open();
                Mysqlcom.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
            finally
            {
                Mysqlcon.Close();
            }
        }

        public string BuscarResponsavelPorId(int ID)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            string sql;
            sql = "SELECT distinct(l.local_id), " +
                "CASE WHEN (SELECT count(emp.empresa_id) FROM empresa emp " +
                "inner JOIN local l ON emp.local_id = l.local_id " +
                "WHERE l.ativo = 'SIM'AND emp.ativo='SIM' AND l.local_id = "+ID+") >= 1 " +
                "THEN CONCAT('EMPRESA : ',(SELECT emp.empresa FROM empresa emp " +
                "inner JOIN local l ON emp.local_id = l.local_id WHERE l.ativo = 'SIM' AND emp.ativo='SIM' AND l.local_id = " + ID + ")) " +
                "WHEN (SELECT count(cond.condominio_id) FROM condominio cond inner JOIN local l ON cond.local_id=l.local_id " +
                "WHERE l.ativo = 'SIM' AND cond.ativo='SIM' AND l.local_id = " + ID + " ) >= 1    " +
                "THEN CONCAT('CONDÔMINO : ', (SELECT p.nome FROM pessoa p INNER JOIN condominio cond on cond.pessoa_id = p.pessoa_id" +
                " INNER JOIN local l ON cond.local_id = l.local_id " +
                "WHERE l.ativo = 'SIM' AND cond.ativo='SIM' AND l.local_id = " + ID + ")) ELSE 'NÃO LOCADO' " +
                "END AS Nome FROM local l " +
                "right join condominio c ON(c.local_id = l.local_id)" +
                "right join pessoa p ON(p.pessoa_id = c.pessoa_id) " +
                "right join empresa e ON(e.local_id = l.local_id)";
            comando.CommandText = sql;
            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                DataSet dados = new DataSet();
                Mysqldap.Fill(dados);
                string nome;
                nome=(dados.Tables[0].Rows[0]["Nome"].ToString());
                return nome;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        public int AtualizarEvento(Evento evento)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update evento set descricao = ?descricao, tipo = ?tipo, participantes = ?participantes, data = str_to_date(?data,'%d/%m/%Y'), hora_inicio =str_to_date(?inicio,'%H:%i:%s')," +
                "hora_fim = str_to_date(?fim,'%H:%i:%s'),local_id = ?local_id where evento_id= ?evento_id";
            Mysqlcom.Parameters.AddWithValue("?evento_id",evento.GetEvento_id());
            Mysqlcom.Parameters.AddWithValue("?descricao",evento.GetDescricao());
            Mysqlcom.Parameters.AddWithValue("?tipo",evento.GetTipo());
            Mysqlcom.Parameters.AddWithValue("?participantes",evento.GetParticipantes());
            Mysqlcom.Parameters.AddWithValue("?data", evento.GetData());
            Mysqlcom.Parameters.AddWithValue("?inicio", evento.GetInicio());
            Mysqlcom.Parameters.AddWithValue("?fim", evento.GetFim());
            Mysqlcom.Parameters.AddWithValue("?local_id", evento.GetLocalId());
            try
            {
                Mysqlcon.Open();
                Mysqlcom.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
            finally
            {
                Mysqlcon.Close();
            }
        }
            
        public DataTable PesquisarEvento(Evento evento)
        {
            usu = Sessao.getInstance().getUsuario();
            string busca = "";
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            ArrayList filtro = new ArrayList();
            if (evento.GetAtivo() == ""||evento.GetAtivo()==null) { evento.SetAtivo("SIM"); }
            if (!evento.GetDescricao().Equals(""))
            {
                filtro.Add("e.descricao like '%" + evento.GetDescricao() + "%'");
            }
            if (!evento.GetTipo().Equals(""))
            {
                filtro.Add("e.tipo like '%" + evento.GetTipo() + "%'");
            }
            if (evento.GetData()!=null)
            {
                filtro.Add("e.data >= str_to_date('"+evento.GetData()+"','%d/%m/%Y')");
            }
            filtro.Add("e.ativo='" + evento.GetAtivo() + "'");
            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }
            if (usu.GetPerfil() == "ADMINISTRADOR")
            {
                comando.CommandText = "select evento_id as codigo, descricao as Descricao,tipo as Tipo,participantes as Participantes," +
                    " data as Data, hora_inicio as Início,hora_fim as Fim," +
                    "usuario_id,local_id, ativo as Ativo from evento e " + busca;
            }
            else
            {
                comando.CommandText = "select evento_id as codigo, descricao as Descricao,tipo as Tipo,participantes as Participantes," +
                    " data as Data, hora_inicio as Início,hora_fim as Fim," +
                    "usuario_id,local_id, ativo as Ativo from evento e " + busca+" and usuario_id ="+usu.GetUsuario_id();
            }
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                DataTable dados = new DataTable();
                Mysqldap.Fill(dados);

                return dados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        public int IncluirEvento(Evento evento)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "insert into evento (descricao,tipo,participantes,data,hora_inicio,hora_fim,usuario_id,local_id)"
                + "values (?descricao,?tipo,?participantes,str_to_date(?data,'%d/%m/%Y'),str_to_date(?inicio,'%H:%i:%s'),str_to_date(?fim,'%H:%i:%s'),?usuario_id,?local_id)";
            Mysqlcom.Parameters.AddWithValue("?descricao", evento.GetDescricao());
            Mysqlcom.Parameters.AddWithValue("?tipo", evento.GetTipo());
            Mysqlcom.Parameters.AddWithValue("?participantes", evento.GetParticipantes());
            Mysqlcom.Parameters.AddWithValue("?data", evento.GetData());
            Mysqlcom.Parameters.AddWithValue("?inicio", evento.GetInicio());
            Mysqlcom.Parameters.AddWithValue("?fim", evento.GetFim());
            Mysqlcom.Parameters.AddWithValue("?usuario_id", evento.GetUsuarioId());
            Mysqlcom.Parameters.AddWithValue("?local_id", evento.GetLocalId());
            try
            {
                Mysqlcon.Open();
                Mysqlcom.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
            finally
            {
                Mysqlcon.Close();
            }
        }

        public DataTable ListarEventoPorId(int ID)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            string sql;
                sql = "select evento_id as codigo, descricao as Descricao,tipo as Tipo,participantes as Participantes," +
                    " data as Data, hora_inicio as Início,hora_fim as Fim," +
                    "usuario_id,local_id, ativo as Ativo from evento e where e.ativo='SIM' and usuario_id="+ID+" order by e.Data desc";                    
            comando.CommandText = sql;
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                DataTable dados = new DataTable();
                Mysqldap.Fill(dados);
                return dados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ListarEvento(string data, int flag)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            string sql;

                if (flag == 1)
                {

                    sql = "select evento_id as codigo, descricao as Descricao,tipo as Tipo,participantes as Participantes," +
                        " data as Data, hora_inicio as Início,hora_fim as Fim," +
                        "usuario_id,local_id, ativo as Ativo from evento e where e.ativo='SIM' order by e.Data desc";
                }
                else
                {
                    sql = "select evento_id as codigo, descricao as Descricao,tipo as Tipo,participantes as Participantes," +
                        " data as Data, hora_inicio as Início,hora_fim as Fim," +
                        "usuario_id,local_id, ativo as Ativo from evento e where e.ativo='SIM' and e.data >= str_to_date('" + data + "','%d/%m/%Y')order by e.Data desc";
                }            
            comando.CommandText = sql;            
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                DataTable dados = new DataTable();
                Mysqldap.Fill(dados);
                return dados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
