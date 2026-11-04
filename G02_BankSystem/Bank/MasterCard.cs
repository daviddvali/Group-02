namespace G02_BankSystem.Bank;

public sealed class MasterCard : DebitCard
{
    public MasterCard(string cardNumber, string cardHolderName, DateOnly expiryDate, string cvv) 
        : base(cardNumber, cardHolderName, expiryDate, cvv)
    { }
    public override decimal WithdrawFee => 0.02m;
    protected override void ValidateCardNumber(string cardNumber)
    {
        ArgumentNullException.ThrowIfNull(cardNumber);

        if (cardNumber.Length != 16 || cardNumber[0] != '5' || !IsOnlyNumbers(cardNumber))
            throw new ArgumentException("A MasterCard card number must start with 5 and contain only digits.", nameof(cardNumber));
    }
}
