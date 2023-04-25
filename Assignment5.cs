// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;


public interface IVehicle
{
    public double CalculateRent(double Units);
    public void getDetails();
    public DateTime getLastMaintenanceDate();

}

public class Indica : IVehicle
{
    private string _type;
    private double _seater;
    private string _name;
    private string _rentType;
    private double _rentPerUnit;
    private double _age;
    private string _number;
    private DateTime _lastMaintenanceDate;

    public string Type { get => _type; set => _type = value; }
    public double Seater { get => _seater; set => _seater = value; }
    public string Name { get => _name; set => _name = value; }
    public string RentType { get => _rentType; set => _rentType = value; }
    public double RentPerUnit { get => _rentPerUnit; set => _rentPerUnit = value; }
    public double Age { get => _age; set => _age = value; }
    public string NumberOfCar { get => _number; set => _number = value; }
    public DateTime LastMaintenanceDate { get => _lastMaintenanceDate; set => _lastMaintenanceDate = value; }

    public Indica(string type, double seater, string name, string rentType, double rentPerUnit, double age, string number, DateTime lastMaintenanceDate)
    {
        _type = type;
        _seater = seater;
        _name = name;
        _rentType = rentType;
        _rentPerUnit = rentPerUnit;
        _age = age;
        _number = number;
        _lastMaintenanceDate = lastMaintenanceDate;
    }

    public double CalculateRent(double Units)
    {
        if (RentType == "perDay")
        {
            return (double)RentPerUnit * Units;
        }
        else
        {
            return (double)RentPerUnit * Units;
        }
    }

    public void getDetails()
    {
        Console.Write($"-> Brand : Indica, Car Number : {_number}, Total Seats : {_seater}, Type : {_type}, Car age : {_age}, Rent Per Unit : {_rentPerUnit}\n");
    }

    public DateTime getLastMaintenanceDate()
    {
        return _lastMaintenanceDate;
    }
}

public class Qualis : IVehicle
{
    private string _type;
    private double _seater;
    private string _name;
    private string _rentType;
    private double _rentPerUnit;
    private double _age;
    private string _number;
    private DateTime _lastMaintenanceDate;

    public string Type { get => _type; set => _type = value; }
    public double Seater { get => _seater; set => _seater = value; }
    public string Name { get => _name; set => _name = value; }
    public string RentType { get => _rentType; set => _rentType = value; }
    public double RentPerUnit { get => _rentPerUnit; set => _rentPerUnit = value; }
    public double Age { get => _age; set => _age = value; }
    public string NumberOfCar { get => _number; set => _number = value; }
    public DateTime LastMaintenanceDate { get => _lastMaintenanceDate; set => _lastMaintenanceDate = value; }

    public Qualis(string type, double seater, string name, string rentType, double rentPerUnit, double age, string number, DateTime lastMaintenanceDate)
    {
        _type = type;
        _seater = seater;
        _name = name;
        _rentType = rentType;
        _rentPerUnit = rentPerUnit;
        _age = age;
        _number = number;
        _lastMaintenanceDate = lastMaintenanceDate;
    }

    public double CalculateRent(double Units)
    {
        if (RentType == "perDay")
        {
            return (double)RentPerUnit * Units;
        }
        else
        {
            return (double)RentPerUnit * Units;
        }
    }

    public void getDetails()
    {
        Console.Write($"-> Brand : Qualis, Car Number : {_number}, Total Seats : {_seater}, Type : {_type}, Car age : {_age}, Rent Per Unit : {_rentPerUnit}\n");
    }

    public DateTime getLastMaintenanceDate()
    {
        return _lastMaintenanceDate;
    }
}

public class DavidHarley : IVehicle
{
    private string _type;
    private double _seater;
    private string _name;
    private string _rentType;
    private double _rentPerUnit;
    private double _age;
    private string _number;
    private DateTime _lastMaintenanceDate;

    public string Type { get => _type; set => _type = value; }
    public double Seater { get => _seater; set => _seater = value; }
    public string Name { get => _name; set => _name = value; }
    public string RentType { get => _rentType; set => _rentType = value; }
    public double RentPerUnit { get => _rentPerUnit; set => _rentPerUnit = value; }
    public double Age { get => _age; set => _age = value; }
    public string NumberOfCar { get => _number; set => _number = value; }
    public DateTime LastMaintenanceDate { get => _lastMaintenanceDate; set => _lastMaintenanceDate = value; }

    public DavidHarley(string type, double seater, string name, string rentType, double rentPerUnit, double age, string number, DateTime lastMaintenanceDate)
    {
        _type = type;
        _seater = seater;
        _name = name;
        _rentType = rentType;
        _rentPerUnit = rentPerUnit;
        _age = age;
        _number = number;
        _lastMaintenanceDate = lastMaintenanceDate;
    }

    public double CalculateRent(double Units)
    {
        if (RentType == "perDay")
        {
            return (double)RentPerUnit * Units;
        }
        else
        {
            return (double)RentPerUnit * Units;
        }
    }

    public void getDetails()
    {
        Console.Write($"-> Brand : DavidHarley, Car Number : {_number}, Total Seats : {_seater}, Type : {_type}, Car age : {_age}, Rent Per Unit : {_rentPerUnit}\n");
    }

    public DateTime getLastMaintenanceDate()
    {
        return _lastMaintenanceDate;
    }
}

public class MBenzEclass : IVehicle
{
    private string _type;
    private double _seater;
    private string _name;
    private string _rentType;
    private double _rentPerUnit;
    private double _age;
    private string _number;
    private DateTime _lastMaintenanceDate;

    public string Type { get => _type; set => _type = value; }
    public double Seater { get => _seater; set => _seater = value; }
    public string Name { get => _name; set => _name = value; }
    public string RentType { get => _rentType; set => _rentType = value; }
    public double RentPerUnit { get => _rentPerUnit; set => _rentPerUnit = value; }
    public double Age { get => _age; set => _age = value; }
    public string NumberOfCar { get => _number; set => _number = value; }
    public DateTime LastMaintenanceDate { get => _lastMaintenanceDate; set => _lastMaintenanceDate = value; }

    public MBenzEclass(string type, double seater, string name, string rentType, double rentPerUnit, double age, string number, DateTime lastMaintenanceDate)
    {
        _type = type;
        _seater = seater;
        _name = name;
        _rentType = rentType;
        _rentPerUnit = rentPerUnit;
        _age = age;
        _number = number;
        _lastMaintenanceDate = lastMaintenanceDate;
    }

    public double CalculateRent(double Units)
    {
        if (RentType == "perDay")
        {
            return (double)RentPerUnit * Units;
        }
        else
        {
            return (double)RentPerUnit * Units;
        }
    }

    public void getDetails()
    {
        Console.Write($"-> Brand : MBenzEclass, Car Number : {_number}, Total Seats : {_seater}, Type : {_type}, Car age : {_age}, Rent Per Unit : {_rentPerUnit}\n");
    }

    public DateTime getLastMaintenanceDate()
    {
        return _lastMaintenanceDate;
    }
}

class RentedVehicle<T>
{
    private DateTime _startDateOfRent;
    private DateTime _endDateOfRent;
    private double _noOfKmsTravelled;
    private double _advancePayment;
    private double _units;

    private T carObj;

    public List<RentedVehicle<T>> rentedVehicles;

    public RentedVehicle()
    {
        rentedVehicles = new List<RentedVehicle<T>>();
    }

    public RentedVehicle(T carObj, DateTime startDateOfRent, DateTime endDateOfRent, double advancePayment)
    {
        this.carObj = carObj;
        this._startDateOfRent = startDateOfRent;
        this._endDateOfRent = endDateOfRent;
        this._advancePayment = advancePayment;
    }

    public DateTime StartDateOfRent { get => _startDateOfRent; set => _startDateOfRent = value; }
    public DateTime EndDateOfRent { get => _endDateOfRent; set => _endDateOfRent = value; }
    public double NoOfKmsTravelled { get => _noOfKmsTravelled; set => _noOfKmsTravelled = value; }
    public double AdvancePayment { get => _advancePayment; set => _advancePayment = value; }
    public double Units { get => _units; set => _units = value; }

    public int CalculateDays()
    {
        int year = EndDateOfRent.Year - StartDateOfRent.Year;
        int month = EndDateOfRent.Month - StartDateOfRent.Month;
        int day = EndDateOfRent.Day - StartDateOfRent.Day;

        return year * month + day;
    }

    public void GiveForRent(T carObj, DateTime startDateOfRent, DateTime endDateOfRent, double advancePayment)
    {
        StartDateOfRent = startDateOfRent;
        EndDateOfRent = endDateOfRent;
        AdvancePayment = advancePayment;
        RentedVehicle<T> rh = new RentedVehicle<T>(carObj, startDateOfRent, endDateOfRent, advancePayment);
        rentedVehicles.Add(rh);
    }

    public double CalculateRent(T carObj, int rentPerUnit)
    {
        foreach (RentedVehicle<T> rh in rentedVehicles)
        {
            if (rh.carObj!.Equals(carObj))
            {
                rh.Units = rentPerUnit;
                return ((IVehicle)carObj).CalculateRent(Units) - rh.AdvancePayment;
            }
        }
        return 0;
    }

    public double CalculateTotalRentToday(T carObj, int TravelUnits)
    {
        foreach (RentedVehicle<T> rh in rentedVehicles)
        {
            if (rh.carObj!.Equals(carObj))
            {
                return (((IVehicle)carObj).CalculateRent(TravelUnits) - rh.AdvancePayment) / rh.CalculateDays();
            }
        }
        return 0;
    }

    public void GetCheckListRentedVehicle()
    {
        foreach (RentedVehicle<T> rh in rentedVehicles)
        {
            Console.Write($"@ Rented From {rh.StartDateOfRent} to {rh.EndDateOfRent} :-\n");
            ((IVehicle)rh.carObj!).getDetails();
        }
    }

    public void GetCheckListVehiclesInMaintenance()
    {
        DateTime today = DateTime.Today;
        Console.Write($"@ List of Vehicles in Maintenance :-\n");
        foreach (RentedVehicle<T> rh in rentedVehicles)
        {
            IVehicle car = ((IVehicle)rh.carObj!);
            if (rh.carObj!.Equals(carObj) && car.getLastMaintenanceDate().CompareTo(today) > 0)
            {
                car.getDetails();
            };
        }
    }

    public void ShowAvailableByDate(DateTime date)
    {
        Console.Write($"@ Available Vehicles on {date} :-\n");
        foreach (RentedVehicle<T> rh in rentedVehicles)
        {
            if (rh.StartDateOfRent.CompareTo(date) > 0)
            {
                ((IVehicle)rh.carObj!).getDetails();
            }
        }
    }
}

public class Program
{
    static void Main()
    {
        Indica Indica1 = new Indica("Petrol", 6, "Indica", "perDay", 5000, 2.5, "UP-80K-6547", new DateTime(2020, 09, 29));
        Indica Indica2 = new Indica("Diesel", 6, "Indica", "perDay", 2000, 0.5, "GJ-06J-4381", new DateTime(2022, 02, 13));
        Indica Indica3 = new Indica("Diesel", 6, "Indica", "perKm", 120, 4, "UP-11K-8271", new DateTime(2019, 05, 09));
        Indica Indica4 = new Indica("Petrol", 6, "Indica", "perKm", 150, 1.5, "JK-01P-9875", new DateTime(2022, 02, 09));

        Qualis Qualis1 = new Qualis("Petrol", 8, "Qualis", "perDay", 5000, 2, "AP-96E-6547", new DateTime(2022, 02, 09));
        Qualis Qualis2 = new Qualis("Diesel", 8, "Qualis", "perKm", 250, 1, "GJ-35K-5462", new DateTime(2020, 10, 10));
        Qualis Qualis3 = new Qualis("Petrol", 8, "Qualis", "perDay", 1500, 2.5, "UP-87A-1987", new DateTime(2022, 02, 05));

        DavidHarley DavidHarley1 = new DavidHarley("Diesel", 2, "DavidHarley", "perDay", 6000, 1.5, "GJ-05K-1354", new DateTime(2021, 09, 15));

        MBenzEclass MBenzEClass1 = new MBenzEclass("Diesel", 4, "MBenzEClass", "perKm", 1500, 2, "DL-8SA-1254", new DateTime(2021, 03, 20));
        MBenzEclass MBenzEClass2 = new MBenzEclass("Petrol", 4, "MBenzEClass", "perDay", 10000, 0.5, "DL-89E-2158", new DateTime(2020, 02, 05));

        RentedVehicle<IVehicle> rv = new RentedVehicle<IVehicle>();
        rv.GiveForRent(Indica1, new DateTime(2022, 02, 09), new DateTime(2022, 03, 19), 100);
        rv.GiveForRent(Qualis2, new DateTime(2022, 01, 15), new DateTime(2022, 02, 16), 500);
        rv.GiveForRent(MBenzEClass1, new DateTime(2022, 02, 01), new DateTime(2022, 02, 16), 50);
        rv.GiveForRent(DavidHarley1, new DateTime(2022, 01, 15), new DateTime(2022, 02, 16), 200);

        rv.ShowAvailableByDate(new DateTime(2022, 01, 16));
        Console.WriteLine();
        rv.GetCheckListRentedVehicle();
        Console.WriteLine();
        Console.Write($"Total Rent Per Day : {rv.CalculateTotalRentToday(Indica1, 5):C2}");
    }
}
