using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Derived2 : Base
    {
        private string productionDirection;
        protected int totalRevenue;
        public string taxationType;

        public Derived2()
        {
            productionDirection = "Производство станков ЧПУ";
            totalRevenue = 1_000_000;
            taxationType = "УСН";
        }

        public Derived2(string productionDirection)
        {
            this.productionDirection = productionDirection;
            totalRevenue = 1_000_000;
            taxationType = "УСН";
        }

        public Derived2(string productionDirection, int totalRevenue)
        {
            this.productionDirection=productionDirection;
            this.totalRevenue = totalRevenue; 
            taxationType = "УСН";
        }

        private int calculateTaxes()
        {
            return Convert.ToInt32(0.08 * totalRevenue);
        }
        
        protected void AddIncomeForMonth(int income)
        {
            totalRevenue += (income - calculateTaxes());
        }

        public void ChangeTaxationType(string newTaxationType)
        {
            taxationType = newTaxationType;
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Введите направление производства:");
            this.productionDirection = Console.ReadLine();
            Console.WriteLine("Введите выручку компании:");
            this.totalRevenue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите статус налогообложения:");
            this.taxationType = Console.ReadLine();
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("Направление производства: " + productionDirection);
            Console.WriteLine("Общая выручка: " + totalRevenue);
            Console.WriteLine("Тип налогообложения: " + taxationType);
            Console.ReadKey(true);
        }
        //TODO сделать деструктор
        ~Derived2()
        {
            productionDirection = null;
            totalRevenue = -1;
            taxationType = null;
        }
    }
}
