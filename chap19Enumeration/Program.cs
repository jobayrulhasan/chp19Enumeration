using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap19Enumeration
{
    class Program
    {
        public static System.Collections.IEnumerable myNumber()
        {
            yield return 12;
            yield return 22;
            yield return 28;
            yield return 25;
            yield return 33;
            yield return 40;
            yield return 48;
        }
        static void Main(string[] args)
        {
            foreach (int  item in myNumber())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
      
    }
}
