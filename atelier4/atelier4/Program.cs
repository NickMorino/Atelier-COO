using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Galaxie galaxie1 = new Galaxie("Madame", "Grosse");
            SystemeSolaire systemeSolaire1 = new SystemeSolaire("Gilles");
            Planete planeteMars = new Planete("Mars", 10, 100, 5);
            Lune luneToto = new Lune("Lunos", 10, 290);

            galaxie1 += systemeSolaire1;
            systemeSolaire1 += planeteMars;
            planeteMars += luneToto;


            Console.Write(galaxie1[0][0][0]); 

            Console.ReadKey();
        }
    }
}
