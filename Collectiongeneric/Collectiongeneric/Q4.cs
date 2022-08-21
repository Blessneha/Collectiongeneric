using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collectiongeneric
{

    public class Bookstore
    {
        public int bookid;
        public string bookname;
    }
        
    internal class Q4
    {

        public void sol4()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            int n;
            Console.WriteLine("Enter the number of detaisl: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Bookstore b = new Bookstore();
                b.bookid = Convert.ToInt32(Console.ReadLine());
                b.bookname = Console.ReadLine();
                d.Add(b.bookid, b.bookname);
            }

            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }
        }
    }
}
