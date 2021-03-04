using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
    public class Local
    {

        private int local_id;
        private string bloco;
        private string andar;
        private string sala;
        private string disponivel;
        private string locado;
        private string ativo;

        public Local()
        {


        }
        public Local(int local_id, string bloco, string andar, string sala, string disponivel,string locado, string ativo)
        {
            this.local_id = local_id;
            this.bloco = bloco;
            this.andar = andar;
            this.sala = sala;
            this.disponivel = disponivel;
            this.locado = locado;
            this.ativo = ativo;

        }

        public void SetLocal_id(int local_id)
        {
            this.local_id = local_id;
        }

        public int GetLocal_id()
        {
            return local_id;
        }

        public void SetBloco(string bloco)
        {
            this.bloco = bloco;
        }

        public string GetBloco()
        {
            return bloco;
        }

        public void SetAndar(string andar)
        {
            this.andar = andar;
        }

        public string GetAndar()
        {
            return andar;
        }

        public void SetSala(string sala)
        {
            this.sala = sala;
        }

        public string GetSala()
        {
            return sala;
        }


        public void SetDisponivel(string disponivel)
        {
            this.disponivel = disponivel;
        }

        public string GetDisponivel()
        {
            return disponivel;
        }

        public void SetLocado(string locado)
        {
            this.locado = locado;
        }

        public string GetLocado()
        {
            return locado;
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
