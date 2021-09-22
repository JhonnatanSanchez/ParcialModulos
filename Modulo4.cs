using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialModulos
{
    class Modulo4
    {
        string invertir;

        public string Reverse(string PalabraReverso)
        {
            char[] cArray = PalabraReverso.ToCharArray();
            string invertir = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                invertir += cArray[i];
            }
            return invertir;
        }
    }
}
