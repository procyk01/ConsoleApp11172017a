using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.IO;



namespace ConsoleApp11172017a
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;

            i = Convert.ToInt16(Console.ReadLine());
            j = Convert.ToInt16(Console.ReadLine());
            k = i + j;

            Console.WriteLine(k);

            AddStuff az = new AddStuff();
            az.jpAdd(i, j);

            
            Console.ReadKey();

        }
    }
}
