using G02_BankSystem.Bank;

namespace G02_BankSystem;

internal class Program
{
    static void Main(string[] args)
    {
        DebitCard visaCard = new VisaCard(
            "4123123456789012",
            "John Doe",
            DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
            "123");

        DebitCard masterCard = new MasterCard(
            "5123123456789013",
            "Jane Smith",
            DateOnly.FromDateTime(DateTime.Now.AddYears(2)),
            "456");
              
        BankService.DepositToCard(visaCard, 1000);
        Console.WriteLine();
        BankService.WithdrawFromCard(visaCard, 100);
        Console.WriteLine();
        BankService.TransferBetweenCards(visaCard, masterCard, 500);
        Console.WriteLine();
        BankService.WithdrawFromCard(masterCard, 100);
        Console.WriteLine();
        BankService.TransferBetweenCards(masterCard, visaCard, 200);
    }
}