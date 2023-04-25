// See https://aka.ms/new-console-template for more information
using System;

class Assignment2
{
    public static void fibonacci()
    {
        int a = 0, b = 1, c = 1;
        Console.WriteLine("Enter a number of which you want fibonacci series:");
        long n = Convert.ToInt32(Console.ReadLine());
        Console.Write(a+" ");
        Console.Write(b+" ");
        for (long i = 2; i < n; ++i)
        {
            c = a + b;
            Console.Write(c+" ");
            a = b;
            b = c;
        }
        Console.Write("\n");
    }

    public static void factorial()
    {
        long fact = 1;
        Console.WriteLine("Enter a number of which you want factorial number:");
        long n = Convert.ToInt32(Console.ReadLine());

        for (long i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }

    public static void permutation(int i, int j, String s)
    {
        if(i == j)
        {
            Console.WriteLine(s);
            return;
        }

        for(int l = i; l <= j; ++l)
        {
            s = swap(s, l, i);
            permutation(i + 1, j, s);
            s = swap(s, l, i);
        }
    }

    public static String swap(String s, int i, int j)
    {
        char[] chars = s.ToCharArray();
        char temp = chars[i];
        chars[i] = chars[j];
        chars[j] = temp;
        return new String(chars);
    }


    public static void Main(string[] args)
    {
        fibonacci();
        factorial();
        Console.WriteLine("Enter a string of which you want all permutations");
        String s = Console.ReadLine();
        Console.WriteLine("Permutation of above string is:");
        permutation(0, s.Length- 1, s);

    }
}




