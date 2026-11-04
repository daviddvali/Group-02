namespace G02_BankSystem.Bank;

public static class BankService
{
    public static void DepositToCard(BaseCard card, decimal amount)
    {
        if (card == null)
        {
            throw new ArgumentNullException(nameof(card), "Card cannot be null.");
        }
        string cardType = card.GetType().Name;
        LogDepositMessage($"Depositing {amount:C} to {cardType} {card.CardNumber}");
        card.Deposit(amount);
        LogDepositMessage($"Deposit {amount:C} to {cardType} {card.CardNumber} completed");
        LogDepositMessage($"Balance on {cardType} {card.CardNumber} is {card.Balance:C}");
    }

    public static void WithdrawFromCard(BaseCard card, decimal amount)
    {
        if (card == null)
        {
            throw new ArgumentNullException(nameof(card), "Card cannot be null.");
        }
        string cardType = card.GetType().Name;
        LogWithdrawalMessage($"Withdrawing {amount:C} from {cardType} {card.CardNumber}");
        card.Withdraw(amount);
        LogWithdrawalMessage($"Withdrawal {amount:C} from {cardType} {card.CardNumber} completed");
        LogWithdrawalMessage($"Balance on {cardType} {card.CardNumber} is {card.Balance:C}");
    }

    public static void TransferBetweenCards(BaseCard fromCard, BaseCard toCard, decimal amount)
    {
        if (fromCard == null)
        {
            throw new ArgumentNullException(nameof(fromCard), "From card cannot be null.");
        }
        if (toCard == null)
        {
            throw new ArgumentNullException(nameof(toCard), "To card cannot be null.");
        }
        string fromCardType = fromCard.GetType().Name;
        string toCardType = toCard.GetType().Name;
        LogTransferMessage($"Transferring {amount:C} from {fromCardType} {fromCard.CardNumber} to {toCardType} {toCard.CardNumber}");
        fromCard.Withdraw(amount);
        toCard.Deposit(amount);
        LogTransferMessage($"Transfer {amount:C} from {fromCardType} {fromCard.CardNumber} to {toCardType} {toCard.CardNumber} completed");
        LogTransferMessage($"Balance on {fromCardType} {fromCard.CardNumber} is {fromCard.Balance:C}");
        LogTransferMessage($"Balance on {toCardType} {toCard.CardNumber} is {toCard.Balance:C}");
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