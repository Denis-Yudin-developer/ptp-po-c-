using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived2 derived2 = new Derived2();
            Derived1 derived1 = new Derived1("84157260090");
            Derived3 derived3 = new Derived3("Денис Удин", "12:00 -- 22:00");
            derived2.Input();
            derived2.ChangeTaxationType("ОСН");
            derived2.Output();
        }
    }
}
