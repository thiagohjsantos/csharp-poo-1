using ByteBank.Contas;
using ByteBank.Titular;

Console.Clear();

var contaDoThiago = new ContaCorrente();
var thiago = new Cliente();
thiago.Nome = "Thiago";
contaDoThiago.Titular = thiago;
contaDoThiago.NumeroAgencia = 1;
contaDoThiago.Conta = "1010-x";
contaDoThiago.SetSaldo(100.00);

var contaDoAndre = new ContaCorrente();
var andre = new Cliente();
andre.Nome = "Andre";
contaDoAndre.Titular = andre;
contaDoAndre.NumeroAgencia = 2;
contaDoAndre.Conta = "2020-x";
contaDoAndre.SetSaldo(100.00);

contaDoThiago.ExiberDados();

contaDoThiago.Depositar(100);

Console.WriteLine($"Saldo do(a) {contaDoThiago.Titular.Nome} pós depósito: R${contaDoThiago.GetSaldo()}");

if (contaDoThiago.Sacar(20))
{
    Console.WriteLine($"Saldo do(a) {contaDoThiago.Titular.Nome} pós saque: R${contaDoThiago.GetSaldo()}");
}
else
    Console.WriteLine($"Saldo insuficiente para saque!");

if (contaDoThiago.Transferir(contaDoAndre, 100))
{
    Console.WriteLine($"\nSaldo do(a) {contaDoThiago.Titular.Nome} pós transferência: R${contaDoThiago.GetSaldo()}");
    Console.WriteLine($"Saldo do(a) {contaDoAndre.Titular.Nome} pós depósito: R${contaDoAndre.GetSaldo()}");
}
else
    Console.WriteLine($"Saldo insuficiente para depósito!");

contaDoThiago.ExiberDados();

Cliente cliente = new Cliente();
cliente.Nome = "Thiago";
cliente.Cpf = "12334567823";
cliente.Profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.Titular = cliente;
conta.NumeroAgencia = 3;
conta.Conta = "2392-x";
conta.SetSaldo(20.00);

Console.WriteLine($"Titular: {conta.Titular.Nome}");
Console.WriteLine($"CPF: {conta.Titular.Cpf}");
Console.WriteLine($"Profissão: {conta.Titular.Profissao}");
Console.WriteLine($"N° agencia: {conta.NumeroAgencia}");
Console.WriteLine($"Conta: {conta.Conta}");
Console.WriteLine($"Saldo R${conta.GetSaldo()}");

Console.WriteLine($"\nTotal de contas criadas: {ContaCorrente.TotalContas}");
Console.WriteLine($"\nTotal de clientes: {Cliente.TotalClientes}");

Console.ReadKey();