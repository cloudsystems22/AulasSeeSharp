namespace Classes;

public class Trasaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }
    public string Uid { get; }

    public Trasaction(decimal amount, DateTime date, string notes, string uid)
    {
        Amount = amount;
        Date = date;
        Notes = notes;
        Uid = uid;
    }

}