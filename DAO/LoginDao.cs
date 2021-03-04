using AcessoControle.Model.Entity;
using ControllAcess.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoControle.DAO
{
    public class LoginDao
    {
 
        public Usuario ValidaUsuario(string login, string senha)
        {
            Usuario usuario = new Usuario();
            Conection conecta = new Conection();
            MySqlConnection conexao = new MySqlConnection(conecta.connection);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from usuario u where u.login='"+login+"' and u.senha='"+senha+"'";         
            DataSet Mysqldset = new DataSet();
            try
            {
                conexao.Open();
                comando = new MySqlCommand(comando.CommandText, conexao);
                MySqlDataAdapter Mysqldap = new MySqlDataAdapter(comando);
                Mysqldap.Fill(Mysqldset);             
                if (Mysqldset.Tables[0].Rows.Count == 0)
                {
                    usuario = null;
                    return usuario;
                }
                usuario.SetUsuario_id(Convert.ToInt32(Mysqldset.Tables[0].Rows[0]["usuario_id"]));
                usuario.SetUsuario(Mysqldset.Tables[0].Rows[0]["usuario"].ToString());
                usuario.SetLogin(Mysqldset.Tables[0].Rows[0]["login"].ToString());
                usuario.SetSenha(Mysqldset.Tables[0].Rows[0]["senha"].ToString());
                usuario.SetSessao(Mysqldset.Tables[0].Rows[0]["sessao"].ToString());
                usuario.SetAtivo(Mysqldset.Tables[0].Rows[0]["ativo"].ToString());
                usuario.SetPerfil(Mysqldset.Tables[0].Rows[0]["perfil"].ToString());
                usuario.SetLocal_id(Convert.ToInt32(Mysqldset.Tables[0].Rows[0]["local_id"]));
                return usuario;
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
