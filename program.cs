using System;
class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount acc1=new  SavingsAccount(2000.00);
        acc1.Deposit(1000.00);
        acc1.Withdraw(500.00);
        CurrentAccount acc2=new CurrentAccount(3000.00);
        acc2.Deposit(2000.00);
        acc2.Withdraw(1000.00);
        acc1.ShowBalance();
        acc2.ShowBalance();
    }
}