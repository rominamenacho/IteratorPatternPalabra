using System.Collections;

namespace IteratorPattern_Native
{
    public class PalabraIterator: IEnumerator
    {
        private char [] palabra;
        int _pos;

        public PalabraIterator(string palabra)
        {
            this.palabra = palabra.ToCharArray();
            _pos = -1;
        }

        public object Current => palabra[_pos];

        public bool MoveNext()
        {
           if(_pos < palabra.Length - 1)
            {
                _pos++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _pos = -1;
        }
    }
}