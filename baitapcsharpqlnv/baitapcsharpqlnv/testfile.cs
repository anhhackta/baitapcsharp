using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public DateTime HireDate { get; set; }
    public string IDCardNumber { get; set; }

    public Employee(string fullName, DateTime dateOfBirth, string gender, DateTime hireDate, string idCardNumber)
    {
        FullName = fullName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        HireDate = hireDate;
        IDCardNumber = idCardNumber;
    }
}

class PermanentEmployee : Employee
{
    public double Coefficient { get; set; }
    public double BasicSalary { get; set; }
    public double Allowance { get; set; }

    public PermanentEmployee(string fullName, DateTime dateOfBirth, string gender, DateTime hireDate, string idCardNumber, double coefficient, double basicSalary)
        : base(fullName, dateOfBirth, gender, hireDate, idCardNumber)
    {
        Coefficient = coefficient;
        BasicSalary = basicSalary;
    }

    public double CalculateSalary()
    {
        double seniority = (DateTime.Now - HireDate).TotalDays / 365;
        Allowance = (seniority >= 10) ? 500000 : 200000;
        return Coefficient * BasicSalary + Allowance;
    }
}

class ContractEmployee : Employee
{
    public double ContractSalary { get; set; }

    public ContractEmployee(string fullName, DateTime dateOfBirth, string gender, DateTime hireDate, string idCardNumber, double contractSalary)
        : base(fullName, dateOfBirth, gender, hireDate, idCardNumber)
    {
        ContractSalary = contractSalary;
    }

    public double CalculateSalary()
    {
        double seniority = (DateTime.Now - HireDate).TotalDays / 365;
        double allowance = (seniority >= 2) ? 200000 : 100000;
        return ContractSalary + allowance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();


        // Nhập danh sách nhân viên
        Console.WriteLine("Nhập thông tin nhân viên:");
        Console.Write("Họ và tên: ");
        string fullName = Console.ReadLine();
        Console.Write("Ngày sinh (dd/MM/yyyy): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Giới tính: ");
        string gender = Console.ReadLine();
        Console.Write("Ngày vào cơ quan (dd/MM/yyyy): ");
        DateTime hireDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Số chứng minh: ");
        string idCardNumber = Console.ReadLine();
        Console.Write("Nhập loại nhân viên (1 - Biên chế, 2 - Hợp đồng): ");
        int employeeType = int.Parse(Console.ReadLine());

        if (employeeType == 1)
        {
            Console.Write("Hệ số lương: ");
            double coefficient = double.Parse(Console.ReadLine());
            Console.Write("Lương cơ bản: ");
            double basicSalary = double.Parse(Console.ReadLine());
            employees.Add(new PermanentEmployee(fullName, dateOfBirth, gender, hireDate, idCardNumber, coefficient, basicSalary));
        }
        else if (employeeType == 2)
        {
            Console.Write("Mức lương: ");
            double contractSalary = double.Parse(Console.ReadLine());
            employees.Add(new ContractEmployee(fullName, dateOfBirth, gender, hireDate, idCardNumber, contractSalary));
        }
        else
        {
            Console.WriteLine("Loại nhân viên không hợp lệ!");
        }

        // In thông tin nhân viên
        Console.WriteLine("\nThông tin nhân viên:");
        foreach (var emp in employees)
        {
            Console.WriteLine($"Họ và tên: {emp.FullName}");
            Console.WriteLine($"Ngày sinh: {emp.DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Giới tính: {emp.Gender}");
            Console.WriteLine($"Ngày vào cơ quan: {emp.HireDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Số chứng minh: {emp.IDCardNumber}");
            if (emp is PermanentEmployee)
            {
                PermanentEmployee pEmp = (PermanentEmployee)emp;
                Console.WriteLine($"Loại nhân viên: Biên chế");
                Console.WriteLine($"Lương: {pEmp.CalculateSalary()}");
            }
            else if (emp is ContractEmployee)
            {
                ContractEmployee cEmp = (ContractEmployee)emp;
                Console.WriteLine($"Loại nhân viên: Hợp đồng");
                Console.WriteLine($"Lương: {cEmp.CalculateSalary()}");
            }
            Console.WriteLine();
        }

        // Tính tổng quỹ lương
        double totalSalaryFund = employees.Sum(emp => {
            if (emp is PermanentEmployee)
            {
                return ((PermanentEmployee)emp).CalculateSalary();
            }
            else if (emp is ContractEmployee)
            {
                return ((ContractEmployee)emp).CalculateSalary();
            }
            return 0;
        });
        Console.WriteLine($"Tổng quỹ lương phải trả: {totalSalaryFund}");
    }
}
