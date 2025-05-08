using SistemaBancario.Model;

Cliente cliente1 = new Cliente("Maria", "12345678900");
Conta conta1 = new Conta(cliente1);
Console.WriteLine($"A conta numero {conta1.Numero} pertence ao cliente {conta1.Titular.Nome}");
ContaEspecial conta2 = new ContaEspecial(1000, 500);
Conta conta3 = new ContaEspecial(2000, 1000);
Conta conta4;
static void CriarConta(Conta conta)
{
    conta4 = conta;
}
