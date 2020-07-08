using System;
using System.Collections.Generic;
using SOLID.DIP;
using SOLID.ISP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------------- SRP --------------------

            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });

            Console.WriteLine(report.ToString());
            Console.WriteLine();

            // ------------- OCP --------------------

            var devReports = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator( new DeveloperReport { Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator( new DeveloperReport { Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator( new DeveloperReport { Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            };

            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
            Console.WriteLine();

            // ------------- LSP --------------------

            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sumCalculator = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sumCalculator.Calculate()}");

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
            Console.WriteLine();

            // ------------- ISP --------------------

            ICar car = new MultiFunctionalCar();
            car.Drive();

            IAirplane airplane = new MultiFunctionalCar();
            airplane.Fly();

            Console.WriteLine();

            // ------------- DIP --------------------

            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
            empManager.AddEmployee(new Employee { Name = "Lina", Gender = Gender.Female, Position = Position.Administrator });

            var empAdmin = new EmployeeAdmin();
            empAdmin.AddEmployee(new Employee { Name = "Lina", Gender = Gender.Female, Position = Position.Administrator });

            var stats = new EmployeeStatistics(empManager);
            var stats1 = new EmployeeStatistics(empAdmin);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
            Console.WriteLine($"Number of female managers in our company is: {stats1.CountFemaleAdmins()}");

            int k = 5;

            int f = k += 1;
            Console.WriteLine(f);
        }
    }
}
