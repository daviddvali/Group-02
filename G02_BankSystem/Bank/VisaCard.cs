namespace G02_BankSystem.Bank;

public sealed class VisaCard : BaseCard
{
    public VisaCard(string cardNumber, string cardHolderName, DateOnly expiryDate, string cvv) 
        : base(cardNumber, cardHolderName, expiryDate, cvv)
    { }

    public override decimal WithdrawFee => 0.01m;

    protected override void ValidateCardNumber(string cardNumber)
    {
        base.ValidateCardNumber(cardNumber);
        if ( cardNumber[0] != '4')
            throw new ArgumentException("A Visa card number must start with 4.", nameof(cardNumber));
    }

    public void Test()
    {

    }
}
