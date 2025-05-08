using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    class ContaEspecial : Conta
    {
        public decimal Limite { get; private set; }
        public ContaEspecial(decimal saldo) : base(saldo)
        {
        }
        public ContaEspecial(Cliente cliente) : base(cliente)
        {
           
        }
        public ContaEspecial(decimal saldo, decimal limite) : base(saldo)
        {
            if (Limite < 0)
                throw new ArgumentException("O limite nao pode ser negativo");
            Limite = limite;
        }
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo +Limite)
                throw new InvalidOperationException("O saldo insufisciente para relizar o saque");
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero");
            Saldo -= valor;
        }
        public  override void Transferir(decimal valor, Conta contaDestino)
        {
            
            if (valor > Saldo + Limite)
                throw new InvalidOperationException("Saldo insuficiente para realizar a transferencia");
            Saldo -= valor;
            contaDestino.Depositar(valor);
        }
    }
}
