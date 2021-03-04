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
    public class EmpresaDao
    {
        public int ExcluirEmpresa(int empresaID)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update empresa set ativo = 'NÃO' where empresa_id= ?empresa_id";
            Mysqlcom.Parameters.AddWithValue("?empresa_id", empresaID);
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

        public int AtualizarEmpresa(Empresa empresa)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "update empresa set empresa = ?empresa, dt_locacao = str_to_date(?dt_locacao,'%d/%m/%Y'), razao_social = ?razao_social, cnpj = ?cnpj, ativo = ?ativo, local_id = ?local_id" +
                " where empresa_id= ?empresa_id";
            Mysqlcom.Parameters.AddWithValue("?empresa_id", empresa.GetEmpresa_id());
            Mysqlcom.Parameters.AddWithValue("?empresa", empresa.GetEmpresa());
            Mysqlcom.Parameters.AddWithValue("?dt_locacao", empresa.GetData());
            Mysqlcom.Parameters.AddWithValue("?razao_social", empresa.GetRazaoSocial());
            Mysqlcom.Parameters.AddWithValue("?cnpj", empresa.GetCnpj());
            Mysqlcom.Parameters.AddWithValue("?ativo", empresa.GetAtivo());
            Mysqlcom.Parameters.AddWithValue("?local_id", empresa.GetLocalId());
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

        public DataTable PesquisarEmpresa(Empresa empresa)
        {
            string busca = "";
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            ArrayList filtro = new ArrayList();
            if (empresa.GetAtivo() == "" || empresa.GetAtivo() == null) { empresa.SetAtivo("SIM"); }
            if (!empresa.GetEmpresa().Equals(""))
            {
                filtro.Add("e.empresa like '%" + empresa.GetEmpresa() + "%'");
            }
            if (!empresa.GetRazaoSocial().Equals(""))
            {
                filtro.Add("e.razao_social like '%" + empresa.GetRazaoSocial() + "%'");
            }
            if (empresa.GetData() != null)
            {
                filtro.Add("e.dt_locacao >= str_to_date('" + empresa.GetData() + "','%d/%m/%Y')");
            }
            if (empresa.GetCnpj() != null)
            {
                filtro.Add("e.cnpj like '%" + empresa.GetCnpj() + "%'");
            }   
            filtro.Add("e.ativo='" + empresa.GetAtivo() + "'");
            if (filtro.Count > 0)
            {
                busca = "WHERE " + String.Join(" AND ", filtro.ToArray());
            }
            else
            {
                busca = "";
            }
            comando.CommandText = "select empresa_id as codigo, empresa as Empresa,razao_social as Razão,cnpj as CNPJ," +
                " dt_locacao as Locação, ativo as Ativo,local_id from empresa e " + busca;
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

        public int IncluirEmpresa(Empresa empresa)
        {
            Conection conecta = new Conection();
            MySqlConnection Mysqlcon = new MySqlConnection(conecta.connection);
            MySqlCommand Mysqlcom = Mysqlcon.CreateCommand();
            Mysqlcom.CommandText = "insert into empresa (empresa,razao_social,dt_locacao,cnpj,local_id)"
                + "values (?empresa,?razao_social,str_to_date(?dt_locacao,'%d/%m/%Y'),?cnpj,?local_id)";
            Mysqlcom.Parameters.AddWithValue("?empresa", empresa.GetEmpresa());
            Mysqlcom.Parameters.AddWithValue("?razao_social", empresa.GetRazaoSocial());
            Mysqlcom.Parameters.AddWithValue("?dt_locacao", empresa.GetData());
            Mysqlcom.Parameters.AddWithValue("?cnpj", empresa.GetCnpj()); 
            Mysqlcom.Parameters.AddWithValue("?local_id", empresa.GetLocalId());
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

        public DataTable ListarEmpresa()
        {
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();          
            string sql = "select empresa_id as codigo, empresa as Empresa,razao_social as Razão,cnpj as CNPJ," +
                " dt_locacao as Locação, ativo as Ativo,local_id from empresa e where e.ativo='SIM' order by e.dt_locacao desc";            
            comando.CommandText = sql;
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
    }
}
