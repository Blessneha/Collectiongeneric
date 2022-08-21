using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collectiongeneric
{

    public class Organization
    {
        public int empcode;
        public string empname;
    }
    internal class Q3
    {

        public void sol3()
        {
            SortedList<int,string> obj = new SortedList<int ,string>();
            Console.WriteLine("Enter the no of student details to add: ");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Organization o= new Organization();
                
                o.empcode = Convert.ToInt32(Console.ReadLine());
                o.empname = Console.ReadLine();
                obj.Add(o.empcode,o.empname);


            }
            foreach(KeyValuePair<int,string> kvp in obj)
           
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");

            }


        }
    }
}
