using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiongeneric
{
    internal class Q1
    {
        public void sol1()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the number to be added:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            list.Sort();
            Console.WriteLine("Sorted list: ");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
