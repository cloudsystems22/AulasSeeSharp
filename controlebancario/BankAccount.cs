namespace Classes;

public class BankAccount
{
    public string Number { get; }

    public string Owner { get; set; }

    public decimal Balance 
    { 
        get
        {
            decimal balance = 0;
            foreach(var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        } 
    }

    private static int accountNumberSeed = 1234567890;

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        
        Number = accountNumberSeed.ToString();
        accountNumberSeed++;

        MakeDeposit(initialBalance, DateTime.Now, "Depósito inicial");
    }

    private List<Trasaction> allTransactions = new List<Trasaction>();

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "O valor do depósito deve ser positivo!");
        }
        var deposit = new Trasaction(amount, date, note, GeneratorUid());
        allTransactions.Add(deposit);

    } 

    public void MakeWithDrawal(decimal amount, DateTime date, string note)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "O valor da retirada deve ser positivo!");
        }
        else if(Balance - amount < 0)
        {
            throw new InvalidOperationException("A retirada não pode ser executada, favor verificar saldo!");
        }
        var withdrawal = new Trasaction(-amount, date, note, GeneratorUid());
        allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Data\tValor\tSaldo\tDescricao\tId");
        foreach(var item in allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}\t{item.Uid}");
        }
        
        return report.ToString();
    }

    private string GeneratorUid() =>
        Guid.NewGuid()
            .ToString()
            .ToUpper()
            .Substring(0,12);
    
   
}