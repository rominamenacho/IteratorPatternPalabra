using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Native
{
   public class Palabra:IEnumerable
    {
        string _palabra;

        public Palabra(string palabra)
        {
            _palabra = palabra;
        }

        public IEnumerator GetEnumerator()
        {
            return new PalabraIterator(_palabra);
        }
    }
}
