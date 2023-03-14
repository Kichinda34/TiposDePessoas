using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDePessoas
{
    internal class PessoaJuridica : Pessoa 
    {
        public string NomeFantasia;
        public string Cnpj;
        public PessoaJuridica(string nome, string nomeFantasia, string telefone, string telefoneFixo, string cpf, string cnpj, string email) : base (nome, telefone, cpf, telefoneFixo, email)
        {
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + NomeFantasia + " - " + Cnpj;
        }

    }
}
