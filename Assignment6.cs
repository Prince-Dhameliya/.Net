public delegate void MyDelegate(double n); //declaring a delegate

class Account
{
    static int _accountNo;
    static double _balance;

    public Account(int accountNo, double balance)
    {
        _accountNo = accountNo;
        _balance = balance;
    }
    public int AccountNo
    {
        get => _accountNo;
    }

    public double Balance
    {
        get => _balance;
    }

    public static void checkBalance(double balance)
    {
        if (balance < 0)
        {
            Console.WriteLine("you are overdrawn!\n");
        }
        else if (balance < 10)
        {
            Console.WriteLine("your account is very low!\n");
        }
        else if (balance < 100)
        {
            Console.WriteLine("watch your spending carefully!\n");
        }
        else
        {
            Console.WriteLine("you have over $100 in your account!\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDelegate message = Account.checkBalance;

        Account a1 = new Account(612001, 250);
        Console.WriteLine($"Account No. :- {a1.AccountNo}, Balance :- {a1.Balance}");
        message(a1.Balance);

        Account a2 = new Account(612002, 75);
        Console.WriteLine($"Account No. :- {a2.AccountNo}, Balance :- {a2.Balance}");
        message(a2.Balance);

        Account a3 = new Account(612003, -15);
        Console.WriteLine($"Account No. :- {a3.AccountNo}, Balance :- {a3.Balance}");
        message(a3.Balance);

        Account a4 = new Account(612004, 9);
        Console.WriteLine($"Account No. :- {a4.AccountNo}, Balance :- {a4.Balance}");
        message(a4.Balance);
    }
}