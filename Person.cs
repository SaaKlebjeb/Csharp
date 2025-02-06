using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance02
{
    public class Person
    {
        protected int id { get; set; }
        protected string name { get; set; }
        protected string gender { get; set; }
        protected int age { get; set; }

        //ID
        public int GetID()
        {
            return id;
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        //name
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        

        public void Input()
        {
            Console.Write("Input ID:");
            id = int.Parse(Console.ReadLine());
            Console.Write("Input Name:");
            name = Console.ReadLine();
            Console.Write("Input Gender:");
            gender = Console.ReadLine();
            Console.Write("Input Age:");
            age = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("ID:"+id);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Gender:"+gender);
            Console.WriteLine("Age:"+age);
        }
    }
}
