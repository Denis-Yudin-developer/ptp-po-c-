using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Derived3 : Derived2
    {
        private string bestEmployees;
        protected string workingHours;
        public int machinesNumber;
        public int machinePrice;

        public Derived3()
        {
            bestEmployees = "Ильяс Бажов";
            workingHours = "8:00 -- 22:00";
            machinesNumber = 40;
            machinePrice = 100_000;
        }

        public Derived3(string bestEmployees)
        {
            this.bestEmployees = bestEmployees;
            workingHours = "8:00 -- 22:00";
            machinesNumber = 40;
            machinePrice = 100_000;
        }

        public Derived3(string bestEmployees, string workingHours)
        {
            this.bestEmployees = bestEmployees;
            this.workingHours = workingHours;
            machinesNumber = 40;
            machinePrice = 100_000;
        }

        private void ChangeBestEmployee(string newBestEmployee)
        {
            bestEmployees = newBestEmployee;
        }

        protected void ChangeWorkingHours(string newWorkingHours)
        {
            workingHours = newWorkingHours;
        }

        public void increaseMachinesNumber(int readyMachines)
        {
            machinesNumber += readyMachines;
            totalRevenue = machinesNumber * machinePrice;
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Введите имя и фамилию лучшего сотрудника месяца:");
            this.bestEmployees = Console.ReadLine();
            Console.WriteLine("Введите рабочие часы:");
            this.workingHours = Console.ReadLine();
            Console.WriteLine("Введите количество произведенных станков:");
            this.machinesNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("Лучший сотрудник месяца: " + bestEmployees);
            Console.WriteLine("Рабочие часы: " + workingHours);
            Console.WriteLine("Количество готовых станков: " + machinesNumber);
            Console.ReadKey(true);
        }
        ~Derived3()
        {
            bestEmployees = null;
            workingHours = null;
            machinesNumber = -1;
            machinePrice = -1;
        }
    }
}
