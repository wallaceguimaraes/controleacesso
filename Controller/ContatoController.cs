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
    public class ContatoController
    {

        ContatoDao contatoDao = new ContatoDao();

        public DataTable BuscarContatosPorID(int ID)
        {
            DataTable dados;
            dados = contatoDao.BuscarContatosPorID(ID);
            return dados;
        }

        public int ExcluirContato(int contatoID)
        {
            int flag;
            flag = contatoDao.ExcluirContato(contatoID);
            return flag;
        }

        public int AtualizarContato(Contato contato)
        {
            int flag;
            flag = contatoDao.AtualizarContato(contato);
            return flag;
        }

        public DataTable ListarContato()
        {
            DataTable dados;
            dados = contatoDao.ListarContato();
            return dados;
        }

        public DataTable Pesquisar(Contato contato)
        {
            DataTable dados;
            dados = contatoDao.PesquisarContato(contato);
            return dados;
        }

        public int IncluirContato(Contato contato)
        {
            int flag;
            flag = contatoDao.IncluirContato(contato);
            return flag;
        }
    }
}
