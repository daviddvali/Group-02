using System;
using System.Collections.Generic;
using System.Text;

namespace G02_BankSystem.Cards;

public sealed class MasterCard : Card
{
    public MasterCard(
        string cardNumber,
        string cardHolderName,
        DateOnly expiryDate,
        string cvv) : base(cardNumber, cardHolderName, expiryDate, cvv)
    {

    }

    public override decimal WithdrawFee => 0.2m;


     public override void ValidateCardNumber(string cardNumber)
    {
        ArgumentNullException.ThrowIfNull(cardNumber);

        if (cardNumber.Length != 16 || cardNumber[0] != '5' || !IsOnlyNumbers(cardNumber))
            throw new ArgumentException("A MasterCard number must start with 5 and contain only digits.", nameof(cardNumber));
    }
}
