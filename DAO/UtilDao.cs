using AcessoControle.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.DAO
{
    public class UtilDao
    {

        public DataTable PesquisarPessoaTipoPorCPF(string cpf)
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT distinct(p.pessoa_id) as codigo,p.nome as Nome,p.cpf as CPF,p.foto as Foto,obs, CASE WHEN(SELECT count(cad.cadastro_id) FROM cadastro cad " +
                "inner JOIN pessoa p ON cad.pessoa_id = p.pessoa_id WHERE cad.ativo = 'SIM' AND p.ativo = 'SIM' AND p.cpf = '" + cpf + "') >= 1 " +
                "THEN 'FUNCIONÁRIO' WHEN(SELECT count(cond.condominio_id) FROM condominio cond " +
                "inner JOIN pessoa p ON cond.pessoa_id = p.pessoa_id " +
                "WHERE cond.ativo = 'SIM' AND p.cpf = '" + cpf + "') >= 1 THEN 'CONDÔMINO' " +
                "WHEN(SELECT COUNT(p.cpf) FROM pessoa p WHERE p.ativo = 'SIM' AND p.cpf = '" + cpf + "') >= 1 " +
                "THEN 'VISITANTE' ELSE 'NÃO CADASTRADO' END AS Tipo FROM pessoa p " +
                "left join condominio cond ON(cond.pessoa_id = p.pessoa_id) " +
                "left join cadastro cad ON(cad.pessoa_id = p.pessoa_id) WHERE p.cpf='" + cpf + "'";
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


        public int retornaEventoID(int localId)
        {
            string hora=DateTime.Now.ToString("%H:%m%s");
             hora = hora.Substring(0, 5);
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT *, CASE " +
                "WHEN(SELECT count(e.evento_id) FROM evento e " +
                "WHERE e.data = curdate() " +
                "AND e.hora_fim > '"+hora+"' AND e.local_id = "+localId+" AND e.ativo = 'SIM') >= 1 " +
                "THEN(SELECT e.evento_id FROM evento e " +
                "WHERE e.data = curdate() " +
                "AND e.hora_fim > '"+hora+"' AND e.local_id = "+localId+" AND e.ativo = 'SIM') " +
                "ELSE 0 END AS ID " +
                "FROM evento e";


            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                Mysqldap.Fill(Mysqldset);

                int id;
                id = (Convert.ToInt32(Mysqldset.Tables[0].Rows[0]["ID"]));

                return id;
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


        public int retornaUltimoID()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select last_insert_id() as id from dual";
            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                Mysqldap.Fill(Mysqldset);

                int id;
                id = (Convert.ToInt32(Mysqldset.Tables[0].Rows[0]["id"]));

                return id;
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
