using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
    public class Cartao
    {

        private int cartao_id;
        private string numero;
        private string disponivel;
        private string tipo;
        private string periodoInicio;
        private string periodoFim;
        private string ativo;

        public Cartao()
        {


        }
        public Cartao(int cartao_id, string tipo, string disponivel, string numero, string periodoInicio, string periodoFim, string ativo)
        {
            this.cartao_id = cartao_id;
            this.tipo = tipo;
            this.numero = numero;
            this.disponivel = disponivel;
            this.periodoInicio = periodoInicio;
            this.periodoFim = periodoFim;
            this.ativo = ativo;
    
        }

        public void SetCartao_id(int cartao_id)
        {
            this.cartao_id = cartao_id;
        }

        public int GetCartao_id()
        {
            return cartao_id;
        }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return numero;
        }

        public void SetDisponivel(string disponivel)
        {
            this.disponivel = disponivel;
        }

        public string GetDisponivel()
        {
            return disponivel;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string GetTipo()
        {
            return tipo;
        }


        public void SetPeriodoInicio(string periodoInicio)
        {
            this.periodoInicio = periodoInicio;
        }

        public string GetPeriodoInicio()
        {
            return periodoInicio;
        }


        public void SetPeriodoFim(string periodoFim)
        {
            this.periodoFim = periodoFim;
        }

        public string GetPeriodoFim()
        {
            return periodoFim;
        }

        public void SetAtivo(string ativo)
        {
            this.ativo = ativo;
        }

        public string GetAtivo()
        {
            return ativo;
        }
    
    }
}
