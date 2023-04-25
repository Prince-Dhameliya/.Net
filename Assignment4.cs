// See https://aka.ms/new-console-template for more information
using System;

public class Employee
{
    private string _firstName;
    private string _lastName;
    private double _salary;

    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }
    public double Salary { get => _salary; set => _salary = value < 0.0 ? 0.0 : value; }

    public Employee(string FirstName, string LastName, double Salary)
    {
        _firstName = FirstName;
        _lastName = LastName;
        if (Salary <= 0) _salary = 0.0;
        else _salary = Salary;
    }

    public virtual void giveRaise()
    {
        _salary *= 1.1;
    }

    public override string ToString()
    {
        return $"Salary of Employee {_firstName} {_lastName} is: {_salary*12}\n";
    }
}

public class PermanentEmployee : Employee
{
    private double _hra;
    private double _da;
    private double _pf;
    private string _joiningDate;
    private string _retirementDate;
    private double _netSalary;

    public double HRA { get => _hra; set => _hra = value; }
    public double DA { get => _da; set => _da = value; }
    public double PF { get => _pf; set => _pf = value; }
    public string JoiningDate { get => _joiningDate; set => _joiningDate = value; }
    public string RetirementDate { get => _retirementDate; set => _retirementDate = value; }
    public double NetSalary { get => _netSalary; set => _netSalary = value; }

    public PermanentEmployee(string FirstName, string LastName, double Salary, double HRA, double DA, double PF, string JoiningDate, string RetirementDate) : base(FirstName, LastName, Salary)
    {
        _hra = HRA;
        _da = DA;
        _pf = PF;
        _joiningDate = JoiningDate;
        _retirementDate = RetirementDate;
        _netSalary = Salary + _hra + _da + _pf;
    }

    public override string ToString()
    {
        return $"Employee Name: {FirstName + " " + LastName} Basic Salary: {Salary} HRA: {_hra} DA: {_da} PF: {_pf} Joining Date: {_joiningDate} Retirement Date: {_retirementDate} NetSalary: {_netSalary}\n";
    }

    public override void giveRaise()
    {
        this.Salary *= 1.1;
    }
}

class EmployeeTest
{
    static void Main()
    {
        Employee employee1 = new Employee("Prince", "Dhameliya", -50.0);
        Employee employee2 = new Employee("Dhruv", "Raval", 100.0);
        PermanentEmployee employee3 = new PermanentEmployee("Manav", "Gohel", 100000.0, 50000.0, 25000.0, 5000.0, "01-01-2023", "13-02-2023");
        PermanentEmployee employee4 = new PermanentEmployee("Rajdeep", "Danger", 150000.0, 50000.0, 25000.0, 5000.0, "23-01-2023", "28-02-2023");

        Console.Write($"Employee Details : {employee1.ToString()}");
        Console.Write($"Employee Details : {employee2.ToString()}");
        Console.WriteLine("After 10% raise...");
        employee1.giveRaise();
        employee2.giveRaise();
        Console.Write($"Employee Details : {employee1.ToString()}");
        Console.Write($"Employee Details : {employee2.ToString()}\n");                              

        Console.Write($"PermenantEmployee Details : {employee3.ToString()}");
        Console.Write($"PermenantEmployee Details : {employee4.ToString()}");
        Console.WriteLine("After 10% raise...");
        employee3.giveRaise();
        Console.Write($"PermenantEmployee Details : {employee3.ToString()}");
        Console.Write($"PermenantEmployee Details : {employee4.ToString()}");
    }
}