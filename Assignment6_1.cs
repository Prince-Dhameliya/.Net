using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_1
{
    class SelectionSort
    {
        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparision)
        {
            for (int i = 0; i < sortArray.Count - 1; i++)
            {
                int key = i;
                for (int j = i + 1; j < sortArray.Count; j++)
                {
                    if (comparision(sortArray[j], sortArray[key]))
                    {
                        key = j;
                    }
                }
                T temp = sortArray[i];
                sortArray[i] = sortArray[key];
                sortArray[key] = temp;
            }
        }
    }

    public enum Designations
    {
        CEO = 5,
        CFO = 4,
        sde = 3,
        ba = 2,
        pm = 1,
    }

    class Employee
    {
        int empid;
        public float salary;
        public string name;
        public Designations designation;

        public Employee(int EmpId, float Salary, string Name, Designations Designations)
        {
            this.empid = EmpId;
            this.salary = Salary;
            this.name = Name;
            this.designation = Designations;
        }

        internal static bool CompareSalary(Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }

        internal static bool CompareDesignations(Employee e1, Employee e2)
        {
            return e1.designation < e2.designation;
        }
    }


    public class TestGenericMethods
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>(30);

            emplist.Add(new Employee(612001, 200000, "Prince", Designations.CFO));
            emplist.Add(new Employee(612002, 450000, "Simant", Designations.CEO));
            emplist.Add(new Employee(612003, 250000, "Rajdeep", Designations.CEO));
            emplist.Add(new Employee(612004, 600000, "Dhruv", Designations.sde));
            emplist.Add(new Employee(612005, 900000, "Mandeep", Designations.CFO));
            emplist.Add(new Employee(612006, 780000, "Dipak", Designations.sde));

            SelectionSort.Sort<Employee>(emplist, Employee.CompareSalary);

            foreach (Employee e1 in emplist)
            {
                Console.WriteLine($"Salary :- {e1.salary}, Employee Name :- {e1.name}");
            }
        }
    }
}