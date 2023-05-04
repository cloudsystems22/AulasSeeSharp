// See https://aka.ms/new-console-template for more information
/*  TODO - APP responsável por gerenciamento de contas bancárias;
    1. Ela tem um número com 10 dígitos que identifica exclusivamente a conta bancária;
    2. Ela tem uma cadeia de caracteres que armazena o nome ou os nomes dos proprietários;
    3. O saldo pode ser recuperado;
    4. Ela aceita depósitos;
    5. Ele aceita saques;
    6. O saldo inicial deve ser positivo;
    7. Os saques não podem resultar em um saldo negativo.
*/

using Classes;

var account = new BankAccount("<name>", 2000);
Console.WriteLine($"Conta: {account.Number} responsável: {account.Owner} valor saldo: {account.Balance}");
account.MakeWithDrawal(500, DateTime.Now, "Pagamento de despesa em geral.");
Console.WriteLine($" Saque R$500: {account.Balance} - Pagamento de despesa em geral.");
account.MakeDeposit(100, DateTime.Now, "Receita ref. serviço prestado.");
Console.WriteLine($" Depósito R$ 100: {account.Balance} - Receita ref. serviço prestado.");
Console.WriteLine($"Conta: {account.Number} responsável: {account.Owner} valor saldo: {account.Balance}");

Console.WriteLine("::Histórico de Transações::.........................");
Console.WriteLine(account.GetAccountHistory());
