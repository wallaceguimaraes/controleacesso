using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoControle.Model.Entity
{
    public class Usuario
    {
        private int usuario_id;
        private int localId;
        private string usuario;
        private string login;
        private string senha;
        private string sessao;
        private string ativo;
        private string perfil;


        public Usuario()
        {


        }
        public Usuario(int usuario_id,int localId, string usuario, string login,string senha, string sessao, string ativo, string perfil)
        {
            this.usuario_id = usuario_id;
            this.localId = localId;
            this.usuario = usuario;
            this.login = login;
            this.senha = senha;
            this.sessao = sessao;
            this.ativo = ativo;
            this.perfil = perfil;
        }

        public void SetUsuario_id(int usuario_id)
        {
            this.usuario_id = usuario_id;
        }

        public int GetUsuario_id()
        {
            return usuario_id;
        }

        public void SetLocal_id(int localId)
        {
            this.localId = localId;
        }

        public int GetLocal_id()
        {
            return localId;
        }
        public void SetUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public string GetUsuario()
        {
            return usuario;
        }
        public void SetLogin(string login)
        {
            this.login = login;
        }
        public string GetLogin()
        {
            return login;
        }
        public void SetSenha(string senha)
        {
            this.senha = sessao;

        }
        public string GetSenha()
        {
            return senha;
        }
        public void SetSessao(string sessao)
        {
            this.sessao = sessao;
        }
        public string GetSessao()
        {
            return sessao;
        }
        public void SetAtivo(string ativo)
        {
            this.ativo = ativo;
        }

        public string GetAtivo()
        {
            return ativo;
        }
        public void SetPerfil(string perfil)
        {
            this.perfil = perfil;
        }

        public string GetPerfil()
        {
            return perfil;
        }






    }
}
