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
            Planete p1 = new Planete("Saturne", 15, 20);
            Planete p2 = new Planete("Saturne", 15, 20);

            bool valeur = p1 < p2;

            Lune l1 = new Lune("Allo", 15, 15);

            p1[0] = l1;

            Console.Write(p1 == p2);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.CompareTo(p2));
            Console.ReadLine();

            
        }
    }
}
