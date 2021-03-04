using ControllAcess.DAO;
using ControllAcess.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Controller
{
   public class AcessoController

    {

        AcessoDao acessoDao = new AcessoDao();


        public DataTable ListarAcessoHoje()
        {
            DataTable dados;
            dados = acessoDao.ListarAcessoHoje();
            return dados;
        }


        public int IncluirAcesso(Acesso acesso )
        {
            int flag;            
                flag = acessoDao.IncluirAcesso(acesso);
         
            return flag;
        }


    }
}
