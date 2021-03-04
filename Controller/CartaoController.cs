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
   public class CartaoController
    {
        CartaoDao cartaoDao = new CartaoDao();

        public int ExcluirCartao(int cartaoID)
        {
            int flag;
            flag=cartaoDao.ExcluirCartao(cartaoID);

            return flag;
        }

        public int AtualizarCartao(Cartao cartao)
        {
            int flag;
            flag = cartaoDao.AtualizarCartao(cartao);
            return flag;
        }

        public DataTable ListarCartao()
        {
            DataTable dados;
            dados = cartaoDao.ListarCartao();
            return dados;
        }

        public DataTable ListarCartaoDisponivel()
        {
            DataTable dados;
            dados = cartaoDao.ListarCartaoDisponivel();
            return dados;
        }

        public DataTable Pesquisar(Cartao cartao)
        {
            DataTable dados;
            dados = cartaoDao.PesquisarCartao(cartao);
            return dados;
        }

        public DataTable PesquisarDisponivel(Cartao cartao)
        {
            DataTable dados;
            dados = cartaoDao.PesquisarCartaoDisponivel(cartao);
            return dados;
        }

        public int IncluirCartao(Cartao cartao)
        {
            int flag;
            flag=cartaoDao.ValidaNumero(cartao.GetNumero());

            if (flag == 0)
            {
                flag = cartaoDao.IncluirCartao(cartao);
            }
            else
            {
                flag = 3;
            }
            return flag;
        }
    }
}
