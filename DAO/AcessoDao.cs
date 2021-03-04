using AcessoControle.DAO;
using ControllAcess.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.DAO
{
    public class AcessoDao
    {


        public DataTable ListarAcessoHoje()
        {
            string data = DateTime.Now.ToString();
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select a.acesso_id as codigo, p.nome as Nome,c.numero as Cartão, " +
                "a.entrada as Entrada, a.ativo as Ativo from acesso a inner join pessoa p on a.pessoa_id=p.pessoa_id " +
                "inner join cartao c on a.cartao_id= c.cartao_id where a.ativo='SIM' and a.data =str_to_date('" + data + "','%d/%m/%Y') order by a.entrada desc";
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


        public int IncluirAcesso(Acesso acesso)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            string hora = DateTime.Now.ToString("%H:%m:%s");


            if (acesso.GetEventoId()==0) {
                Mysqlcom.CommandText = "insert into acesso (cartao_id,pessoa_id,local_id,data,entrada)"
               + "values (?cartao_id,?pessoa_id,?local_id,str_to_date(?data,'%d/%m/%Y'),str_to_date('"+hora+"','%H:%i:%s'))";
            }
            else
            {
                Mysqlcom.CommandText = "insert into acesso (cartao_id,pessoa_id,evento_id,local_id,data,entrada)"
               + "values (?cartao_id,?pessoa_id,?evento_id,?local_id,str_to_date(?data,'%d/%m/%Y'),str_to_date('" + hora + "','%H:%i:%s'))";
            }
           

            Mysqlcom.Parameters.AddWithValue("?cartao_id", acesso.GetCartaoId());
            Mysqlcom.Parameters.AddWithValue("?pessoa_id", acesso.GetPessoa_id());
            Mysqlcom.Parameters.AddWithValue("?evento_id", acesso.GetEventoId());
            Mysqlcom.Parameters.AddWithValue("?local_id", acesso.GetLocalId());
            Mysqlcom.Parameters.AddWithValue("?data", acesso.GetData());
           

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





    }
}