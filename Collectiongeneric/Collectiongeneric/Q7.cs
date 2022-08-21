using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiongeneric
{

    public class Employee
    {
        public string name;
        public string designation;
    }

    public class L
    {
        public string na;
        public string[] des;
    }
    internal class Q7
    {
       public void sol7()
        {
            List<Employee> employees = new List<Employee>();
            Console.WriteLine("Enter the no of details: ");
                int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Employee employee = new Employee();
                employee.name = Console.ReadLine();
                employee.designation = Console.ReadLine();
                employees.Add(employee);
            }
            List<L>es=new List<L>();
           
            string[] hes = { "Program Manager", "Project Manager", "Team Lead", "Senior Programmer", "Junior Programmer" };
            for (int i=0;i<hes.Length;i++)
            {
                int count1 = 0;
                foreach (Employee employee in employees)
                {
                    if(employee.designation==hes[i])
                    {
                        count1++;
                    }
                }
                if (count1 != 0)
               { L l = new L();
                    l.des = new string[count1];
                    int k = 0;
                    foreach (Employee employee in employees)
                    {
                        if (employee.designation == hes[i])
                        {
                            l.des[k++] = employee.name;
                        }

                    }
                    l.na = hes[i];
                    es.Add(l);
                }


            }

            foreach (L ye in es)
            {
                Console.Write(ye.na);
                Console.Write(": ");
                foreach(string s in ye.des)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
