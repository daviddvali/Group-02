using G02_BankSystem.Bank;
using G02_BankSystem.Cards;
  

namespace G02_BankSystem;

internal class Program
{
    static void Main(string[] args)
    {
        Card testCard1 = new VisaCard(
            "4123123456789012",
            "John Doe",
            DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
            "123");

        Card testCard2 = new MasterCard(
            "5123123456789013",
            "Jane Smith",
            DateOnly.FromDateTime(DateTime.Now.AddYears(2)),
            "456");

        //testCard1.Deactivate();
        BankService.DepositToCard(testCard1, 1000);
        Console.WriteLine();
        BankService.WithdrawFromCard(testCard1, 100);
        Console.WriteLine();
        BankService.TransferBetweenCards(testCard1, testCard2, 500);
    }
}