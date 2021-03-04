using ControllAcess.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Controller
{
    public class UtilController
    {
        UtilDao utilDao = new UtilDao();


        public DataTable PesquisarPessoaTipoPorCPF(string cpf)
        {
            DataTable dados;
            dados=utilDao.PesquisarPessoaTipoPorCPF(cpf);
            return dados;
        }


        public int retornaUltimoID()
        {
            int id;
            id=utilDao.retornaUltimoID();
            return id;
        }

        public int retornaEventoID(int localId)
        {
            int id;
            id = utilDao.retornaEventoID(localId);
            return id;
        }


    }
}
