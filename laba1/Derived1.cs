using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Derived1 : Base
    {
        private string phoneNumber;
        protected string director;
        public Boolean isOpen;

        public Derived1()
        {
            this.phoneNumber = "89603254115";
            this.director = "Anton Anahin";
            this.isOpen = true;
        }

        public Derived1(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            this.director = "Anton Anahin";
            this.isOpen = true;
        }

        public Derived1(string phoneNumber, string director)
        {
            this.phoneNumber = phoneNumber;
            this.director = director;
            this.isOpen = true;
        }

        private string FormatNumberToInternational()
        {
            return "+7" + phoneNumber.Substring(1);
        }

        protected void ChangeDirector(string newDirector)
        {
            if (this.director != newDirector)
            {
                this.director = newDirector;
            }
            else
            {
                Console.WriteLine("Этот директор уже управляет данной компании");
            }
        }

        public string IsCompanyOpen()
        {
            if (isOpen)
            {
                return "открыта";
            }
            else
            {
                return "закрыта";
            }
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Введите телефонный номер:");
            this.phoneNumber = Console.ReadLine();
            Console.WriteLine("Введите имя директора:");
            this.director = Console.ReadLine();
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("Телефонный номер:" + phoneNumber);
            Console.WriteLine("Имя директор:" + director);
            Console.WriteLine("Статус компании:" + IsCompanyOpen());
        }
        //TODO деструктор
        ~Derived1()
        {
            phoneNumber = null;
            director = null;
            isOpen = false;
        }
    }
}
