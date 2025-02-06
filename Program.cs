using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            int n;
            Console.Write("Input value N:");
            n = int.Parse(Console.ReadLine());
            Student[] stu = new Student[n];
            Teacher[] tc = new Teacher[n];
            Cleaner[] cln = new Cleaner[n];
            int i, j;
            string op;
            do
            {
                Console.Write("Choose an option of 3 class:");
                op = Console.ReadLine();
                switch (op)
                {
                    case "Student":
                        {
                            Console.WriteLine("================================ABOUT STUDENT==============================");
                            int opt;
                            do
                            {
                                Console.Write("Select an option with Student class:");
                                opt= int.Parse(Console.ReadLine());
                                switch (opt)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("========================INPUT==========================");
                                            for (i = 0; i < n; i++)
                                            {
                                                stu[i] = new Student();
                                                Console.WriteLine("========================================================");
                                                stu[i].Input();
                                            }
                                            if(stu!=null){
                                                Console.WriteLine("Input successfully...!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please Input data...!");
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("=========================OUTPUT===========================");
                                            for(i = 0; i < n; i++)
                                            {
                                                Console.WriteLine("========================================================");
                                                stu[i].Output();
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("=============================SEARCH===========================");
                                            int sid;
                                            Console.Write("Input ID to search:");
                                            bool found = false;
                                            sid = int.Parse(Console.ReadLine());
                                            for (i = 0; i < n; i++)
                                            {
                                                if (stu[i].GetID() == sid)
                                                {
                                                    stu[i].Output();
                                                    found = true;
                                                    Console.WriteLine("Successfully...!");
                                                }
                                            }
                                            if (found == false)
                                            {
                                                Console.WriteLine("Searching error...!");
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("=================================SORT==================================");
                                            Student temp;
                                            for (i = 0; i < n ; i++) // Iterate n-1 times
                                            {
                                                for (j = i+1; j < n; j++) // Compare adjacent elements
                                                {
                                                    if (stu[i].GetID() > stu[j].GetID()) // Swap if needed
                                                    {
                                                        temp = stu[i];
                                                        stu[i] = stu[j];
                                                        stu[j] = temp;
                                                    }
                                                }
                                            }
                                            Console.WriteLine("==========================THE RESULT AFTER SORT======================");
                                                for (i = 0; i < n; i++)
                                               {
                                                    Console.WriteLine("========================================================");
                                                    stu[i].Output();

                                                }
                                            

                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine("================================UPDATE===============================");
                                            int upid;
                                            bool found = false;
                                            Console.Write("Input an ID that you want to update:");
                                            upid = int.Parse(Console.ReadLine());
                                            for (i = 0; i < n; i++)
                                            {
                                                if (stu[i].GetID() == upid)
                                                {
                                                    stu[i].Input();
                                                    found = true;
                                                    
                                                }
                                            }
                                            if (found==false)
                                            {
                                                Console.WriteLine("Updating errror...!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("successfully...!");
                                                Console.WriteLine("==========================THE RESULT AFTER UPDATE======================");
                                                for (i = 0; i < n; i++)
                                                {
                                                    Console.WriteLine("========================================================");
                                                    stu[i].Output();

                                                }

                                            }
                                        }
                                        break;
                                    case 6:
                                        {
                                            Console.WriteLine("===============================DELETE==========================");
                                            string sname;
                                            bool del = false;
                                            Console.Write("Input name to delete:");
                                            sname = Console.ReadLine();
                                            for (i = 0; i < n; i++)
                                            {
                                                if (stu[i].GetName().Equals(sname))
                                                {
                                                    for (j = i; j < n-1; j++)
                                                    {
                                                        stu[j] = stu[j + 1];
                                                        del = true;
                                                    }
                                                }
                                            }
                                            n--;
                                            if (del==false)
                                            {
                                                Console.WriteLine("Deleting error...!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("successfully...!");
                                                Console.WriteLine("==========================THE RESULT AFTER DELETE======================");
                                                for (i = 0; i < n; i++)
                                                {
                                                    Console.WriteLine("========================================================");
                                                    stu[i].Output();

                                                }
                                            }
                                        }
                                        break;
                                    case 7:
                                        {
                                           
                                        }
                                        break;
                                }

                            }
                            while (opt!=0);

                        }
                        break;
                }
            }
            while (op!=null);
            Console.ReadKey();
        }
    }
}
