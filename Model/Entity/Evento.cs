using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
   public class Evento
    {




        private int evento_id;
        private string descricao;
        private string tipo;
        private string participantes;
        private string data;
        private string inicio;
        private string fim;
        private int usuario_id;
        private int local_id;
        private string ativo;

        public Evento()
        {


        }
        public Evento(int evento_id, string descricao, string tipo, string participantes, string data, string inicio, string fim, int usuario_id, int local_id, string ativo)
        {
            this.evento_id = evento_id;
            this.descricao = descricao;
            this.tipo = tipo;
            this.participantes = participantes;
            this.data = data;
            this.inicio = inicio;
            this.fim = fim;
            this.usuario_id = usuario_id;
            this.local_id = local_id;
            this.ativo = ativo;
        }
        public void SetEvento_id(int evento_id) {  this.evento_id = evento_id; }

        public int GetEvento_id() {  return evento_id; }

        public void SetDescricao(string descricao){  this.descricao = descricao; }

        public string GetDescricao(){  return descricao; }

        public void SetTipo(string tipo){  this.tipo = tipo; }

        public string GetTipo(){  return tipo; }

        public void SetParticipantes(string participantes){  this.participantes = participantes; }

        public string GetParticipantes(){  return participantes; }

        public void SetData(string data) { this.data = data; }

        public string GetData() { return data; }

        public void SetInicio(string inicio) { this.inicio = inicio; }

        public string GetInicio() { return inicio; }

        public void SetFim(string fim) { this.fim = fim; }

        public string GetFim() { return fim; }

        public void SetUsuarioId(int usuario_id) { this.usuario_id = usuario_id; }

        public int GetUsuarioId() { return usuario_id; }

        public void SetLocalId(int local_id ) { this.local_id = local_id; }

        public int GetLocalId() { return local_id; }

        public void SetAtivo(string ativo){  this.ativo = ativo; }

        public string GetAtivo(){  return ativo; }


    }
}
