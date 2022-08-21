using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiongeneric
{  
    public class Student
    {
        public int stid;
        public string name;
    }
    internal class Q6
    {
        public void sol6()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            int n;
            Console.WriteLine("Enter the number of detaisl: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student b=new Student();
                b.stid = Convert.ToInt32(Console.ReadLine());
                b.name = Console.ReadLine();
                d.Add(b.stid, b.name);
            }

            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
        }
    }
}
