using System;
public abstract class BankAccount
{
    protected double Balance;
    public BankAccount(double b)
    {
        Balance=b;
    }
    public void Deposit(double d)
    {
        Balance+=d;
    }
    public abstract void Withdraw(double w);
    public void ShowBalance()
    {
        Console.WriteLine($"Balance :{Balance}");
    }
}
class SavingsAccount : BankAccount
{
    public SavingsAccount(double b):base(b){}
    public override void Withdraw(double w)
    {
        if (w > Balance)
        {
            Console.WriteLine("Error!");
        }
        else
        {
            Balance-=w;
        }
    }
}
public class CurrentAccount : BankAccount
{
    public CurrentAccount(double b):base(b){}
    public override void Withdraw(double w)
    {
        if (Balance - w <- 500)
        {
            Console.WriteLine("Limit!");
        }
        else
        {
            Balance-=w;
        }
    }
}