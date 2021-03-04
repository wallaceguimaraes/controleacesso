using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
   public class Pessoa
    {

        private int pessoa_id;
        private string nome;
        private string cpf;
        private string dtNascimento;
        private string imagem;
        private string rg;
        private string obs;
        private string email;
        private string contato;
        private string ativo;

        public Pessoa()
        {}

        public Pessoa(int pessoa_id, string nome, string cpf, string dtNascimento, string imagem, string rg, string obs, string email, string contato, string ativo)
        {
            this.pessoa_id = pessoa_id;
            this.nome = nome;
            this.cpf = cpf;
            this.dtNascimento = dtNascimento;
            this.imagem = imagem;
            this.rg = rg;
            this.obs = obs;
            this.email = email;
            this.contato = contato;
            this.ativo = ativo;
        }

        public void SetPessoa_id(int pessoa_id){ this.pessoa_id = pessoa_id;}

        public int GetPessoa_id(){return pessoa_id;}

        public void SetNome(string nome){this.nome = nome;}

        public string GetNome(){return nome;}

        public void SetCpf(string cpf){this.cpf = cpf;}

        public string GetCpf(){ return cpf;}

        public void SetDtNascimento(string dtNascimento){this.dtNascimento = dtNascimento;}

        public string GetDtNascimento(){return dtNascimento;}

        public void SetImagem(string imagem){this.imagem = imagem;}

        public string GetImagem(){return imagem;}

        public void SetRg(string rg) { this.rg = rg; }

        public string GetRg() { return rg; }

        public void SetObs(string obs) { this.obs = obs; }

        public string GetObs() { return obs; }

        public void SetEmail(string email) { this.email = email; }

        public string GetEmail() { return email; }

        public void SetContato(string contato) { this.contato = contato; }

        public string GetContato() { return contato; }

        public void SetAtivo(string ativo){this.ativo = ativo;}

        public string GetAtivo(){return ativo;}

    }
}
