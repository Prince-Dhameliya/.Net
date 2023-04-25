// See https://aka.ms/new-console-template for more information
using System;

[Flags]
public enum Days
{
    None = 0b_0000_0000,  // 0
    Monday = 0b_0000_0001,  // 1
    Tuesday = 0b_0000_0010,  // 2
    Wednesday = 0b_0000_0100,  // 4
    Thursday = 0b_0000_1000,  // 8
    Friday = 0b_0001_0000,  // 16
    Saturday = 0b_0010_0000,  // 32
    Sunday = 0b_0100_0000,  // 64
    Weekend = Saturday | Sunday
}

public class TempRecord
{
    float[] temps = new float[10]
    {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    };

    public int Length => temps.Length;
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }
}

class Assignment3
{

    public static void question1()
    {
        Console.WriteLine("Enter a numerator and denominator in sequence");
        int i = Convert.ToInt32(Console.ReadLine());
        int j = Convert.ToInt32(Console.ReadLine());
        int quotient = i / j;
        int remainder = i % j;
        float ans = (float)i / (float)j;
        Console.WriteLine($"Floating point division result = {ans}");
        Console.WriteLine($"Integer division result = {quotient} with a remainder {remainder}");
        Console.WriteLine($"The result as a mixed fraction is {quotient} {remainder}/{j}");
    }

    public static void question2()
    {
        Console.WriteLine("Enter a string to get length");
        string input = Console.ReadLine();
        Console.WriteLine(input.Length);

        Console.WriteLine("Enter a string to see what type of sentence is");
        input = Console.ReadLine();
        if (input.Length == 0)
        {
            Console.WriteLine("You haven't typed anything");
        }
        else
        {
            char lastChar = input[input.Length - 1];
            if (lastChar == '?')
            {
                Console.WriteLine("interrogatory sentence");
            }
            else if (lastChar == '!')
            {
                Console.WriteLine("exclamation sentence");
            }
            else if (lastChar == '.')
            {
                Console.WriteLine("declarative sentence");
            }
            else
            {
                Console.WriteLine("it's not sentence");
            }
        }

        Console.WriteLine("Enter a firstname and lastname in sequence");
        input = Console.ReadLine();
        var name = input.Split(' ');
        if (name.Length == 1)
        {
            Console.WriteLine(name[0]);
        }
        else
        {
            Console.WriteLine($"{name[1]}, {name[0]}");
        }
    }

    public static void question3()
    {
        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine(meetingDays);

        Days workingFromHomeDays = Days.Thursday | Days.Friday;
        Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

        var a = (Days)37;
        Console.WriteLine(a);
    }

    public static void question4()
    {
        var tempRecord = new TempRecord();

        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;
        Console.WriteLine($"Length of array is {tempRecord.Length}");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        }
    }

    public static void Main(string[] args)
    {
        question1();
        question2();
        question3();
        question4();
    }
}