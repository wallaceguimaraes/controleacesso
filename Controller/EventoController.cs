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
    public class EventoController
    {

        EventoDao eventoDao = new EventoDao();

        public int ValidarHoraEvento(string sala,string data, string inicio, string fim)
        {
            int retorno;
            retorno=eventoDao.ValidarHoraEvento(sala,data,inicio, fim);
            return retorno;
        }


        public string BuscarResponsavelPorId(int ID)
        {
            string nome;
            nome=eventoDao.BuscarResponsavelPorId(ID);
            return nome;
        }

        public int ExcluirEvento(int eventoID)
        {
            int flag;
            flag = eventoDao.ExcluirEvento(eventoID);
            return flag;
        }
    
        public int AtualizarEvento(Evento evento)
        {
            int flag;
            flag = eventoDao.AtualizarEvento(evento);
            if (flag == 1)
            {
                LocalDao localDao = new LocalDao();
                localDao.AtualizarLocalPorID(evento.GetLocalId(),0);//caso flag for 0 atualizar apenas um registro para DISPONIVEL=NÃO
            }



            return flag;
        }
        
        public DataTable ListarEvento(string data, int flag)
        {
            DataTable dados;
            dados = eventoDao.ListarEvento(data, flag);
            return dados;
        }

        public DataTable ListarEventoPorId(int ID)
        {
            DataTable dados;
            dados = eventoDao.ListarEventoPorId(ID);
            return dados;
        }

        public DataTable Pesquisar(Evento evento)
        {
            DataTable dados;
            dados = eventoDao.PesquisarEvento(evento);
            return dados;
        }

        public int IncluirEvento(Evento evento)
        {
            int flag;         
            flag = eventoDao.IncluirEvento(evento);
            if (flag == 1)
            {
                LocalDao localDao = new LocalDao();
                localDao.AtualizarLocalPorID(evento.GetLocalId(),0);//flag 1 indica que atualiza local disponivel para NAO                 
            }
            return flag;
        }
    }
}
