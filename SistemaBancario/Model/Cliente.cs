using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    public class Cliente
    {
       
        public string Email { get; set; }
        public string Nome { get; set; }
        public int AnoNascimento { get; private set; }
        public string CPF { get; private set; }

        public Cliente(string nome, string cpf)
        {

            Nome = nome;
            CPF = cpf;
        }


    }
}
