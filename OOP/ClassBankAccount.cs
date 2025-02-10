namespace learningCSharp.OOP;
/*
 * Create a class BankAccount with properties AccountNumber (string) and
 * Balance (double). Implement methods for depositing and withdrawing money.
 * Use encapsulation to make the Balance property private and provide
 * controlled access through public methods.  Add error handling
 * (e.g., prevent withdrawals that would result in a negative balance).
 */
public class ClassBankAccount
{
    public string AccountNumber { get; }
    private double _balance;

    public ClassBankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        _balance = initialBalance;
    }

    public double Balance { get => _balance; }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        _balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${_balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        if(amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        _balance -= amount;
        Console.WriteLine($"Withdrew ${amount}. New balance: ${_balance}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Account Number: ${AccountNumber}, Current Balance: ${_balance}");
    }
}
