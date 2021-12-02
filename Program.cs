using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Native
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Palabra p = new Palabra("hola mundo");

            foreach(var letra in p)
            {
                Console.WriteLine(letra);
            }
            */

            foreach (var letra in new Palabra("hola juan carlos"))
            {
                Console.WriteLine(letra);
            }


            Console.ReadKey();
        }
    }
}
