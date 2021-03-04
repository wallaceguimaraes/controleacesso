using AcessoControle.DAO;
using AcessoControle.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoControle.Controller
{
    public class LoginController
    {

        public Usuario ValidaUsuario(string login, string senha)
        {
            LoginDao loginDao = new LoginDao();
            Usuario usuario;
            usuario = loginDao.ValidaUsuario(login, senha); 
            return usuario;
        }

    }
}
