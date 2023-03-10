using System.Threading.Channels;

namespace Exercise_7;

public class SavingsAccount
{
    private decimal _bilance;
    private decimal _amountAdd;
    private decimal _amountRemove;
    private decimal _interestCharged;
    private decimal _reportInterest; 
    public decimal annualRate = 5;
    public decimal accOpened = 4;

    public SavingsAccount(decimal bilance, decimal amountAdd, decimal amountRemove, decimal interestCharged, decimal reportInterest)
    {
        _bilance = bilance;
        _amountAdd = amountAdd;
        _amountRemove = amountRemove;
        _interestCharged = interestCharged;
        _reportInterest = reportInterest;
    }

    public decimal Interest(decimal amount)
    {
        decimal monthlyRate = annualRate/12;
        decimal interest = monthlyRate * _bilance;
        _reportInterest += interest;
        _interestCharged = interest;

        return interest;
    }
    public decimal GetBalance()
    {
        return _bilance;
    }

    public decimal AddingDeposit (decimal amount)
    {
        _amountAdd += amount;
        _bilance += amount;
        return amount;
    }
    public decimal Withdrawal(decimal amount)
    {
        if (amount > _bilance)
        {
            return 0;
        }
        else
        {
            _amountRemove += amount;
            _bilance -= amount;
            Interest(_bilance);
            _bilance += _interestCharged;
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

    public decimal AmmoundInterest()
    {
        return _interestCharged;
    }

    public decimal ReportInterest()
    {
        return _reportInterest;
    }
}