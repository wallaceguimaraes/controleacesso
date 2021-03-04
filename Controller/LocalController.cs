using ControllAcess.DAO;
using ControllAcess.Model.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Controller
{
    public class LocalController
    {

        LocalDao localDao = new LocalDao();

        public int ExcluirLocal(int localID)
        {
            int flag;
            flag = localDao.ExcluirLocal(localID);
            return flag;
        }

        public int AtualizarLocal(Local local)
        {
            int flag;
            flag = localDao.AtualizarLocal(local);
            return flag;
        }

        public DataTable ListarLocal()
        {
            DataTable dados;
            dados = localDao.ListarLocal();
            return dados;
        }

        public DataTable ListarLocalNaoAlocado()
        {
            DataTable dados;
            dados = localDao.ListarLocalNaoAlocado();
            return dados;
        }

        public DataTable PesquisarLocalNaoAlocado(Local local)
        {
            DataTable dados;
            dados = localDao.PesquisarLocalNaoAlocado(local);
            return dados;
        }

        public DataTable ListarLocalPorID(int ID)
        {
            DataTable dados;
            dados = localDao.ListarLocalPorID(ID);
            return dados;
        }

        public Local BuscarLocalPorID(int ID)
        {
            Local local = new Local();
            local = localDao.BuscarLocalPorID(ID);
            return local;
        }

        public void VerificaAtualizaLocal()
        {
            ArrayList ID = new ArrayList();
            ID=localDao.VerificaDataEventoLocal();
            localDao.AtualizaLocalPorData(ID);
        }

        public DataTable Pesquisar(Local local)
        {
            DataTable dados;
            dados = localDao.PesquisarLocal(local);
            return dados;
        }

        public int IncluirLocal(Local local)
        {
            int flag;
            flag = localDao.ValidaSala(local.GetSala());
            if (flag == 0)
            {
                flag = localDao.IncluirLocal(local);
            }
            else
            {
                flag = 3;
            }
            return flag;
        }
    }
}
