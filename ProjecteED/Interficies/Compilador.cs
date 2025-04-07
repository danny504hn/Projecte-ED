using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteED.Interficies
{
    public class Compilador
    {
        public static bool Validar(string expressio)
        {
            Pila<char> pila = new Pila<char>();

            foreach (char c in expressio)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.IsEmpty) return false;

                    char ultimObert = pila.Pop();

                    if (!(ultimObert == '(' && c == ')' ||
                          ultimObert == '[' && c == ']' ||
                          ultimObert == '{' && c == '}'))
                    {
                        return false;
                    }
                }
            }

            return pila.IsEmpty;
        }
    }
}
