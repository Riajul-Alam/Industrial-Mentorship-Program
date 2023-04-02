using EncapsulationExample;

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1234,1000);

        //Console.WriteLine("Balance: "+ myAccount._balance); // gives error

        myAccount.Deposit(500);
        Console.WriteLine("Balance: "+ myAccount.Balance);

        myAccount.Withdraw(1200);
        Console.WriteLine("Balance: "+ myAccount.Balance);

        myAccount.Withdraw(1200);
    }
}





