using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
    public class Acesso
    {
        private int acesso_id;
        private int cartao_id;
        private int pessoa_id;
        private int evento_id;
        private int local_id;
        private string data;
        private string entrada;
        private string saida;
        private string ativo;

        public Acesso()
        { }

        public Acesso(int acesso_id, int cartao_id, int pessoa_id, int evento_id,int local_id, string data, string entrada, string saida, string ativo)
        {
            this.acesso_id = acesso_id;
            this.cartao_id = cartao_id;
            this.pessoa_id = pessoa_id;
            this.evento_id = evento_id;
            this.local_id = local_id;
            this.data = data;
            this.entrada = entrada;
            this.saida = saida;
            this.ativo = ativo;
        }
        public void SetAcessoId(int acesso_id) { this.acesso_id = acesso_id; }

        public int GetAcessoId() { return acesso_id; }

        public void SetPessoa_id(int pessoa_id) { this.pessoa_id = pessoa_id; }

        public int GetPessoa_id() { return pessoa_id; }

        public void SetCartaoId(int cartao_id) { this.cartao_id = cartao_id; }

        public int GetCartaoId() { return cartao_id; }

        public void SetEventoId(int evento_id) { this.evento_id = evento_id; }

        public int GetEventoId() { return evento_id; }

        public void SetLocalId(int local_id) { this.local_id = local_id; }

        public int GetLocalId() { return local_id; }

        public void SetData(string data) { this.data = data; }

        public string GetData() { return data; }

        public void SetEntrada(string entrada) { this.entrada = entrada; }

        public string GetEntrada() { return entrada; }

        public void SetSaida(string saida) { this.saida = saida; }

        public string GetSaida() { return saida; }

        public void SetAtivo(string ativo) { this.ativo = ativo; }

        public string GetAtivo() { return ativo; }

    }
}
