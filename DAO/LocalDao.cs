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
   public class LocalDao
    {

        public ArrayList VerificaDataEventoLocal()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT distinct(local_id) FROM evento WHERE DATA < CURDATE() AND local_id NOT IN " +
                "(SELECT local_id FROM evento WHERE DATA > CURDATE()) ";
            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                Mysqldap.Fill(Mysqldset);
                int cont = Mysqldset.Tables[0].Rows.Count;
                ArrayList localId = new ArrayList();
                for (int i = 0; i < cont; i++)
                {
                    localId.Add(Convert.ToInt32(Mysqldset.Tables[0].Rows[i]["local_id"]));
                }
                return localId;
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

        public void AtualizaLocalPorData(ArrayList localId)
        {
            int cont = localId.Count;
            LocalDao localDao = new LocalDao();
            for (int i = 0; i < cont; i++)
            {
                localDao.AtualizarLocalPorID(Convert.ToInt32(localId[i]), 1);
            }
        }

        public Local BuscarLocalPorID(int ID)
        {
            Local local = new Local();
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "select * from local l where l.local_id="+ID+"";
            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                Mysqldap.Fill(Mysqldset);
                local.SetBloco(Mysqldset.Tables[0].Rows[0]["bloco"].ToString());
                local.SetAndar(Mysqldset.Tables[0].Rows[0]["andar"].ToString());                          
                local.SetSala(Mysqldset.Tables[0].Rows[0]["sala"].ToString());
                return local;
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

        public int ValidaSala(string sala)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from local l where l.sala='" +sala+ "'";
            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                Mysqldap.Fill(Mysqldset);
                if (Mysqldset.Tables[0].Rows.Count == 0)
                {
                    return 0;
                }
                return 1;
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

        public int ExcluirLocal(int localID)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update local set ativo = 'NÃO' where local_id= ?local_id and disponivel_evento = 'SIM'" +
                " and locado = 'NÃO'";
            Mysqlcom.Parameters.AddWithValue("?local_id", localID);
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

        public int AtualizarLocal(Local local)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update local set bloco = ?bloco, andar = ?andar, sala = ?sala, ativo = ?ativo where local_id= ?local_id";
            Mysqlcom.Parameters.AddWithValue("?local_id", local.GetLocal_id());
            Mysqlcom.Parameters.AddWithValue("?bloco", local.GetBloco());
            Mysqlcom.Parameters.AddWithValue("?andar", local.GetAndar());
            Mysqlcom.Parameters.AddWithValue("?sala", local.GetSala());
            Mysqlcom.Parameters.AddWithValue("?ativo", local.GetAtivo());       
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

        public int AtualizarLocalPorID(int ID,int flag)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            if (flag == 0)
            {
                Mysqlcom.CommandText = "update local set disponivel_evento = 'NÃO' where local_id= ?local_id";
            }
            else
            {
                Mysqlcom.CommandText = "update local set disponivel_evento = 'SIM' where local_id= ?local_id";
            }
            Mysqlcom.Parameters.AddWithValue("?local_id",ID);
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

        public DataTable PesquisarLocalNaoAlocado(Local local)
        {
            string busca = "";

            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            ArrayList filtro = new ArrayList();
            if (local.GetAtivo() == null || local.GetAtivo() == "") { local.SetAtivo("SIM"); }
            if (!local.GetBloco().Equals(""))
            {
                filtro.Add("l.bloco like '%" + local.GetBloco() + "%'");
            }
            if (!local.GetAndar().Equals(""))
            {
                filtro.Add("l.andar like '%" + local.GetAndar() + "%'");
            }
            if (!local.GetSala().Equals(""))
            {
                filtro.Add("l.sala like '%" + local.GetSala() + "%'");
            }
            filtro.Add("l.ativo='" + local.GetAtivo() + "'");
            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }
            comando.CommandText = "SELECT local_id as codigo, bloco as Bloco , andar as Andar, sala as Sala," +
                " disponivel_evento as Disponível, locado as Locado, ativo as Ativo from local l " + busca + " AND l.local_id NOT IN (" +
                "(CASE WHEN(SELECT count(loca.local_id) b FROM local loca " +
                "INNER JOIN empresa em ON loca.local_id = em.local_id WHERE em.ativo = 'SIM') >= 1 " +
                "THEN(SELECT lo.local_id FROM local lo INNER JOIN empresa e ON lo.local_id = e.local_id " +
                "WHERE e.ativo = 'SIM') ELSE 0 END ), " +
                "(CASE WHEN(SELECT count(loc.local_id) c FROM local loc " +
                "INNER JOIN condominio c ON loc.local_id = c.local_id WHERE c.ativo = 'SIM') >= 1 " +
                "THEN(SELECT ll.local_id FROM local ll INNER JOIN condominio co ON ll.local_id = co.local_id WHERE co.ativo = 'SIM') " +
                "ELSE 0 END )) GROUP BY local_id";
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

        public DataTable PesquisarLocal(Local local)
        {
            string busca = "";
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            DataSet Mysqldset = new DataSet();
            ArrayList filtro = new ArrayList();
            if (local.GetAtivo()==null||local.GetAtivo()=="") { local.SetAtivo("SIM"); }
            if (!local.GetBloco().Equals(""))
            {
                filtro.Add("l.bloco like '%" + local.GetBloco() + "%'");
            }
            if (!local.GetAndar().Equals(""))
            {
                filtro.Add("l.andar like '%" + local.GetAndar() + "%'");
            }
            if (!local.GetSala().Equals(""))
            {
                filtro.Add("l.sala like '%" + local.GetSala() + "%'");
            }
            filtro.Add("l.ativo='" + local.GetAtivo() + "'");
            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }
            comando.CommandText = "select local_id as codigo, bloco as Bloco,andar as Andar, sala as Sala," +
                " disponivel_evento as Disponível, locado as Locado, ativo as Ativo from local l " + busca;
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

        public int IncluirLocal(Local local)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            DataSet Mysqldset = new DataSet();
            Mysqlcom.CommandText = "insert into local (bloco,andar,sala)"
                + "values (?bloco,?andar,?sala)";
            Mysqlcom.Parameters.AddWithValue("?bloco", local.GetBloco());
            Mysqlcom.Parameters.AddWithValue("?andar", local.GetAndar());
            Mysqlcom.Parameters.AddWithValue("?sala", local.GetSala());          
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

        public DataTable ListarLocalPorID(int ID)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select local_id as codigo, bloco as Bloco,andar as Andar, sala as Sala,disponivel_evento as Disponível,locado as Locado, ativo as Ativo " +
                "from local l where l.ativo='SIM' and l.local_id="+ID+" order by l.sala";
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

        public DataTable ListarLocalNaoAlocado()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT local_id as codigo, bloco as Bloco , andar as Andar, sala as Sala," +
                " disponivel_evento as Disponível,locado as Locado, ativo as Ativo from local l WHERE l.ativo = 'SIM' AND l.local_id NOT IN (" +
                "(CASE WHEN(SELECT count(loca.local_id) b FROM local loca " +
                "INNER JOIN empresa em ON loca.local_id = em.local_id WHERE em.ativo = 'SIM') >= 1 " +
                "THEN(SELECT lo.local_id FROM local lo INNER JOIN empresa e ON lo.local_id = e.local_id " +
                "WHERE e.ativo = 'SIM') ELSE 0 END ), " +
                "(CASE WHEN(SELECT count(loc.local_id) c FROM local loc " +
                "INNER JOIN condominio c ON loc.local_id = c.local_id WHERE c.ativo = 'SIM') >= 1 " +
                "THEN(SELECT ll.local_id FROM local ll INNER JOIN condominio co ON ll.local_id = co.local_id WHERE co.ativo = 'SIM') " +
                "ELSE 0 END ))";
            DataSet Mysqldset = new DataSet();
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

        public DataTable ListarLocal()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select local_id as codigo, bloco as Bloco,andar as Andar, sala as Sala,disponivel_evento as Disponível," +
                "locado as Locado, ativo as Ativo from local l where l.ativo='SIM' order by l.sala";
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
