using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    public class Conta
    {
        public long Numero { get; protected set; }
        public decimal Saldo { get; protected set; }
        public Cliente Titular { get; protected set; }
        public Conta(decimal saldo)
        {
            if (saldo < 0)
                throw new ArgumentNullException("o SALDO INICIAL NAO PODE SER NEGATIVO");
            saldo = saldo;
        }
        public Conta(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException("O cliente nao pode ser nulo")
                  Titular = cliente;
        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero ");
            Saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor > Saldo)
                throw new InvalidOperationException("O saldo insufisciente para relizar o saque");
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero");
            Saldo -= valor;
        }
        public virtual void Transferir(decimal valor, Conta contaDestino)
        {
            if (contaDestino == null)
                throw new ArgumentNullException("A conta de destino nao pode ser nula");
            if (valor <= 0)
                throw new ArgumentException("O valor da transferencia deve ser maior que zero");
            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente para realizar a transferencia");
            Saldo -= valor;
            contaDestino.Depositar(valor);
        }

    }
}
