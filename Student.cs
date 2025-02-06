using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance02
{
    public class Student:Person
    {
        protected double score;
        public void Input()
        {
            base.Input();
            Console.Write("Input Score:");
            score = double.Parse(Console.ReadLine());
            
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("Score:" + score);
        }
    }
}
