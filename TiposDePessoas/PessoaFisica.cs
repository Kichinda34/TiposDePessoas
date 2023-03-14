using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDePessoas
{
    internal class PessoaFisica : Pessoa 
    {
        public PessoaFisica(string nome, string telefone, string telefoneFixo, string cpf, string email) : base(nome, telefone, telefoneFixo, cpf, email)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }




    }
}
