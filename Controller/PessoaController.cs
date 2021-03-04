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
   public class PessoaController
    {

        PessoaDao pessoaDao = new PessoaDao();


        public  DataTable ListarPessoa()
        {
            DataTable dados;
            dados=pessoaDao.ListarPessoa();
            return dados;

        }



        public int IncluirPessoa(Pessoa pessoa)
        {
            int flag;
          //  flag = pessoaDao.ValidaCpf(pessoa.GetCpf());
          //  if (flag == 0)
          //  {
                flag = pessoaDao.IncluirPessoa(pessoa);
          //  }
          //  else
          //  {
          //      flag = 3;
          //  }
            return flag;
        }





    }
}
