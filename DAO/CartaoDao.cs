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
    public class CartaoDao
    {
        public int ValidaNumero(string numero)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from cartao c where c.numero='" + numero + "'";
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

        public int ExcluirCartao(int cartaoID)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update cartao set ativo = 'NÃO' where cartao_id=?ativo and disponivel='SIM'";
            Mysqlcom.Parameters.AddWithValue("?ativo", cartaoID);
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

        public int AtualizarCartao(Cartao cartao)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            string inicio;
            if (cartao.GetDisponivel().Equals("NÃO DISPONÍVEL"))
            {   inicio = DateTime.Now.ToString("%H:%m:%s");
                Mysqlcom.CommandText = "update cartao set inicio =?inicio, disponivel =?disponivel where cartao_id= ?cartao_id";
                Mysqlcom.Parameters.AddWithValue("?disponivel", "NÃO");
                Mysqlcom.Parameters.AddWithValue("?inicio",inicio);
            }
            else
            {
           
                Mysqlcom.CommandText = "update cartao set numero = ?numero, tipo = ?tipo," +
                " inicio = ?inicio, fim = ?fim, ativo = ?ativo where cartao_id= ?cartao_id";
                Mysqlcom.Parameters.AddWithValue("?inicio", cartao.GetPeriodoInicio());

            }

            Mysqlcom.Parameters.AddWithValue("?cartao_id", cartao.GetCartao_id());
            Mysqlcom.Parameters.AddWithValue("?numero", cartao.GetNumero());
            Mysqlcom.Parameters.AddWithValue("?tipo", cartao.GetTipo());
            Mysqlcom.Parameters.AddWithValue("?fim", cartao.GetPeriodoFim());
            Mysqlcom.Parameters.AddWithValue("?ativo", cartao.GetAtivo());

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

        public DataTable PesquisarCartao(Cartao cartao)
        {
            string busca = "";
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            ArrayList filtro = new ArrayList();

            if (cartao.GetAtivo() == "") { cartao.SetAtivo("SIM"); }
            if (!cartao.GetNumero().Equals("")){ filtro.Add("c.numero like '%" + cartao.GetNumero() + "%'"); }
            filtro.Add("c.ativo='" + cartao.GetAtivo() + "'");

            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }
            
                comando.CommandText = "select cartao_id as codigo, numero as Número," +
                "tipo as Tipo, inicio as Início, fim as Fim, disponivel as Disponível, ativo as Ativo from cartao c " + busca;

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

        public DataTable PesquisarCartaoDisponivel(Cartao cartao)
        {
            string busca = "";
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            ArrayList filtro = new ArrayList();

            if (cartao.GetAtivo() == "" || cartao.GetAtivo()==null) { cartao.SetAtivo("SIM"); }
            if (!cartao.GetNumero().Equals("")) { filtro.Add("c.numero like '%" + cartao.GetNumero() + "%'"); }
            if (!cartao.GetTipo().Equals("")) { filtro.Add("c.tipo like '%" + cartao.GetTipo() + "%'"); }

            filtro.Add("c.ativo='" + cartao.GetAtivo() + "'");

            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }

            comando.CommandText = "select cartao_id as codigo, numero as Número," +
            "tipo as Tipo, inicio as Início, fim as Fim, disponivel as Disponível, " +
            "ativo as Ativo from cartao c " + busca+" and disponivel='SIM' order by c.cartao_id";

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

        public int IncluirCartao(Cartao cartao)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "insert into cartao (numero,tipo,inicio,fim)"
                + "values (?numero,?tipo,?inicio,?fim)";
            Mysqlcom.Parameters.AddWithValue("?numero", cartao.GetNumero());
            Mysqlcom.Parameters.AddWithValue("?tipo", cartao.GetTipo());
            Mysqlcom.Parameters.AddWithValue("?inicio", cartao.GetPeriodoInicio());
            Mysqlcom.Parameters.AddWithValue("?fim", cartao.GetPeriodoFim());

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

        public DataTable ListarCartao()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            Cartao cartao = new Cartao();
            comando.CommandText = "select cartao_id as codigo, numero as Número,tipo as Tipo, " +
                "inicio as Início, fim as Fim, disponivel as Disponível, ativo as Ativo from cartao c where c.ativo='SIM' order by c.numero";
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

        public DataTable ListarCartaoDisponivel()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select cartao_id as codigo, numero as Número,tipo as Tipo, " +
                "inicio as Início, fim as Fim, disponivel as Disponível, ativo as Ativo from cartao c where c.ativo='SIM' and c.disponivel='SIM' order by c.numero";
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
