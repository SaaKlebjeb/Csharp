using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance02
{
    public class Staff : Person
    {
        protected double salary;
        protected string position;

        public void Input()
        {
            base.Input();
            Console.Write("Input Position:");
            position = Console.ReadLine();
            Console.Write("Input Salary:");
            salary = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("Position:"+position);
            Console.WriteLine("Salary:"+salary);
        }
    }
}
