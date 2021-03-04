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
    public class EmpresaController
    {

        EmpresaDao empresaDao = new EmpresaDao();

        public int ExcluirEmpresa(int empresaID)
        {
            int flag;
            flag = empresaDao.ExcluirEmpresa(empresaID);
            return flag;
        }

        public int AtualizarEmpresa(Empresa empresa)
        {
            int flag;
            flag = empresaDao.AtualizarEmpresa(empresa);
            if (flag == 1)
            {
                LocalDao localDao = new LocalDao();
                localDao.AtualizarLocalPorID(empresa.GetLocalId(), 0);//caso flag for 0 atualizar apenas um registro para DISPONIVEL=NÃO
            }
            return flag;
        }

        public DataTable ListarEmpresa()
        {
            DataTable dados;
            dados = empresaDao.ListarEmpresa();
            return dados;
        }

        public DataTable Pesquisar(Empresa empresa)
        {
            DataTable dados;
            dados = empresaDao.PesquisarEmpresa(empresa);
            return dados;
        }

        public int IncluirEmpresa(Empresa empresa)
        {
            int flag;
            flag = empresaDao.IncluirEmpresa(empresa);
            if (flag == 1)
            {
                LocalDao localDao = new LocalDao();
                localDao.AtualizarLocalPorID(empresa.GetLocalId(), 0);//flag 1 indica que atualiza local disponivel para NAO                 
            }
            return flag;
        }
    }
}
