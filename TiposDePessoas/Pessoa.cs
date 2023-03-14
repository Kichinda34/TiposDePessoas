using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDePessoas
{

    internal class Pessoa
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string TelefoneFixo { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public Pessoa (string nome, string telefone, string telefoneFixo, string cpf, string email)
        {
            Nome = nome;
            Telefone = telefone;
            TelefoneFixo = telefoneFixo;
            Cpf = cpf;
            Email = email; 
        }

        public override string ToString()
        {
            return (Nome + " - " + Telefone + " - " + TelefoneFixo + " - " + Cpf + " - " + Email);
        }
    }
}
