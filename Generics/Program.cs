using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            double y = 5.5;
            string z = "r";
            Print<int>(x, "x");
            Print<double>(y, "y");
            Print<string>(z, "z");
            

            SwapList<int> listNum = new SwapList<int>() { 1, 2, 3 };
            Console.WriteLine(listNum[0]);
            listNum.Swap(0,2);
            Console.WriteLine(listNum[0]);

            SwapList<string> listString = new SwapList<string>() { "Racheli", "Rivki", "Ruti" };
            Console.WriteLine(listString[0]);
            listString.Swap(0, 2);
            Console.WriteLine(listString[0]);
            Console.Read();
        }
        static void Print<T>(T obj, string nameObj)
        {
            Console.WriteLine(nameObj +" = "+obj);
        }
    }
}
