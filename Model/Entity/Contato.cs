using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
    public class Contato
    {


        private int contato_id;
        private string contato;
        private string responsavel;
        private string ramal;
        private int local_id ;
        private string ativo;

        public Contato()
        {


        }
        public Contato(int contato_id, string contato, string responsavel, string ramal, int local_id, string ativo)
        {
            this.contato_id = contato_id;
            this.contato = contato;
            this.responsavel = responsavel;
            this.ramal = ramal;
            this.local_id = local_id;            
            this.ativo = ativo;
        }

        public void SetContato_id(int contato_id)
        {
            this.contato_id = contato_id;
        }

        public int GetContato_id()
        {
            return contato_id;
        }

        public void SetContato(string contato)
        {
            this.contato = contato;
        }

        public string GetContato()
        {
            return contato;
        }

        public void SetResponsavel(string responsavel)
        {
            this.responsavel = responsavel;
        }

        public string GetResponsavel()
        {
            return responsavel;
        }

        public void SetRamal(string ramal)
        {
            this.ramal = ramal;
        }

        public string GetRamal()
        {
            return ramal;
        }


        public void SetLocalID(int local_id)
        {
            this.local_id = local_id;
        }

        public int GetLocalID()
        {
            return local_id;
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
