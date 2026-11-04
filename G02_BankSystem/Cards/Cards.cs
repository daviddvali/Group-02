using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G02_BankSystem.Cards;

public abstract class Card
{
    public Card(string cardNumber,
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

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount must be positive.");
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawal amount must be positive.");

        decimal totalAmount = amount + CalculateWithdrawFee(amount);
        if (totalAmount > Balance)
            throw new InvalidOperationException("Insufficient funds.");
        Balance -= totalAmount;
    }

    public virtual void Deactivate()
    {
        if (!IsActive)
            throw new InvalidOperationException("The card is already deactivated.");
        IsActive = false;
    }

    public virtual void Activate()
    {
        if (IsActive)
            throw new InvalidOperationException("The card is already activated.");
        IsActive = true;
    }

    private decimal CalculateWithdrawFee(decimal amount)
    {
        return amount * WithdrawFee;
    }

    public abstract void ValidateCardNumber(string cardNumber);


    private static void ValidateCardHolderName(string cardHolderName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(cardHolderName);
    }

    private static void ValidateExpiryDate(DateOnly expiryDate)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        DateOnly firstDayOfCurrentMonth = new DateOnly(today.Year, today.Month, 1);

        // Card expiry uses the year and month; the day is ignored.
        if (expiryDate < firstDayOfCurrentMonth)
            throw new ArgumentOutOfRangeException(nameof(expiryDate), "The card has expired.");
    }

    private static void ValidateCVV(string cvv)
    {
        ArgumentNullException.ThrowIfNull(cvv);

        if (cvv.Length != 3 || !IsOnlyNumbers(cvv))
            throw new ArgumentException("A Visa CVV must contain exactly 3 digits.", nameof(cvv));
    }

    protected static bool IsOnlyNumbers(string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        foreach (char c in text)
        {
            if (!char.IsBetween(c, '0', '9')) 
                return false;   
        }

        return true;

    }
}
