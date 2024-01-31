using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planete p1 = new Planete("Saturne", 10, 20);
            Console.WriteLine(p1.ToString());
            Console.ReadLine();
        }
    }
}
