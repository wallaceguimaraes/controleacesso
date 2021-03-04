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
    public class PessoaDao
    {

        
        public int IncluirPessoa(Pessoa pessoa)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "insert into pessoa (nome,cpf,dt_nasc,foto,rg,obs,email,contato)"
                + "values (?nome,?cpf,?dt_nasc,?foto,rg,obs,email,contato)";
            Mysqlcom.Parameters.AddWithValue("?nome", pessoa.GetNome());
            Mysqlcom.Parameters.AddWithValue("?cpf", pessoa.GetCpf());
            Mysqlcom.Parameters.AddWithValue("?dt_nasc", pessoa.GetDtNascimento());
            Mysqlcom.Parameters.AddWithValue("?foto", pessoa.GetImagem());
            Mysqlcom.Parameters.AddWithValue("?rg", pessoa.GetRg());
            Mysqlcom.Parameters.AddWithValue("?obs", pessoa.GetObs());
            Mysqlcom.Parameters.AddWithValue("?email", pessoa.GetEmail());
            Mysqlcom.Parameters.AddWithValue("?contato", pessoa.GetContato());

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



        public DataTable ListarPessoa()
        {   
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select pessoa_id as codigo, nome as Nome,cpf as CPF, dt_nasc as Nascimento,foto, rg as RG, obs as Observação," +
                " email as Email, contato as Contato from pessoa p where p.ativo='SIM' order by nome";
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
