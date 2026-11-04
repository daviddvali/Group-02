namespace G02_BankSystem.Bank;

public sealed class MasterCard : BaseCard
{
    public MasterCard(string cardNumber, string cardHolderName, DateOnly expiryDate, string cvv) 
        : base(cardNumber, cardHolderName, expiryDate, cvv)
    { }

    public override decimal WithdrawFee => 0.02m;

    protected override void ValidateCardNumber(string cardNumber)
    {
        base.ValidateCardNumber(cardNumber);
        if (cardNumber[0] != '5')
            throw new ArgumentException("A MasterCard card number must start with 5.", nameof(cardNumber));
    }
}
