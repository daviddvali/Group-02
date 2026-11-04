namespace G02_BankSystem.Bank;

public static class BankService
{
    public static void DepositToCard(DebitCard card, decimal amount)
    {
        if (card == null)
        {
            throw new ArgumentNullException(nameof(card), "Card cannot be null.");
        }
        LogDepositMessage($"Depositing {amount:C} to card {card.CardNumber}");
        card.Deposit(amount);
        LogDepositMessage($"Deposit {amount:C} to card {card.CardNumber} completed");
        LogDepositMessage($"Balance on card {card.CardNumber} is {card.Balance:C}");
    }

    public static void WithdrawFromCard(DebitCard card, decimal amount)
    {
        if (card == null)
        {
            throw new ArgumentNullException(nameof(card), "Card cannot be null.");
        }
        LogWithdrawalMessage($"Withdrawing {amount:C} from card {card.CardNumber}");
        card.Withdraw(amount);
        LogWithdrawalMessage($"Withdrawal {amount:C} from card {card.CardNumber} completed");
        LogWithdrawalMessage($"Balance on card {card.CardNumber} is {card.Balance:C}");
    }

    public static void TransferBetweenCards(DebitCard fromCard, DebitCard toCard, decimal amount)
    {
        if (fromCard == null)
        {
            throw new ArgumentNullException(nameof(fromCard), "From card cannot be null.");
        }
        if (toCard == null)
        {
            throw new ArgumentNullException(nameof(toCard), "To card cannot be null.");
        }
        LogTransferMessage($"Transferring {amount:C} from card {fromCard.CardNumber} to card {toCard.CardNumber}");
        fromCard.Withdraw(amount);
        toCard.Deposit(amount);
        LogTransferMessage($"Transfer {amount:C} from card {fromCard.CardNumber} to card {toCard.CardNumber} completed");
        LogTransferMessage($"Balance on card {fromCard.CardNumber} is {fromCard.Balance:C}");
        LogTransferMessage($"Balance on card {toCard.CardNumber} is {toCard.Balance:C}");
    }

    private static void LogMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{message}");
        Console.ResetColor();
    }

    private static void LogDepositMessage(string message)
        => LogMessage(message, ConsoleColor.Green);

    private static void LogWithdrawalMessage(string message)
        => LogMessage(message, ConsoleColor.Red);

    private static void LogTransferMessage(string message)
        => LogMessage(message, ConsoleColor.Yellow);
}