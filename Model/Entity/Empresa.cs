using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAcess.Model.Entity
{
    public class Empresa
    {


        private int empresa_id;
        private string empresa;
        private string razaoSocial;
        private string data;
        private string cnpj;
        private int localId;
        private string ativo;

        public Empresa()
        {
        }
        public Empresa(int empresa_id, string empresa, string razaoSocial, string data, string cnpj, int localId, string ativo)
        {
            this.empresa_id = empresa_id;
            this.empresa = empresa;
            this.razaoSocial = razaoSocial;
            this.data = data;
            this.cnpj = cnpj;
            this.localId = localId;
            this.ativo = ativo;
        }

        public void SetEmpresa_id(int empresa_id) { this.empresa_id = empresa_id; }

        public int GetEmpresa_id() { return empresa_id; }

        public void SetEmpresa(string empresa) { this.empresa = empresa.ToUpper(); }

        public string GetEmpresa() { return empresa; }

        public void SetRazaoSocial(string razaoSocial) { this.razaoSocial = razaoSocial.ToUpper(); }

        public string GetRazaoSocial() { return razaoSocial; }

        public string GetData() { return data; }

        public void SetData(string data) { this.data = data; }

        public void SetCnpj(string cnpj) { this.cnpj = cnpj; }

        public string GetCnpj() { return cnpj; }

        public void SetLocalId(int localId) { this.localId= localId; }

        public int GetLocalId(){ return localId; }

        public void SetAtivo(string ativo) { this.ativo = ativo; }

        public string GetAtivo() { return ativo; }
    }
}
