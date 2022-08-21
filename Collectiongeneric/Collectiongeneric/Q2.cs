using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiongeneric
{
    internal class Q2
    {
       public void sol2()
        {
            List<string> list = new List<string>();
            Console.WriteLine("enter the no of times you want to add names: ");
            int f=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<f;i++)
            {
                list.Add(Console.ReadLine());   
            }
            list.Sort();
            list.Reverse();

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }

    }
}
