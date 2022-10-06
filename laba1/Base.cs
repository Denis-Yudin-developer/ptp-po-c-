using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Base
    {
        private int employeesNumber;
        protected int salary;
        protected string address;
        public string companyName;

        public int EmployeesNumber { get => employeesNumber; set => employeesNumber = value; }
        public int Salary { get => salary; set => salary = value; }
        protected string Address { get => address; set => address = value; }
        public string CompanyName { get => companyName; set => companyName = value; }

        public Base()
        {
            this.employeesNumber = 42;
            this.address = "Krasnay, 40";
            this.companyName = "PSU";
        }

        public Base(int emlployeesNumber)
        {
            this.employeesNumber = emlployeesNumber;
        }

        public Base(int employeesNumber, string address)
        {
            this.employeesNumber=employeesNumber;
            this.address = address;
        }

        private void DismissEmployee()
        {
            employeesNumber--;
        }

        protected int CalculatePremium()
        {
            return Convert.ToInt32(salary * 0.5);
        }

        public int CalcualateTotalSalary()
        {
            return employeesNumber * salary;
        }

        public void Input()
        {
            Console.WriteLine("Введите количество сотрудников:");
            this.employeesNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите зарплату сотрудника:");
            this.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите адрес:");
            this.address = Console.ReadLine();
            Console.WriteLine("Введите название компании:");
            this.companyName= Console.ReadLine();
        }
            
        public void Output()
        {
            Console.WriteLine("Количество сотрудников: " + employeesNumber);
            Console.WriteLine("Зарплата сотрудника: " + salary);
            Console.WriteLine("Адрес компании: " + address);
            Console.WriteLine("Название компании: " + companyName);
        }
        //TODO сделать деструктор
    }
}
