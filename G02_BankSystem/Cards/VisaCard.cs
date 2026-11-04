namespace G02_BankSystem.Cards;

public sealed class VisaCard : Card
{
    public VisaCard(
        string cardNumber,
        string cardHolderName,
        DateOnly expiryDate,
        string cvv) : base(cardNumber, cardHolderName, expiryDate, cvv)
    {
        
    }
    public override decimal WithdrawFee => 0.01m;


    

    public override void ValidateCardNumber(string cardNumber)
    {
        ArgumentNullException.ThrowIfNull(cardNumber);

        if (cardNumber.Length != 16 || cardNumber[0] != '4' || !IsOnlyNumbers(cardNumber))
            throw new ArgumentException("A Visa card number must start with 4 and contain only digits.", nameof(cardNumber));
    }
      
}