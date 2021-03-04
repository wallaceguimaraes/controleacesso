using AcessoControle.DAO;
using ControllAcess.Model.Entity;
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
   public class ContatoDao
    {

        public DataTable BuscarContatosPorID(int ID)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select contato_id as codigo,responsavel as Responsável, contato as Contato,ramal as Ramal," +
                "local_id, ativo as Ativo from contato c  where c.ativo='SIM' and c.local_id=" + ID +" order by c.contato_id";
            DataTable dados = new DataTable();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
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

        public int ExcluirContato(int contatoID)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update contato set ativo = 'NÃO' where contato_id= ?contato_id";
            Mysqlcom.Parameters.AddWithValue("?contato_id", contatoID);
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

        public int AtualizarContato(Contato contato)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update contato set contato = ?contato, responsavel = ?responsavel, local_id = ?local_id," +
                "ramal = ?ramal, ativo = ?ativo where contato_id= ?contato_id";
            Mysqlcom.Parameters.AddWithValue("?contato_id", contato.GetContato_id());
            Mysqlcom.Parameters.AddWithValue("?responsavel", contato.GetResponsavel());
            Mysqlcom.Parameters.AddWithValue("?local_id", contato.GetLocalID());
            Mysqlcom.Parameters.AddWithValue("?ramal", contato.GetRamal());
            Mysqlcom.Parameters.AddWithValue("?ativo", contato.GetAtivo());
            Mysqlcom.Parameters.AddWithValue("?contato", contato.GetContato());
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

        public DataTable PesquisarContato(Contato contato)
        {
            string busca = "";
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            ArrayList filtro = new ArrayList();
            if (contato.GetAtivo() == "" || contato.GetAtivo() == null) { contato.SetAtivo("SIM"); }
            if (!contato.GetContato().Equals(""))
            {
                filtro.Add("c.contato like '%"+contato.GetContato()+"%'");
            }
            if (!contato.GetRamal().Equals(""))
            {
                filtro.Add("c.ramal like '%"+contato.GetRamal()+"%'");
            }
            if (!contato.GetResponsavel().Equals("") || !string.IsNullOrWhiteSpace(contato.GetResponsavel()))
            {
                filtro.Add("c.responsavel like '%"+contato.GetResponsavel()+"%'");
            }
            filtro.Add("c.ativo='"+contato.GetAtivo()+"'");
            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }
            comando.CommandText = "select contato_id as codigo,responsavel as Responsável, contato as Contato,ramal as Ramal," +
                "local_id, ativo as Ativo from contato c " + busca+"and local_id="+contato.GetLocalID()+"";
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

        public int IncluirContato(Contato contato)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "insert into contato (contato,responsavel,ramal,local_id)"
                + "values (?contato,?responsavel,?ramal,?local_id)";
            Mysqlcom.Parameters.AddWithValue("?contato", contato.GetContato());
            Mysqlcom.Parameters.AddWithValue("?responsavel", contato.GetResponsavel());
            Mysqlcom.Parameters.AddWithValue("?ramal", contato.GetRamal());
            Mysqlcom.Parameters.AddWithValue("?local_id", contato.GetLocalID());
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

        public DataTable ListarContato()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            string sql;      
            sql = "select contato_id as codigo,responsavel as Responsável, contato as Contato,ramal as Ramal," +
                "local_id, ativo as Ativo from contato c  where c.ativo='SIM' order by c.contato_id";
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
