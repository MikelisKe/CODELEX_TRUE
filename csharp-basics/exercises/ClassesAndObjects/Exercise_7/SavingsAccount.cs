using System.Threading.Channels;

namespace Exercise_7;

public class SavingsAccount
{
    private decimal _balance;
    private decimal _amountAdd;
    private decimal _amountRemove;

    public SavingsAccount(decimal balance, decimal amountAdd, decimal amountRemove)
    {
        _balance = balance;
        _amountAdd = amountAdd;
        _amountRemove = amountRemove;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public decimal AddingDeposit (decimal amount)
    {
        _amountAdd += amount;
        _balance += amount;
       return amount;
    }
    public decimal Withdrawal(decimal amount)
    {
        if (amount > _balance)
        {
            return 0;
        }
        else
        {
            _amountRemove += amount;
            _balance -= amount;
            return amount;
        }
    }

    public decimal AmmoundAdded()
    {
        return _amountAdd;
    }

    public decimal AmmoundRemoved()
    {
        return _amountRemove;
    }
}