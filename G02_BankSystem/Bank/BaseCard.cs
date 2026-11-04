namespace G02_BankSystem.Bank;

public abstract class BaseCard
{
    protected BaseCard(
        string cardNumber,
        string cardHolderName,
        DateOnly expiryDate,
        string cvv)
    {
        // Validate the input parameters.
        ValidateCardNumber(cardNumber);
        ValidateCardHolderName(cardHolderName);
        ValidateExpiryDate(expiryDate);
        ValidateCVV(cvv);

        // Initialize the properties.
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpiryDate = expiryDate;
        CVV = cvv;
        Balance = 0;
        IsActive = true;
    }

    public string CardNumber { get; }
    public string CardHolderName { get; }
    public DateOnly ExpiryDate { get; }
    public string CVV { get; }
    public decimal Balance { get; private set; }
    public bool IsActive { get; private set; }
    public abstract decimal WithdrawFee { get; }
    protected virtual int ValidCardNumberLength => 16;
    protected virtual int ValidCardCvvLength => 3;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount must be positive.");
        if (!IsActive)
            throw new InvalidOperationException("Cannot deposit to an inactive card.");
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawal amount must be positive.");
        if (!IsActive)
            throw new InvalidOperationException("Cannot withdraw from an inactive card.");

        decimal totalAmount = amount + CalculateWithdrawFee(amount);
        if (totalAmount > Balance)
            throw new InvalidOperationException("Insufficient funds.");
        Balance -= totalAmount;
    }

    public void Deactivate()
    {
        if (!IsActive)
            throw new InvalidOperationException("The card is already deactivated.");
        IsActive = false;
    }

    public void Activate()
    {
        if (IsActive)
            throw new InvalidOperationException("The card is already activated.");
        IsActive = true;
    }

    protected decimal CalculateWithdrawFee(decimal amount)
    {
        return amount * WithdrawFee;
    }

    protected virtual void ValidateCardNumber(string cardNumber)
    {
        ArgumentNullException.ThrowIfNull(cardNumber);

        if (cardNumber.Length != ValidCardNumberLength || !IsOnlyNumbers(cardNumber))
            throw new ArgumentException($"A card number must contain exactly {ValidCardNumberLength} digits.", nameof(cardNumber));
    }

    protected virtual void ValidateCardHolderName(string cardHolderName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(cardHolderName);
    }

    protected virtual void ValidateExpiryDate(DateOnly expiryDate)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        DateOnly firstDayOfCurrentMonth = new DateOnly(today.Year, today.Month, 1);

        // Card expiry uses the year and month; the day is ignored.
        if (expiryDate < firstDayOfCurrentMonth)
            throw new ArgumentOutOfRangeException(nameof(expiryDate), "The card has expired.");
    }

    protected virtual void ValidateCVV(string cvv)
    {
        ArgumentNullException.ThrowIfNull(cvv);

        if (cvv.Length != ValidCardCvvLength || !IsOnlyNumbers(cvv))
            throw new ArgumentException($"CVV must contain exactly {ValidCardCvvLength} digits.", nameof(cvv));
    }

    protected static bool IsOnlyNumbers(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != '0' && text[i] != '1' &&
                text[i] != '2' && text[i] != '3' &&
                text[i] != '4' && text[i] != '5' &&
                text[i] != '6' && text[i] != '7' &&
                text[i] != '8' && text[i] != '9')
                return false;
        }
        return true;
    }
}