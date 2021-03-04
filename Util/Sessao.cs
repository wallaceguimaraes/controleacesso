using AcessoControle.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Util
{
    public class Sessao
    {

        private static Sessao instance = null;
        private Usuario usuario;

        private Sessao()
        {
        }

        public Usuario getUsuario()
        {
            return usuario;
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public static Sessao getInstance()
        {
            if (instance == null)
            {
                instance = new Sessao();
            }
            return instance;
        }
    }
    }
